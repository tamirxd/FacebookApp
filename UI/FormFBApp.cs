using System.IO;
using System.Threading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ex03_Logic;
using FacebookWrapper.ObjectModel;

namespace Ex03_UI
{
    public partial class FormFBApp : Form
    {
	private readonly ApplicationLogic r_Logic;

	public AppSettings AppSettings { get; set; }

	private FaceBookConnector m_FBConnector;

	public FormFBApp()
	{
	    r_Logic = new ApplicationLogic();
	    InitializeComponent();
	    initializeComponentSettings();
	    Thread dataInitializationThread = new Thread(() => facebookConnectionInitialization());
	    dataInitializationThread.SetApartmentState(ApartmentState.STA);
	    dataInitializationThread.Start();
	}

	private void facebookConnectionInitialization()
	{
	    loadSettings();
	}

	private void initializeComponentSettings()
	{
	    this.FormClosing += new FormClosingEventHandler(formFBApp_Closed);
	    this.AutoScroll = true;
	    this.Text = "Facebook App";
	    listBoxFriends.HorizontalScrollbar = true;
	    listBoxAlbums.HorizontalScrollbar = true;
	    listBoxAlbumPhotos.HorizontalScrollbar = true;
	    listBoxCheckIns.HorizontalScrollbar = true;
	    pictureBoxLatestPost.Visible = false;
	    richTextBoxLastPost.Visible = false;
	    this.buttonLogin.Enabled = false;
	    this.buttonLogout.Enabled = false;
	    this.buttonAlbums.Enabled = false;
	    this.buttonFriends.Enabled = false;
	    this.buttonCheckIns.Enabled = false;
	    this.buttonWhoLikesYouMost.Enabled = false;
	    this.buttonFriendStatics.Enabled = false;
	    this.checkBoxRememberMe.Enabled = false;
	    this.checkBoxRememberMe.Checked = false;
	    this.buttonPost.Enabled = false;
	    this.buttonSortFriends.Enabled = false;
	}

	private void formFBApp_Closed(object sender, FormClosingEventArgs e)
	{
	    saveAppSettings();

	    try
	    {
		SerializationManager SerializeManager = SerializationFactory.CreateSerializationManager(SerializationFactory.eSerializeTypes.XmlSerialize);
		SerializeManager.Save(AppSettings);
	    }
	    catch (Exception)
	    {
		MessageBox.Show("Error: Failure in saving app settings");
	    }

	    try
	    {
		if (m_FBConnector.Connection.LoggedInUser != null)
		{
		    FaceBookConnector.LogOut();
		}
	    }
	    catch (Exception)
	    {
	    }
	}

	private void saveAppSettings()
	{
	    if (checkBoxRememberMe.Checked)
	    {
		AppSettings.LastAccessToken = m_FBConnector.GetAccsessToken();
	    }
	    else
	    {
		AppSettings.LastAccessToken = null;
	    }

	    AppSettings.LastWindowLocation = this.Location;
	    AppSettings.LastWindowSize = this.Size;
	    AppSettings.RememberUser = this.checkBoxRememberMe.Checked;
	}

	private void loadFromXml()
	{
	    SerializationManager SerializeManager = SerializationFactory.CreateSerializationManager(SerializationFactory.eSerializeTypes.XmlSerialize);
	    AppSettings = new AppSettings();
	    string Path = Directory.GetCurrentDirectory() + @"\\" + AppSettings.GetType().Name + ".xml";
	    AppSettings = SerializeManager.Load(AppSettings) as AppSettings;

	    if (!File.Exists(Path) || !AppSettings.RememberUser || string.IsNullOrEmpty(AppSettings.LastAccessToken))
	    {
		AppSettings = new AppSettings();
		buttonLogin.Enabled = true;
	    }
	}

