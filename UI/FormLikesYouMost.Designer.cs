namespace Ex03_UI
{
    public partial class FormLikesYouMost
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
	    this.buttonFind = new System.Windows.Forms.Button();
	    this.buttonShare = new System.Windows.Forms.Button();
	    this.labelFIlterBy = new System.Windows.Forms.Label();
	    this.labelSearchIn = new System.Windows.Forms.Label();
	    this.checkBoxAlbums = new System.Windows.Forms.CheckBox();
	    this.checkBoxVideos = new System.Windows.Forms.CheckBox();
	    this.checkPosts = new System.Windows.Forms.CheckBox();
	    this.checkBoxLikes = new System.Windows.Forms.CheckBox();
	    this.checkBoxTags = new System.Windows.Forms.CheckBox();
	    this.checkBoxComments = new System.Windows.Forms.CheckBox();
	    this.pictureBoxFriendPicture = new System.Windows.Forms.PictureBox();
	    this.labelName = new System.Windows.Forms.Label();
	    ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPicture)).BeginInit();
	    this.SuspendLayout();
	    // 
	    // buttonFind
	    // 
	    this.buttonFind.BackColor = System.Drawing.SystemColors.ControlDark;
	    this.buttonFind.Location = new System.Drawing.Point(14, 12);
	    this.buttonFind.Name = "buttonFind";
	    this.buttonFind.Size = new System.Drawing.Size(75, 23);
	    this.buttonFind.TabIndex = 0;
	    this.buttonFind.Text = "Find";
	    this.buttonFind.UseVisualStyleBackColor = false;
	    this.buttonFind.Click += new System.EventHandler(this.findWhoLikesYouMost);
	    // 
	    // buttonShare
	    // 
	    this.buttonShare.BackColor = System.Drawing.SystemColors.ControlDark;
	    this.buttonShare.Location = new System.Drawing.Point(14, 41);
	    this.buttonShare.Name = "buttonShare";
	    this.buttonShare.Size = new System.Drawing.Size(75, 23);
	    this.buttonShare.TabIndex = 1;
	    this.buttonShare.Text = "Share";
	    this.buttonShare.UseVisualStyleBackColor = false;
	    this.buttonShare.Click += new System.EventHandler(this.btnShare_Click);
	    // 
	    // labelFIlterBy
	    // 
	    this.labelFIlterBy.AutoSize = true;
	    this.labelFIlterBy.Location = new System.Drawing.Point(11, 81);
	    this.labelFIlterBy.Name = "labelFIlterBy";
	    this.labelFIlterBy.Size = new System.Drawing.Size(44, 13);
	    this.labelFIlterBy.TabIndex = 2;
	    this.labelFIlterBy.Text = "Filter By";
	    // 
	    // labelSearchIn
	    // 
	    this.labelSearchIn.AutoSize = true;
	    this.labelSearchIn.Location = new System.Drawing.Point(11, 176);
	    this.labelSearchIn.Name = "labelSearchIn";
	    this.labelSearchIn.Size = new System.Drawing.Size(53, 13);
	    this.labelSearchIn.TabIndex = 3;
	    this.labelSearchIn.Text = "Search In";
	    // 
	    // checkBoxAlbums
	    // 
	    this.checkBoxAlbums.AccessibleName = "checkAlbum";
	    this.checkBoxAlbums.AutoSize = true;
	    this.checkBoxAlbums.Location = new System.Drawing.Point(14, 97);
	    this.checkBoxAlbums.Name = "checkBoxAlbums";
	    this.checkBoxAlbums.Size = new System.Drawing.Size(60, 17);
	    this.checkBoxAlbums.TabIndex = 4;
	    this.checkBoxAlbums.Text = "Albums";
	    this.checkBoxAlbums.UseVisualStyleBackColor = true;
	    this.checkBoxAlbums.CheckedChanged += new System.EventHandler(this.checkAlbums_CheckedChanged);
	    // 
	    // checkBoxVideos
	    // 
	    this.checkBoxVideos.AutoSize = true;
	    this.checkBoxVideos.Location = new System.Drawing.Point(14, 120);
	    this.checkBoxVideos.Name = "checkBoxVideos";
	    this.checkBoxVideos.Size = new System.Drawing.Size(58, 17);
	    this.checkBoxVideos.TabIndex = 5;
	    this.checkBoxVideos.Text = "Videos";
	    this.checkBoxVideos.UseVisualStyleBackColor = true;
	    this.checkBoxVideos.CheckedChanged += new System.EventHandler(this.checkVideos_CheckedChanged);
	    // 
	    // checkPosts
	    // 
	    this.checkPosts.AutoSize = true;
	    this.checkPosts.Location = new System.Drawing.Point(14, 143);
	    this.checkPosts.Name = "checkPosts";
	    this.checkPosts.Size = new System.Drawing.Size(52, 17);
	    this.checkPosts.TabIndex = 6;
	    this.checkPosts.Text = "Posts";
	    this.checkPosts.UseVisualStyleBackColor = true;
	    this.checkPosts.CheckedChanged += new System.EventHandler(this.checkPosts_CheckedChanged);
	    // 
	    // checkBoxLikes
	    // 
	    this.checkBoxLikes.AutoSize = true;
	    this.checkBoxLikes.Location = new System.Drawing.Point(14, 192);
	    this.checkBoxLikes.Name = "checkBoxLikes";
	    this.checkBoxLikes.Size = new System.Drawing.Size(51, 17);
	    this.checkBoxLikes.TabIndex = 7;
	    this.checkBoxLikes.Text = "Likes";
	    this.checkBoxLikes.UseVisualStyleBackColor = true;
	    this.checkBoxLikes.CheckedChanged += new System.EventHandler(this.checkLikes_CheckedChanged);
	    // 
	    // checkBoxTags
	    // 
	    this.checkBoxTags.AutoSize = true;
	    this.checkBoxTags.Location = new System.Drawing.Point(14, 215);
	    this.checkBoxTags.Name = "checkBoxTags";
	    this.checkBoxTags.Size = new System.Drawing.Size(50, 17);
	    this.checkBoxTags.TabIndex = 8;
	    this.checkBoxTags.Text = "Tags";
	    this.checkBoxTags.UseVisualStyleBackColor = true;
	    this.checkBoxTags.CheckedChanged += new System.EventHandler(this.checkTags_CheckedChanged);
	    // 
	    // checkBoxComments
	    // 
	    this.checkBoxComments.AutoSize = true;
	    this.checkBoxComments.Location = new System.Drawing.Point(14, 238);
	    this.checkBoxComments.Name = "checkBoxComments";
	    this.checkBoxComments.Size = new System.Drawing.Size(75, 17);
	    this.checkBoxComments.TabIndex = 9;
	    this.checkBoxComments.Text = "Comments";
	    this.checkBoxComments.UseVisualStyleBackColor = true;
	    this.checkBoxComments.CheckedChanged += new System.EventHandler(this.checkComments_CheckedChanged);
	    // 
	    // pictureBoxFriendPicture
	    // 
	    this.pictureBoxFriendPicture.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
	    this.pictureBoxFriendPicture.Location = new System.Drawing.Point(115, 12);
	    this.pictureBoxFriendPicture.Name = "pictureBoxFriendPicture";
	    this.pictureBoxFriendPicture.Size = new System.Drawing.Size(151, 125);
	    this.pictureBoxFriendPicture.TabIndex = 10;
	    this.pictureBoxFriendPicture.TabStop = false;
	    // 
	    // labelName
	    // 
	    this.labelName.AutoSize = true;
	    this.labelName.Location = new System.Drawing.Point(112, 147);
	    this.labelName.Name = "labelName";
	    this.labelName.Size = new System.Drawing.Size(35, 13);
	    this.labelName.TabIndex = 11;
	    this.labelName.Text = "Name";
	    // 
	    // FormLikesYouMost
	    // 
	    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	    this.AutoScroll = true;
	    this.BackColor = System.Drawing.SystemColors.ActiveCaption;
	    this.ClientSize = new System.Drawing.Size(278, 261);
	    this.Controls.Add(this.labelName);
	    this.Controls.Add(this.pictureBoxFriendPicture);
	    this.Controls.Add(this.checkBoxComments);
	    this.Controls.Add(this.checkBoxTags);
	    this.Controls.Add(this.checkBoxLikes);
	    this.Controls.Add(this.checkPosts);
	    this.Controls.Add(this.checkBoxVideos);
	    this.Controls.Add(this.checkBoxAlbums);
	    this.Controls.Add(this.labelSearchIn);
	    this.Controls.Add(this.labelFIlterBy);
	    this.Controls.Add(this.buttonShare);
	    this.Controls.Add(this.buttonFind);
	    this.Name = "FormLikesYouMost";
	    this.Text = "Who Liks You Most";
	    ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPicture)).EndInit();
	    this.ResumeLayout(false);
	    this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonShare;
        private System.Windows.Forms.Label labelFIlterBy;
        private System.Windows.Forms.Label labelSearchIn;
        private System.Windows.Forms.CheckBox checkBoxAlbums;
        private System.Windows.Forms.CheckBox checkBoxVideos;
        private System.Windows.Forms.CheckBox checkPosts;
        private System.Windows.Forms.CheckBox checkBoxLikes;
        private System.Windows.Forms.CheckBox checkBoxTags;
        private System.Windows.Forms.CheckBox checkBoxComments;
        private System.Windows.Forms.PictureBox pictureBoxFriendPicture;
        private System.Windows.Forms.Label labelName;
    }
}