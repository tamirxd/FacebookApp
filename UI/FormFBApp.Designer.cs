using System;

namespace Ex03_UI
{
    public partial class FormFBApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
	    this.components = new System.ComponentModel.Container();
	    this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
	    this.listBoxFriends = new System.Windows.Forms.ListBox();
	    this.dataBindingSourceFriends = new System.Windows.Forms.BindingSource(this.components);
	    this.labelFriends = new System.Windows.Forms.Label();
	    this.buttonLogin = new System.Windows.Forms.Button();
	    this.buttonFriends = new System.Windows.Forms.Button();
	    this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
	    this.listBoxAlbums = new System.Windows.Forms.ListBox();
	    this.dataBindingSourceAlbums = new System.Windows.Forms.BindingSource(this.components);
	    this.buttonAlbums = new System.Windows.Forms.Button();
	    this.labelAlbums = new System.Windows.Forms.Label();
	    this.listBoxAlbumPhotos = new System.Windows.Forms.ListBox();
	    this.labelAlbumPhotos = new System.Windows.Forms.Label();
	    this.richTextBoxPostBox = new System.Windows.Forms.RichTextBox();
	    this.labelPost = new System.Windows.Forms.Label();
	    this.buttonPost = new System.Windows.Forms.Button();
	    this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
	    this.buttonLogout = new System.Windows.Forms.Button();
	    this.labelCheckIns = new System.Windows.Forms.Label();
	    this.buttonCheckIns = new System.Windows.Forms.Button();
	    this.listBoxCheckIns = new System.Windows.Forms.ListBox();
	    this.dataBindingSourceCheckins = new System.Windows.Forms.BindingSource(this.components);
	    this.labelName = new System.Windows.Forms.Label();
	    this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
	    this.pictureBoxAlbumPhoto = new System.Windows.Forms.PictureBox();
	    this.labelLastPost = new System.Windows.Forms.Label();
	    this.richTextBoxLastPost = new System.Windows.Forms.RichTextBox();
	    this.pictureBoxLatestPost = new System.Windows.Forms.PictureBox();
	    this.buttonWhoLikesYouMost = new System.Windows.Forms.Button();
	    this.buttonFriendStatics = new System.Windows.Forms.Button();
	    this.buttonSortFriends = new System.Windows.Forms.Button();
	    this.labelFriendsSortType = new System.Windows.Forms.Label();
	    ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
	    ((System.ComponentModel.ISupportInitialize)(this.dataBindingSourceFriends)).BeginInit();
	    ((System.ComponentModel.ISupportInitialize)(this.dataBindingSourceAlbums)).BeginInit();
	    ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
	    ((System.ComponentModel.ISupportInitialize)(this.dataBindingSourceCheckins)).BeginInit();
	    ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
	    ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumPhoto)).BeginInit();
	    ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLatestPost)).BeginInit();
	    this.SuspendLayout();
	    // 
	    // pictureBoxProfilePicture
	    // 
	    this.pictureBoxProfilePicture.Location = new System.Drawing.Point(15, 31);
	    this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
	    this.pictureBoxProfilePicture.Size = new System.Drawing.Size(95, 78);
	    this.pictureBoxProfilePicture.TabIndex = 0;
	    this.pictureBoxProfilePicture.TabStop = false;
	    // 
	    // listBoxFriends
	    // 
	    this.listBoxFriends.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
	    this.listBoxFriends.DataSource = this.dataBindingSourceFriends;
	    this.listBoxFriends.DisplayMember = "Friends";
	    this.listBoxFriends.FormattingEnabled = true;
	    this.listBoxFriends.Location = new System.Drawing.Point(12, 190);
	    this.listBoxFriends.Name = "listBoxFriends";
	    this.listBoxFriends.Size = new System.Drawing.Size(146, 199);
	    this.listBoxFriends.TabIndex = 1;
	    this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
	    // 
	    // dataBindingSourceFriends
	    // 
	    this.dataBindingSourceFriends.DataSource = typeof(Ex03_Logic.FBUserData);
	    // 
	    // labelFriends
	    // 
	    this.labelFriends.AutoSize = true;
	    this.labelFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
	    this.labelFriends.Location = new System.Drawing.Point(12, 165);
	    this.labelFriends.Name = "labelFriends";
	    this.labelFriends.Size = new System.Drawing.Size(53, 16);
	    this.labelFriends.TabIndex = 2;
	    this.labelFriends.Text = "Friends";
	    // 
	    // buttonLogin
	    // 
	    this.buttonLogin.BackColor = System.Drawing.SystemColors.ButtonShadow;
	    this.buttonLogin.Location = new System.Drawing.Point(12, 116);
	    this.buttonLogin.Name = "buttonLogin";
	    this.buttonLogin.Size = new System.Drawing.Size(75, 23);
	    this.buttonLogin.TabIndex = 3;
	    this.buttonLogin.Text = "Login";
	    this.buttonLogin.UseVisualStyleBackColor = false;
	    this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
	    // 
	    // buttonFriends
	    // 
	    this.buttonFriends.BackColor = System.Drawing.SystemColors.ButtonShadow;
	    this.buttonFriends.Location = new System.Drawing.Point(71, 162);
	    this.buttonFriends.Name = "buttonFriends";
	    this.buttonFriends.Size = new System.Drawing.Size(87, 23);
	    this.buttonFriends.TabIndex = 4;
	    this.buttonFriends.Text = "Get Friends";
	    this.buttonFriends.UseVisualStyleBackColor = false;
	    this.buttonFriends.Click += new System.EventHandler(this.buttonFriends_Click);
	    // 
	    // checkBoxRememberMe
	    // 
	    this.checkBoxRememberMe.AutoSize = true;
	    this.checkBoxRememberMe.Location = new System.Drawing.Point(93, 122);
	    this.checkBoxRememberMe.Name = "checkBoxRememberMe";
	    this.checkBoxRememberMe.Size = new System.Drawing.Size(95, 17);
	    this.checkBoxRememberMe.TabIndex = 5;
	    this.checkBoxRememberMe.Text = "Remember Me";
	    this.checkBoxRememberMe.UseVisualStyleBackColor = true;
	    // 
	    // listBoxAlbums
	    // 
	    this.listBoxAlbums.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
	    this.listBoxAlbums.DataSource = this.dataBindingSourceAlbums;
	    this.listBoxAlbums.DisplayMember = "Albums";
	    this.listBoxAlbums.FormattingEnabled = true;
	    this.listBoxAlbums.Location = new System.Drawing.Point(244, 190);
	    this.listBoxAlbums.Name = "listBoxAlbums";
	    this.listBoxAlbums.Size = new System.Drawing.Size(133, 199);
	    this.listBoxAlbums.TabIndex = 6;
	    this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
	    // 
	    // dataBindingSourceAlbums
	    // 
	    this.dataBindingSourceAlbums.DataSource = typeof(Ex03_Logic.FBUserData);
	    // 
	    // buttonAlbums
	    // 
	    this.buttonAlbums.BackColor = System.Drawing.SystemColors.ButtonShadow;
	    this.buttonAlbums.Location = new System.Drawing.Point(298, 161);
	    this.buttonAlbums.Name = "buttonAlbums";
	    this.buttonAlbums.Size = new System.Drawing.Size(79, 23);
	    this.buttonAlbums.TabIndex = 7;
	    this.buttonAlbums.Text = "Get Albums";
	    this.buttonAlbums.UseVisualStyleBackColor = false;
	    this.buttonAlbums.Click += new System.EventHandler(this.buttonAlbums_Click);
	    // 
	    // labelAlbums
	    // 
	    this.labelAlbums.AutoSize = true;
	    this.labelAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
	    this.labelAlbums.Location = new System.Drawing.Point(241, 164);
	    this.labelAlbums.Name = "labelAlbums";
	    this.labelAlbums.Size = new System.Drawing.Size(53, 16);
	    this.labelAlbums.TabIndex = 8;
	    this.labelAlbums.Text = "Albums";
	    // 
	    // listBoxAlbumPhotos
	    // 
	    this.listBoxAlbumPhotos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
	    this.listBoxAlbumPhotos.FormattingEnabled = true;
	    this.listBoxAlbumPhotos.Location = new System.Drawing.Point(450, 187);
	    this.listBoxAlbumPhotos.Name = "listBoxAlbumPhotos";
	    this.listBoxAlbumPhotos.Size = new System.Drawing.Size(174, 199);
	    this.listBoxAlbumPhotos.TabIndex = 9;
	    this.listBoxAlbumPhotos.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbumPhotos_SelectedIndexChanged);
	    // 
	    // labelAlbumPhotos
	    // 
	    this.labelAlbumPhotos.AutoSize = true;
	    this.labelAlbumPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
	    this.labelAlbumPhotos.Location = new System.Drawing.Point(447, 161);
	    this.labelAlbumPhotos.Name = "labelAlbumPhotos";
	    this.labelAlbumPhotos.Size = new System.Drawing.Size(91, 16);
	    this.labelAlbumPhotos.TabIndex = 10;
	    this.labelAlbumPhotos.Text = "Album Photos";
	    // 
	    // richTextBoxPostBox
	    // 
	    this.richTextBoxPostBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
	    this.richTextBoxPostBox.Location = new System.Drawing.Point(335, 28);
	    this.richTextBoxPostBox.Name = "richTextBoxPostBox";
	    this.richTextBoxPostBox.Size = new System.Drawing.Size(256, 76);
	    this.richTextBoxPostBox.TabIndex = 12;
	    this.richTextBoxPostBox.Text = string.Empty;
	    // 
	    // labelPost
	    // 
	    this.labelPost.AutoSize = true;
	    this.labelPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
	    this.labelPost.Location = new System.Drawing.Point(332, 6);
	    this.labelPost.Name = "labelPost";
	    this.labelPost.Size = new System.Drawing.Size(112, 16);
	    this.labelPost.TabIndex = 13;
	    this.labelPost.Text = "Share something:";
	    // 
	    // buttonPost
	    // 
	    this.buttonPost.BackColor = System.Drawing.SystemColors.ButtonShadow;
	    this.buttonPost.Location = new System.Drawing.Point(383, 110);
	    this.buttonPost.Name = "buttonPost";
	    this.buttonPost.Size = new System.Drawing.Size(146, 23);
	    this.buttonPost.TabIndex = 14;
	    this.buttonPost.Text = "Post On Facebook";
	    this.buttonPost.UseVisualStyleBackColor = false;
	    this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
	    // 
	    // pictureBoxFriend
	    // 
	    this.pictureBoxFriend.Location = new System.Drawing.Point(164, 190);
	    this.pictureBoxFriend.Name = "pictureBoxFriend";
	    this.pictureBoxFriend.Size = new System.Drawing.Size(61, 53);
	    this.pictureBoxFriend.TabIndex = 15;
	    this.pictureBoxFriend.TabStop = false;
	    // 
	    // buttonLogout
	    // 
	    this.buttonLogout.BackColor = System.Drawing.SystemColors.ButtonShadow;
	    this.buttonLogout.Location = new System.Drawing.Point(881, 9);
	    this.buttonLogout.Name = "buttonLogout";
	    this.buttonLogout.Size = new System.Drawing.Size(75, 23);
	    this.buttonLogout.TabIndex = 17;
	    this.buttonLogout.Text = "Logout";
	    this.buttonLogout.UseVisualStyleBackColor = false;
	    this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
	    this.buttonLogout.Click += new System.EventHandler(this.clearControls);
	    this.buttonLogout.Click += new System.EventHandler(this.preLoginButtonSettings);
	    // 
	    // labelCheckIns
	    // 
	    this.labelCheckIns.AutoSize = true;
	    this.labelCheckIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
	    this.labelCheckIns.Location = new System.Drawing.Point(796, 164);
	    this.labelCheckIns.Name = "labelCheckIns";
	    this.labelCheckIns.Size = new System.Drawing.Size(67, 16);
	    this.labelCheckIns.TabIndex = 18;
	    this.labelCheckIns.Text = "Check-Ins";
	    // 
	    // buttonCheckIns
	    // 
	    this.buttonCheckIns.BackColor = System.Drawing.SystemColors.ButtonShadow;
	    this.buttonCheckIns.Location = new System.Drawing.Point(869, 162);
	    this.buttonCheckIns.Name = "buttonCheckIns";
	    this.buttonCheckIns.Size = new System.Drawing.Size(87, 23);
	    this.buttonCheckIns.TabIndex = 19;
	    this.buttonCheckIns.Text = "Get Check-Ins";
	    this.buttonCheckIns.UseVisualStyleBackColor = false;
	    this.buttonCheckIns.Click += new System.EventHandler(this.buttonCheckIns_Click);
	    // 
	    // listBoxCheckIns
	    // 
	    this.listBoxCheckIns.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
	    this.listBoxCheckIns.DataSource = this.dataBindingSourceCheckins;
	    this.listBoxCheckIns.DisplayMember = "Checkins";
	    this.listBoxCheckIns.FormattingEnabled = true;
	    this.listBoxCheckIns.Location = new System.Drawing.Point(799, 187);
	    this.listBoxCheckIns.Name = "listBoxCheckIns";
	    this.listBoxCheckIns.Size = new System.Drawing.Size(157, 199);
	    this.listBoxCheckIns.TabIndex = 20;
	    // 
	    // dataBindingSourceCheckins
	    // 
	    this.dataBindingSourceCheckins.DataSource = typeof(Ex03_Logic.FBUserData);
	    // 
	    // labelName
	    // 
	    this.labelName.AutoSize = true;
	    this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
	    this.labelName.Location = new System.Drawing.Point(12, 9);
	    this.labelName.Name = "labelName";
	    this.labelName.Size = new System.Drawing.Size(45, 16);
	    this.labelName.TabIndex = 21;
	    this.labelName.Text = "Name";
	    // 
	    // pictureBoxAlbum
	    // 
	    this.pictureBoxAlbum.Location = new System.Drawing.Point(383, 190);
	    this.pictureBoxAlbum.Name = "pictureBoxAlbum";
	    this.pictureBoxAlbum.Size = new System.Drawing.Size(61, 53);
	    this.pictureBoxAlbum.TabIndex = 22;
	    this.pictureBoxAlbum.TabStop = false;
	    // 
	    // pictureBoxAlbumPhoto
	    // 
	    this.pictureBoxAlbumPhoto.Location = new System.Drawing.Point(630, 187);
	    this.pictureBoxAlbumPhoto.Name = "pictureBoxAlbumPhoto";
	    this.pictureBoxAlbumPhoto.Size = new System.Drawing.Size(163, 199);
	    this.pictureBoxAlbumPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
	    this.pictureBoxAlbumPhoto.TabIndex = 23;
	    this.pictureBoxAlbumPhoto.TabStop = false;
	    // 
	    // labelLastPost
	    // 
	    this.labelLastPost.AutoSize = true;
	    this.labelLastPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
	    this.labelLastPost.Location = new System.Drawing.Point(627, 6);
	    this.labelLastPost.Name = "labelLastPost";
	    this.labelLastPost.Size = new System.Drawing.Size(137, 16);
	    this.labelLastPost.TabIndex = 24;
	    this.labelLastPost.Text = "Last thing you posted:";
	    // 
	    // richTextBoxLastPost
	    // 
	    this.richTextBoxLastPost.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
	    this.richTextBoxLastPost.Location = new System.Drawing.Point(630, 25);
	    this.richTextBoxLastPost.Name = "richTextBoxLastPost";
	    this.richTextBoxLastPost.Size = new System.Drawing.Size(218, 79);
	    this.richTextBoxLastPost.TabIndex = 25;
	    this.richTextBoxLastPost.Text = string.Empty;
	    // 
	    // pictureBoxLatestPost
	    // 
	    this.pictureBoxLatestPost.Location = new System.Drawing.Point(680, 25);
	    this.pictureBoxLatestPost.Name = "pictureBoxLatestPost";
	    this.pictureBoxLatestPost.Size = new System.Drawing.Size(123, 108);
	    this.pictureBoxLatestPost.TabIndex = 26;
	    this.pictureBoxLatestPost.TabStop = false;
	    // 
	    // buttonWhoLikesYouMost
	    // 
	    this.buttonWhoLikesYouMost.BackColor = System.Drawing.SystemColors.ButtonShadow;
	    this.buttonWhoLikesYouMost.Location = new System.Drawing.Point(130, 31);
	    this.buttonWhoLikesYouMost.Name = "buttonWhoLikesYouMost";
	    this.buttonWhoLikesYouMost.Size = new System.Drawing.Size(178, 23);
	    this.buttonWhoLikesYouMost.TabIndex = 27;
	    this.buttonWhoLikesYouMost.Text = "Check who likes you most";
	    this.buttonWhoLikesYouMost.UseVisualStyleBackColor = false;
	    this.buttonWhoLikesYouMost.Click += new System.EventHandler(this.buttonWhoLikesYouMost_Click);
	    // 
	    // buttonFriendStatics
	    // 
	    this.buttonFriendStatics.BackColor = System.Drawing.SystemColors.ButtonShadow;
	    this.buttonFriendStatics.Location = new System.Drawing.Point(130, 61);
	    this.buttonFriendStatics.Name = "buttonFriendStatics";
	    this.buttonFriendStatics.Size = new System.Drawing.Size(178, 23);
	    this.buttonFriendStatics.TabIndex = 28;
	    this.buttonFriendStatics.Text = "Check your friends statistics";
	    this.buttonFriendStatics.UseVisualStyleBackColor = false;
	    this.buttonFriendStatics.Click += new System.EventHandler(this.getFriendsStatistics_Click);
	    // 
	    // buttonSortFriends
	    // 
	    this.buttonSortFriends.BackColor = System.Drawing.SystemColors.ButtonShadow;
	    this.buttonSortFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
	    this.buttonSortFriends.Location = new System.Drawing.Point(164, 366);
	    this.buttonSortFriends.Name = "buttonSortFriends";
	    this.buttonSortFriends.Size = new System.Drawing.Size(74, 23);
	    this.buttonSortFriends.TabIndex = 29;
	    this.buttonSortFriends.Text = "Ascending";
	    this.buttonSortFriends.UseVisualStyleBackColor = false;
	    this.buttonSortFriends.Click += new System.EventHandler(this.buttonSortFriends_Click);
	    // 
	    // labelFriendsSortType
	    // 
	    this.labelFriendsSortType.AutoSize = true;
	    this.labelFriendsSortType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
	    this.labelFriendsSortType.Location = new System.Drawing.Point(164, 350);
	    this.labelFriendsSortType.Name = "labelFriendsSortType";
	    this.labelFriendsSortType.Size = new System.Drawing.Size(66, 13);
	    this.labelFriendsSortType.TabIndex = 31;
	    this.labelFriendsSortType.Text = "Friends Sort:";
	    // 
	    // FormFBApp
	    // 
	    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	    this.BackColor = System.Drawing.SystemColors.ActiveCaption;
	    this.ClientSize = new System.Drawing.Size(968, 407);
	    this.Controls.Add(this.labelFriendsSortType);
	    this.Controls.Add(this.buttonSortFriends);
	    this.Controls.Add(this.buttonFriendStatics);
	    this.Controls.Add(this.buttonWhoLikesYouMost);
	    this.Controls.Add(this.pictureBoxLatestPost);
	    this.Controls.Add(this.richTextBoxLastPost);
	    this.Controls.Add(this.labelLastPost);
	    this.Controls.Add(this.pictureBoxAlbumPhoto);
	    this.Controls.Add(this.pictureBoxAlbum);
	    this.Controls.Add(this.labelName);
	    this.Controls.Add(this.listBoxCheckIns);
	    this.Controls.Add(this.buttonCheckIns);
	    this.Controls.Add(this.labelCheckIns);
	    this.Controls.Add(this.buttonLogout);
	    this.Controls.Add(this.pictureBoxFriend);
	    this.Controls.Add(this.buttonPost);
	    this.Controls.Add(this.labelPost);
	    this.Controls.Add(this.richTextBoxPostBox);
	    this.Controls.Add(this.labelAlbumPhotos);
	    this.Controls.Add(this.listBoxAlbumPhotos);
	    this.Controls.Add(this.labelAlbums);
	    this.Controls.Add(this.buttonAlbums);
	    this.Controls.Add(this.listBoxAlbums);
	    this.Controls.Add(this.checkBoxRememberMe);
	    this.Controls.Add(this.buttonFriends);
	    this.Controls.Add(this.buttonLogin);
	    this.Controls.Add(this.labelFriends);
	    this.Controls.Add(this.listBoxFriends);
	    this.Controls.Add(this.pictureBoxProfilePicture);
	    this.Name = "FormFBApp";
	    this.Text = "Facebook App";
	    ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
	    ((System.ComponentModel.ISupportInitialize)(this.dataBindingSourceFriends)).EndInit();
	    ((System.ComponentModel.ISupportInitialize)(this.dataBindingSourceAlbums)).EndInit();
	    ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
	    ((System.ComponentModel.ISupportInitialize)(this.dataBindingSourceCheckins)).EndInit();
	    ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
	    ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumPhoto)).EndInit();
	    ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLatestPost)).EndInit();
	    this.ResumeLayout(false);
	    this.PerformLayout();

        }

	private void ButtonSortFriendsAscending_Click(object sender, EventArgs e)
	{
	    throw new NotImplementedException();
	}

	#endregion

	private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
	private System.Windows.Forms.ListBox listBoxFriends;
	private System.Windows.Forms.Label labelFriends;
	private System.Windows.Forms.Button buttonLogin;
	private System.Windows.Forms.Button buttonFriends;
	private System.Windows.Forms.CheckBox checkBoxRememberMe;
	private System.Windows.Forms.ListBox listBoxAlbums;
	private System.Windows.Forms.Button buttonAlbums;
	private System.Windows.Forms.Label labelAlbums;
	private System.Windows.Forms.ListBox listBoxAlbumPhotos;
	private System.Windows.Forms.Label labelAlbumPhotos;
	private System.Windows.Forms.RichTextBox richTextBoxPostBox;
	private System.Windows.Forms.Label labelPost;
	private System.Windows.Forms.Button buttonPost;
	private System.Windows.Forms.PictureBox pictureBoxFriend;
	private System.Windows.Forms.Button buttonLogout;
	private System.Windows.Forms.Label labelCheckIns;
	private System.Windows.Forms.Button buttonCheckIns;
	private System.Windows.Forms.ListBox listBoxCheckIns;
	private System.Windows.Forms.Label labelName;
	private System.Windows.Forms.PictureBox pictureBoxAlbum;
	private System.Windows.Forms.PictureBox pictureBoxAlbumPhoto;
	private System.Windows.Forms.Label labelLastPost;
	private System.Windows.Forms.RichTextBox richTextBoxLastPost;
	private System.Windows.Forms.PictureBox pictureBoxLatestPost;
        private System.Windows.Forms.Button buttonWhoLikesYouMost;
        private System.Windows.Forms.Button buttonFriendStatics;
	private System.Windows.Forms.BindingSource dataBindingSourceFriends;
	private System.Windows.Forms.BindingSource dataBindingSourceAlbums;
	private System.Windows.Forms.BindingSource dataBindingSourceCheckins;
	private System.Windows.Forms.Button buttonSortFriends;
	private System.Windows.Forms.Label labelFriendsSortType;
    }
}