	private void loadSettings()
	{
	    try
	    {
		loadFromXml();
	    }
	    catch (Exception)
	    {
	    }

	    this.Invoke(new Action(() => updateAppSettings()));
	    updateAppSettings();

	    if (!this.checkBoxRememberMe.Checked)
	    {
		newLogin();
	    }
	    else
	    {
		loginWithAccesToken();
	    }

	    this.Invoke(new Action(() => checkBoxRememberMe.Enabled = true));
	    r_Logic.FriendsInfo = new FriendsStatistics(r_Logic);
	}

	private void updateAppSettings()
	{
	    this.StartPosition = FormStartPosition.Manual;
	    this.Size = AppSettings.LastWindowSize;
	    this.Location = AppSettings.LastWindowLocation;
	    this.checkBoxRememberMe.Checked = AppSettings.RememberUser;
	}

	private void setNameAndProfilePic()
	{
	    this.labelName.Text = r_Logic.LoggedInUser.Name;
	    this.pictureBoxProfilePicture.LoadAsync(r_Logic.LoggedInUser.PictureSqaureURL);
	}

	private void newLogin()
	{
	    m_FBConnector = FaceBookConnector.GetFacebookConnection();
	    if (!string.IsNullOrEmpty(m_FBConnector.Connection.AccessToken))
	    {
		r_Logic.LoggedInUser = m_FBConnector.Connection.LoggedInUser;
		this.Invoke(new Action(() => postLoginUIActions()));
	    }
	    else
	    {
		MessageBox.Show(m_FBConnector.Connection.ErrorMessage);
	    }
	}

	private void getLastPostByUser()
	{
	    Post lastestPost = null;
	    try
	    {
		if (ApplicationLogic.UserData.Posts.Count > 0)
		{
		    lastestPost = r_Logic.LoggedInUser.Posts[0];
		    if (lastestPost.Type.Value == Post.eType.status)
		    {
			richTextBoxLastPost.Visible = true;
			richTextBoxLastPost.Text = lastestPost.Message;
			richTextBoxLastPost.ReadOnly = true;
		    }
		    else if (lastestPost.Type.Value == Post.eType.photo)
		    {
			pictureBoxLatestPost.Visible = true;
			pictureBoxLatestPost.LoadAsync(lastestPost.PictureURL);
		    }
		}
	    }
	    catch (Exception)
	    {
	    }
	}

	private void loginWithAccesToken()
	{
	    m_FBConnector = FaceBookConnector.ConnectToFacebookAPI(AppSettings.LastAccessToken);
	    r_Logic.LoggedInUser = m_FBConnector.Connection.LoggedInUser;
	    this.Invoke(new Action(() => postLoginUIActions()));
	}

	private void postLoginUIActions()
	{
	    buttonLogin.Enabled = false;
	    ApplicationLogic.UserData = new FBUserData();
	    this.buttonLogout.Enabled = true;
	    this.buttonAlbums.Enabled = true;
	    this.buttonFriends.Enabled = true;
	    this.buttonCheckIns.Enabled = true;
	    this.buttonFriendStatics.Enabled = true;
	    this.buttonWhoLikesYouMost.Enabled = true;
	    this.buttonPost.Enabled = true;
	    this.checkBoxRememberMe.Enabled = true;
	    setNameAndProfilePic();
	    getLastPostByUser();
	}

	private void buttonAlbums_Click(object sender, EventArgs e)
	{
	    new Thread(() => fetchAlbums()).Start();
	}

	private void fetchAlbums()
	{
	    dataBindingSourceAlbums.DataSource = ApplicationLogic.UserData.Albums;
	    listBoxAlbums.Invoke(new Action(() => listBoxAlbums.DataSource = dataBindingSourceAlbums));
	    listBoxAlbums.Invoke(new Action(() => listBoxAlbums.DisplayMember = "Name"));

	    if (r_Logic.LoggedInUser.Albums.Count == 0)
	    {
		MessageBox.Show("No Albums available");
	    }
	}

