namespace Ex03_UI
{
    public partial class FormFriendsStatistics
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
	    this.panelFriendsNumber = new System.Windows.Forms.Panel();
	    this.labelFriendsNumberCount = new System.Windows.Forms.Label();
	    this.labelFriendsNumber = new System.Windows.Forms.Label();
	    this.ListViewBirthdayFriends = new System.Windows.Forms.ListView();
	    this.FriendsBirthName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
	    this.Birthdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
	    this.panelPercentage = new System.Windows.Forms.Panel();
	    this.labelMaleFemaleCount = new System.Windows.Forms.Label();
	    this.labelMaleFemalePercentage = new System.Windows.Forms.Label();
	    this.panelSinglePercentage = new System.Windows.Forms.Panel();
	    this.labelSingleCount = new System.Windows.Forms.Label();
	    this.labelSinglePercentage = new System.Windows.Forms.Label();
	    this.labelUpcomingBirthdays = new System.Windows.Forms.Label();
	    this.labelTopLikers = new System.Windows.Forms.Label();
	    this.ListViewTopLikers = new System.Windows.Forms.ListView();
	    this.CollumName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
	    this.Likes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
	    this.panelFriendsNumber.SuspendLayout();
	    this.panelPercentage.SuspendLayout();
	    this.panelSinglePercentage.SuspendLayout();
	    this.SuspendLayout();
	    // 
	    // panelFriendsNumber
	    // 
	    this.panelFriendsNumber.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
	    this.panelFriendsNumber.Controls.Add(this.labelFriendsNumberCount);
	    this.panelFriendsNumber.Controls.Add(this.labelFriendsNumber);
	    this.panelFriendsNumber.Location = new System.Drawing.Point(14, 16);
	    this.panelFriendsNumber.Name = "panelFriendsNumber";
	    this.panelFriendsNumber.Size = new System.Drawing.Size(356, 45);
	    this.panelFriendsNumber.TabIndex = 0;
	    // 
	    // labelFriendsNumberCount
	    // 
	    this.labelFriendsNumberCount.AutoSize = true;
	    this.labelFriendsNumberCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
	    this.labelFriendsNumberCount.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
	    this.labelFriendsNumberCount.Location = new System.Drawing.Point(188, 10);
	    this.labelFriendsNumberCount.Name = "labelFriendsNumberCount";
	    this.labelFriendsNumberCount.Size = new System.Drawing.Size(0, 24);
	    this.labelFriendsNumberCount.TabIndex = 1;
	    // 
	    // labelFriendsNumber
	    // 
	    this.labelFriendsNumber.AutoSize = true;
	    this.labelFriendsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
	    this.labelFriendsNumber.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
	    this.labelFriendsNumber.Location = new System.Drawing.Point(11, 10);
	    this.labelFriendsNumber.Name = "labelFriendsNumber";
	    this.labelFriendsNumber.Size = new System.Drawing.Size(171, 25);
	    this.labelFriendsNumber.TabIndex = 0;
	    this.labelFriendsNumber.Text = "Friends Number:";
	    // 
	    // ListViewBirthdayFriends
	    // 
	    this.ListViewBirthdayFriends.AllowColumnReorder = true;
	    this.ListViewBirthdayFriends.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
	    this.ListViewBirthdayFriends.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FriendsBirthName,
            this.Birthdate});
	    this.ListViewBirthdayFriends.Location = new System.Drawing.Point(188, 186);
	    this.ListViewBirthdayFriends.Margin = new System.Windows.Forms.Padding(2);
	    this.ListViewBirthdayFriends.Name = "ListViewBirthdayFriends";
	    this.ListViewBirthdayFriends.Size = new System.Drawing.Size(182, 221);
	    this.ListViewBirthdayFriends.TabIndex = 4;
	    this.ListViewBirthdayFriends.UseCompatibleStateImageBehavior = false;
	    this.ListViewBirthdayFriends.View = System.Windows.Forms.View.Details;
	    // 
	    // FriendsBirthName
	    // 
	    this.FriendsBirthName.Text = "Name";
	    this.FriendsBirthName.Width = 105;
	    // 
	    // Birthdate
	    // 
	    this.Birthdate.Text = "Birth date";
	    this.Birthdate.Width = 132;
	    // 
	    // panelPercentage
	    // 
	    this.panelPercentage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
	    this.panelPercentage.Controls.Add(this.labelMaleFemaleCount);
	    this.panelPercentage.Controls.Add(this.labelMaleFemalePercentage);
	    this.panelPercentage.Location = new System.Drawing.Point(14, 67);
	    this.panelPercentage.Name = "panelPercentage";
	    this.panelPercentage.Size = new System.Drawing.Size(356, 45);
	    this.panelPercentage.TabIndex = 0;
	    // 
	    // labelMaleFemaleCount
	    // 
	    this.labelMaleFemaleCount.AutoSize = true;
	    this.labelMaleFemaleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
	    this.labelMaleFemaleCount.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
	    this.labelMaleFemaleCount.Location = new System.Drawing.Point(275, 11);
	    this.labelMaleFemaleCount.Name = "labelMaleFemaleCount";
	    this.labelMaleFemaleCount.Size = new System.Drawing.Size(0, 24);
	    this.labelMaleFemaleCount.TabIndex = 1;
	    // 
	    // labelMaleFemalePercentage
	    // 
	    this.labelMaleFemalePercentage.AutoSize = true;
	    this.labelMaleFemalePercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
	    this.labelMaleFemalePercentage.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
	    this.labelMaleFemalePercentage.Location = new System.Drawing.Point(11, 10);
	    this.labelMaleFemalePercentage.Name = "labelMaleFemalePercentage";
	    this.labelMaleFemalePercentage.Size = new System.Drawing.Size(258, 25);
	    this.labelMaleFemalePercentage.TabIndex = 0;
	    this.labelMaleFemalePercentage.Text = "Male/Female Percentage:";
	    // 
	    // panelSinglePercentage
	    // 
	    this.panelSinglePercentage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
	    this.panelSinglePercentage.Controls.Add(this.labelSingleCount);
	    this.panelSinglePercentage.Controls.Add(this.labelSinglePercentage);
	    this.panelSinglePercentage.Location = new System.Drawing.Point(14, 118);
	    this.panelSinglePercentage.Name = "panelSinglePercentage";
	    this.panelSinglePercentage.Size = new System.Drawing.Size(356, 45);
	    this.panelSinglePercentage.TabIndex = 0;
	    // 
	    // labelSingleCount
	    // 
	    this.labelSingleCount.AutoSize = true;
	    this.labelSingleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
	    this.labelSingleCount.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
	    this.labelSingleCount.Location = new System.Drawing.Point(223, 11);
	    this.labelSingleCount.Name = "labelSingleCount";
	    this.labelSingleCount.Size = new System.Drawing.Size(0, 24);
	    this.labelSingleCount.TabIndex = 1;
	    // 
	    // labelSinglePercentage
	    // 
	    this.labelSinglePercentage.AutoSize = true;
	    this.labelSinglePercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
	    this.labelSinglePercentage.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
	    this.labelSinglePercentage.Location = new System.Drawing.Point(11, 10);
	    this.labelSinglePercentage.Name = "labelSinglePercentage";
	    this.labelSinglePercentage.Size = new System.Drawing.Size(205, 25);
	    this.labelSinglePercentage.TabIndex = 0;
	    this.labelSinglePercentage.Text = "Singles Percentege:";
	    // 
	    // labelUpcomingBirthdays
	    // 
	    this.labelUpcomingBirthdays.AutoSize = true;
	    this.labelUpcomingBirthdays.ForeColor = System.Drawing.Color.Black;
	    this.labelUpcomingBirthdays.Location = new System.Drawing.Point(185, 171);
	    this.labelUpcomingBirthdays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
	    this.labelUpcomingBirthdays.Name = "labelUpcomingBirthdays";
	    this.labelUpcomingBirthdays.Size = new System.Drawing.Size(100, 13);
	    this.labelUpcomingBirthdays.TabIndex = 7;
	    this.labelUpcomingBirthdays.Text = "Upcoming birthdays";
	    // 
	    // labelTopLikers
	    // 
	    this.labelTopLikers.AutoSize = true;
	    this.labelTopLikers.Location = new System.Drawing.Point(11, 171);
	    this.labelTopLikers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
	    this.labelTopLikers.Name = "labelTopLikers";
	    this.labelTopLikers.Size = new System.Drawing.Size(57, 13);
	    this.labelTopLikers.TabIndex = 6;
	    this.labelTopLikers.Text = "Top Likers";
	    // 
	    // ListViewTopLikers
	    // 
	    this.ListViewTopLikers.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
	    this.ListViewTopLikers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CollumName,
            this.Likes});
	    this.ListViewTopLikers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
	    this.ListViewTopLikers.Location = new System.Drawing.Point(14, 186);
	    this.ListViewTopLikers.Margin = new System.Windows.Forms.Padding(2);
	    this.ListViewTopLikers.Name = "ListViewTopLikers";
	    this.ListViewTopLikers.Size = new System.Drawing.Size(156, 221);
	    this.ListViewTopLikers.TabIndex = 5;
	    this.ListViewTopLikers.UseCompatibleStateImageBehavior = false;
	    this.ListViewTopLikers.View = System.Windows.Forms.View.Details;
	    // 
	    // CollumName
	    // 
	    this.CollumName.Text = "Name";
	    this.CollumName.Width = 68;
	    // 
	    // Likes
	    // 
	    this.Likes.Text = "Likes";
	    this.Likes.Width = 45;
	    // 
	    // FormFriendsStatistics
	    // 
	    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	    this.AutoScroll = true;
	    this.BackColor = System.Drawing.SystemColors.ActiveCaption;
	    this.ClientSize = new System.Drawing.Size(396, 417);
	    this.Controls.Add(this.labelUpcomingBirthdays);
	    this.Controls.Add(this.labelTopLikers);
	    this.Controls.Add(this.ListViewTopLikers);
	    this.Controls.Add(this.ListViewBirthdayFriends);
	    this.Controls.Add(this.panelSinglePercentage);
	    this.Controls.Add(this.panelPercentage);
	    this.Controls.Add(this.panelFriendsNumber);
	    this.Name = "FormFriendsStatistics";
	    this.Text = "Friends Statistics";
	    this.panelFriendsNumber.ResumeLayout(false);
	    this.panelFriendsNumber.PerformLayout();
	    this.panelPercentage.ResumeLayout(false);
	    this.panelPercentage.PerformLayout();
	    this.panelSinglePercentage.ResumeLayout(false);
	    this.panelSinglePercentage.PerformLayout();
	    this.ResumeLayout(false);
	    this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFriendsNumber;
        private System.Windows.Forms.Label labelFriendsNumber;
        private System.Windows.Forms.ListView ListViewBirthdayFriends;
        private System.Windows.Forms.ColumnHeader FriendsBirthName;
        private System.Windows.Forms.ColumnHeader Birthdate;
        private System.Windows.Forms.Panel panelPercentage;
        private System.Windows.Forms.Label labelMaleFemalePercentage;
        private System.Windows.Forms.Panel panelSinglePercentage;
        private System.Windows.Forms.Label labelSinglePercentage;
        private System.Windows.Forms.Label labelFriendsNumberCount;
        private System.Windows.Forms.Label labelMaleFemaleCount;
        private System.Windows.Forms.Label labelSingleCount;
        private System.Windows.Forms.Label labelUpcomingBirthdays;
        private System.Windows.Forms.Label labelTopLikers;
        private System.Windows.Forms.ListView ListViewTopLikers;
        private System.Windows.Forms.ColumnHeader CollumName;
        private System.Windows.Forms.ColumnHeader Likes;
    }
}