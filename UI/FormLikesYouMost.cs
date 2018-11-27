using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Ex03_Logic;

namespace Ex03_UI
{
    public partial class FormLikesYouMost : Form
    {
        public ApplicationLogic Logic { get; set; }

        public FormLikesYouMost(ApplicationLogic i_Logic)
        {
            Logic = i_Logic;
            InitializeComponent();
            setFindButtonEnabled();
            buttonShare.Enabled = false;
        }

        private void findWhoLikesYouMost(object sender, EventArgs e)
        {
            KeyValuePair<string, List<int>> whoLikesMost;
            User likesYouMostFriend;

            if (Logic.LikesYouMostFriend == null)
            {
                Logic.LikesYouMostFriend = new WhoLikesYouMost();
            }

            List<bool> filter = new List<bool>() { checkBoxLikes.Checked, checkBoxComments.Checked, checkBoxTags.Checked };
            List<bool> Search = new List<bool>() { checkBoxAlbums.Checked, checkBoxVideos.Checked, checkPosts.Checked };

            whoLikesMost = Logic.LikesYouMostFriend.FindWhoLikesYouMost(filter, Search);
            likesYouMostFriend = getFriendById(whoLikesMost.Key);

            if (whoLikesMost.Key != null)
            {
                labelName.Text = likesYouMostFriend.Name;
                pictureBoxFriendPicture.Load(likesYouMostFriend.PictureNormalURL);

                int likes = whoLikesMost.Value[(int)LikesYouMost.eFilter.Likes];
                int comments = whoLikesMost.Value[(int)LikesYouMost.eFilter.Comments];
                int tags = whoLikesMost.Value[(int)LikesYouMost.eFilter.Tags];
                buttonShare.Enabled = true;
            }
            else
            {
                MessageBox.Show("Sorry, Friends details are not avalible");
                buttonShare.Enabled = false;
            }
        }

        private User getFriendById(string i_FriendsId)
        {
            foreach (User user in Logic.LoggedInUser.Friends)
            {
                if (user.Id == i_FriendsId)
                {
                    return user;
                }
            }

            return null;
        }

        private void setFindButtonEnabled()
        {
            if ((checkBoxAlbums.Checked || checkBoxVideos.Checked || checkPosts.Checked) && (checkBoxLikes.Checked || checkBoxTags.Checked || checkBoxComments.Checked))
            {
                buttonFind.Enabled = true;
            }
            else
            {
                buttonFind.Enabled = false;
            }
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            try
            {
                Logic.LoggedInUser.PostStatus(string.Format("I just discovered that {0} is the most activity friend", labelName.Text));
                MessageBox.Show("Shared successfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Could'nt Shared");
            }
        }

        private void checkAlbums_CheckedChanged(object sender, EventArgs e)
        {
            setFindButtonEnabled();
        }

        private void checkVideos_CheckedChanged(object sender, EventArgs e)
        {
            setFindButtonEnabled();
        }

        private void checkPosts_CheckedChanged(object sender, EventArgs e)
        {
            setFindButtonEnabled();
        }

        private void checkLikes_CheckedChanged(object sender, EventArgs e)
        {
            setFindButtonEnabled();
        }

        private void checkTags_CheckedChanged(object sender, EventArgs e)
        {
            setFindButtonEnabled();
        }

        private void checkComments_CheckedChanged(object sender, EventArgs e)
        {
            setFindButtonEnabled();
        }
    }
}