	private void buttonFriends_Click(object sender, EventArgs e)
	{
	    new Thread(() => fetchFriends()).Start();
	}

	private void fetchFriends()
	{
	    dataBindingSourceFriends.DataSource = ApplicationLogic.UserData.Friends;
	    listBoxFriends.Invoke(new Action(() => listBoxFriends.DataSource = dataBindingSourceFriends));
	    listBoxFriends.Invoke(new Action(() => listBoxFriends.DisplayMember = "Name"));
	    buttonSortFriends.Invoke(new Action(() => buttonSortFriends.Enabled = true));
	}

	private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
	{
	    displaySelectedFriend();
	}

	private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
	{
	    displaySelectedAlbum();
	}

	private void displaySelectedAlbum()
	{
	    pictureBoxAlbumPhoto.Image = null;

	    if (listBoxAlbums.SelectedItems.Count == 1)
	    {
		Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
		displayAlbumPhotos(selectedAlbum);
		if (selectedAlbum.PictureThumbURL != null)
		{
		    pictureBoxAlbum.LoadAsync(selectedAlbum.PictureThumbURL);
		    labelAlbumPhotos.Text = string.Format("Photos from {0}", selectedAlbum.Name);
		}
		else
		{
		    pictureBoxAlbum.Image = pictureBoxAlbum.ErrorImage;
		    labelAlbumPhotos.Text = "Album photos";
		}
	    }
	}

	private void displayAlbumPhotos(Album i_SelectedAlbum)
	{
	    listBoxAlbumPhotos.Items.Clear();
	    listBoxAlbumPhotos.DisplayMember = "Id";

	    foreach (Photo photo in i_SelectedAlbum.Photos)
	    {
		listBoxAlbumPhotos.Items.Add(photo);
	    }
	}

	private void listBoxAlbumPhotos_SelectedIndexChanged(object sender, EventArgs e)
	{
	    if (listBoxAlbumPhotos.SelectedItems.Count == 1)
	    {
		displayAlbumPhoto(listBoxAlbumPhotos.SelectedItem as Photo);
	    }
	}

	private void displayAlbumPhoto(Photo i_PhotoToDisplay)
	{
	    if (i_PhotoToDisplay.PictureAlbumURL != null)
	    {
		pictureBoxAlbumPhoto.LoadAsync(i_PhotoToDisplay.PictureAlbumURL);
	    }
	    else
	    {
		pictureBoxAlbumPhoto.Image = pictureBoxAlbumPhoto.ErrorImage;
	    }
	}

	private void displaySelectedFriend()
	{
	    if (listBoxFriends.SelectedItems.Count == 1)
	    {
		User selectedFriend = listBoxFriends.SelectedItem as User;
		if (selectedFriend.PictureSqaureURL != null)
		{
		    pictureBoxFriend.LoadAsync(selectedFriend.PictureSqaureURL);
		}
		else
		{
		    pictureBoxFriend.Image = pictureBoxFriend.ErrorImage;
		}
	    }
	}

	private void buttonLogin_Click(object sender, EventArgs e)
	{
	    this.Invoke(new Action(() => newLogin()));
	}

	private void displayAlbumPhoto(Album i_SelecetedAlbum)
	{
	    listBoxAlbumPhotos.Items.Clear();
	    listBoxAlbumPhotos.DisplayMember = "Album Photo";

	    foreach (Photo photo in i_SelecetedAlbum.Photos)
	    {
		listBoxAlbumPhotos.Items.Add(photo.Name);
	    }

	    if (i_SelecetedAlbum.Photos.Count == 0)
	    {
		MessageBox.Show("No photos to show");
	    }
	}

	private void buttonPost_Click(object sender, EventArgs e)
	{
	    richTextBoxPostBox.Invoke(new Action(() => postMessage()));
	}

	private void postMessage()
	{
	    if (richTextBoxPostBox.TextLength > 0)
	    {
		try
		{
		    r_Logic.LoggedInUser.PostStatus(richTextBoxPostBox.Text);
		    MessageBox.Show("Status posted on wall!");
		    this.richTextBoxPostBox.Clear();
		}
		catch (Exception)
		{
		    MessageBox.Show("Error: Could not post!");
		}
	    }
	    else
	    {
		MessageBox.Show("Nothing to post");
	    }
	}

	private void buttonLogout_Click(object sender, EventArgs e)
	{
	    FaceBookConnector.LogOut();
	}

	private void preLoginButtonSettings(object sender, EventArgs e)
	{
	    this.checkBoxRememberMe.Enabled = false;
	    this.checkBoxRememberMe.Checked = false;
	    this.buttonLogout.Enabled = false;
	    this.buttonLogin.Enabled = true;
	    this.buttonAlbums.Enabled = false;
	    this.buttonFriends.Enabled = false;
	    this.buttonCheckIns.Enabled = false;
	    this.buttonFriendStatics.Enabled = false;
	    this.buttonWhoLikesYouMost.Enabled = false;
	    this.buttonPost.Enabled = false;
	    this.buttonSortFriends.Enabled = false;
	}

	private void clearControls(object sender, EventArgs e)
	{
	    this.labelName.Text = string.Empty;
	    this.pictureBoxProfilePicture.Image.Dispose();
	    this.pictureBoxProfilePicture.Image = null;
	    this.richTextBoxLastPost.Clear();

	    if (this.pictureBoxFriend.Image != null)
	    {
		this.pictureBoxFriend.Dispose();
		this.pictureBoxFriend.Image = null;
	    }

	    if (this.pictureBoxAlbum.Image != null)
	    {
		this.pictureBoxAlbum.Dispose();
		this.pictureBoxAlbum.Image = null;
	    }

	    listBoxCheckIns.Invoke(new Action(() => listBoxCheckIns.DataSource = null));
	    listBoxAlbums.Invoke(new Action(() => listBoxAlbums.DataSource = null));
	    listBoxFriends.Invoke(new Action(() => listBoxFriends.DataSource = null));
	    listBoxAlbumPhotos.Items.Clear();
	}

	private void buttonCheckIns_Click(object sender, EventArgs e)
	{
	    new Thread(() => fetchCheckins()).Start();
	}

	private void fetchCheckins()
	{
	    dataBindingSourceCheckins.DataSource = ApplicationLogic.UserData.Checkins;
	    listBoxCheckIns.Invoke(new Action(() => listBoxCheckIns.DataSource = dataBindingSourceCheckins));
	    listBoxCheckIns.Invoke(new Action(() => listBoxCheckIns.DisplayMember = "Place.Name"));
	}

	private void buttonWhoLikesYouMost_Click(object sender, EventArgs e)
	{
	    FormLikesYouMost likesYouMost = new FormLikesYouMost(r_Logic);
	    new Thread(() => likesYouMost.ShowDialog()).Start();
	}

	private void getFriendsStatistics_Click(object sender, EventArgs e)
	{
	    FormFriendsStatistics friendsStatics = new FormFriendsStatistics(r_Logic);
	    new Thread(() => friendsStatics.ShowDialog()).Start();
	}

	private void buttonSortFriends_Click(object sender, EventArgs e)
	{
	    orderFriendsListBox(sender, e);
	}

	private void orderFriendsListBox(object sender, EventArgs e)
	{
	    Button sortButton = sender as Button;
	    FriendsSorter sorter = new FriendsSorter();

	    if (sortButton.Text.Equals("Descending"))
	    {
		sorter.SortStrategy = new DescendingSorter();
		sortButton.Text = "Ascending";
	    }
	    else
	    {
		sorter.SortStrategy = new AscendingSorter();
		sortButton.Text = "Descending";
	    }

	    sorter.Sort();
	    listBoxFriends.Invoke(new Action(() => listBoxFriends.DataSource = null));
	    fetchFriends();
	}
    }
}