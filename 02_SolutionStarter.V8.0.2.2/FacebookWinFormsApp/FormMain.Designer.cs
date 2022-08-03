namespace BasicFacebookFeatures
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelSidebarProfile = new System.Windows.Forms.Panel();
            this.labelProfileName = new System.Windows.Forms.Label();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.panelSidebarButtons = new System.Windows.Forms.Panel();
            this.buttonLikedPages = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonPosts = new System.Windows.Forms.Button();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.buttonAlbums = new System.Windows.Forms.Button();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.buttonFavoriteTeams = new System.Windows.Forms.Button();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelLoginMessage = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelSidebarProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            this.panelSidebarButtons.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.panelSidebar.Controls.Add(this.panelSidebarProfile);
            this.panelSidebar.Controls.Add(this.panelSidebarButtons);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(330, 1061);
            this.panelSidebar.TabIndex = 53;
            // 
            // panelSidebarProfile
            // 
            this.panelSidebarProfile.Controls.Add(this.labelProfileName);
            this.panelSidebarProfile.Controls.Add(this.pictureBoxProfilePicture);
            this.panelSidebarProfile.Location = new System.Drawing.Point(8, 4);
            this.panelSidebarProfile.Margin = new System.Windows.Forms.Padding(4);
            this.panelSidebarProfile.Name = "panelSidebarProfile";
            this.panelSidebarProfile.Size = new System.Drawing.Size(322, 240);
            this.panelSidebarProfile.TabIndex = 12;
            // 
            // labelProfileName
            // 
            this.labelProfileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProfileName.AutoSize = true;
            this.labelProfileName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfileName.ForeColor = System.Drawing.Color.White;
            this.labelProfileName.Location = new System.Drawing.Point(1, 159);
            this.labelProfileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProfileName.Name = "labelProfileName";
            this.labelProfileName.Size = new System.Drawing.Size(317, 45);
            this.labelProfileName.TabIndex = 1;
            this.labelProfileName.Text = "Firstname Lastname";
            this.labelProfileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelProfileName.Visible = false;
            this.labelProfileName.Click += new System.EventHandler(this.showUsersProfileForm);
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(91, 27);
            this.pictureBoxProfilePicture.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(140, 128);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxProfilePicture.TabIndex = 0;
            this.pictureBoxProfilePicture.TabStop = false;
            this.pictureBoxProfilePicture.Click += new System.EventHandler(this.showUsersProfileForm);
            // 
            // panelSidebarButtons
            // 
            this.panelSidebarButtons.Controls.Add(this.buttonLikedPages);
            this.panelSidebarButtons.Controls.Add(this.button11);
            this.panelSidebarButtons.Controls.Add(this.button8);
            this.panelSidebarButtons.Controls.Add(this.buttonPosts);
            this.panelSidebarButtons.Controls.Add(this.buttonStatistics);
            this.panelSidebarButtons.Controls.Add(this.buttonAlbums);
            this.panelSidebarButtons.Controls.Add(this.buttonEvents);
            this.panelSidebarButtons.Controls.Add(this.buttonFavoriteTeams);
            this.panelSidebarButtons.Controls.Add(this.buttonGroups);
            this.panelSidebarButtons.Location = new System.Drawing.Point(18, 251);
            this.panelSidebarButtons.Margin = new System.Windows.Forms.Padding(4);
            this.panelSidebarButtons.Name = "panelSidebarButtons";
            this.panelSidebarButtons.Size = new System.Drawing.Size(288, 810);
            this.panelSidebarButtons.TabIndex = 11;
            // 
            // buttonLikedPages
            // 
            this.buttonLikedPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonLikedPages.Enabled = false;
            this.buttonLikedPages.FlatAppearance.BorderSize = 0;
            this.buttonLikedPages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLikedPages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLikedPages.ForeColor = System.Drawing.Color.White;
            this.buttonLikedPages.Location = new System.Drawing.Point(1, 330);
            this.buttonLikedPages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLikedPages.Name = "buttonLikedPages";
            this.buttonLikedPages.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonLikedPages.Size = new System.Drawing.Size(288, 65);
            this.buttonLikedPages.TabIndex = 5;
            this.buttonLikedPages.Text = "Liked Pages";
            this.buttonLikedPages.UseVisualStyleBackColor = false;
            this.buttonLikedPages.Click += new System.EventHandler(this.buttonLikedPages_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.button11.Enabled = false;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(8, 740);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(276, 65);
            this.button11.TabIndex = 10;
            this.button11.Text = "Logout";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.button8.Enabled = false;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(1, 460);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button8.Size = new System.Drawing.Size(288, 65);
            this.button8.TabIndex = 7;
            this.button8.Text = "Feature2";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // buttonPosts
            // 
            this.buttonPosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonPosts.Enabled = false;
            this.buttonPosts.FlatAppearance.BorderSize = 0;
            this.buttonPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPosts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPosts.ForeColor = System.Drawing.Color.White;
            this.buttonPosts.Location = new System.Drawing.Point(1, 5);
            this.buttonPosts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPosts.Name = "buttonPosts";
            this.buttonPosts.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonPosts.Size = new System.Drawing.Size(288, 65);
            this.buttonPosts.TabIndex = 0;
            this.buttonPosts.Text = "Posts";
            this.buttonPosts.UseVisualStyleBackColor = false;
            this.buttonPosts.Click += new System.EventHandler(this.buttonPosts_Click);
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonStatistics.Enabled = false;
            this.buttonStatistics.FlatAppearance.BorderSize = 0;
            this.buttonStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatistics.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonStatistics.ForeColor = System.Drawing.Color.White;
            this.buttonStatistics.Location = new System.Drawing.Point(1, 395);
            this.buttonStatistics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonStatistics.Size = new System.Drawing.Size(288, 65);
            this.buttonStatistics.TabIndex = 6;
            this.buttonStatistics.Text = "Statistics";
            this.buttonStatistics.UseVisualStyleBackColor = false;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // buttonAlbums
            // 
            this.buttonAlbums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonAlbums.Enabled = false;
            this.buttonAlbums.FlatAppearance.BorderSize = 0;
            this.buttonAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlbums.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAlbums.ForeColor = System.Drawing.Color.White;
            this.buttonAlbums.Location = new System.Drawing.Point(1, 70);
            this.buttonAlbums.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAlbums.Name = "buttonAlbums";
            this.buttonAlbums.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAlbums.Size = new System.Drawing.Size(288, 65);
            this.buttonAlbums.TabIndex = 1;
            this.buttonAlbums.Text = "Albums";
            this.buttonAlbums.UseVisualStyleBackColor = false;
            this.buttonAlbums.Click += new System.EventHandler(this.buttonAlbums_Click);
            // 
            // buttonEvents
            // 
            this.buttonEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonEvents.Enabled = false;
            this.buttonEvents.FlatAppearance.BorderSize = 0;
            this.buttonEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEvents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonEvents.ForeColor = System.Drawing.Color.White;
            this.buttonEvents.Location = new System.Drawing.Point(1, 135);
            this.buttonEvents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonEvents.Size = new System.Drawing.Size(288, 65);
            this.buttonEvents.TabIndex = 2;
            this.buttonEvents.Text = "Events";
            this.buttonEvents.UseVisualStyleBackColor = false;
            this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // buttonFavoriteTeams
            // 
            this.buttonFavoriteTeams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonFavoriteTeams.Enabled = false;
            this.buttonFavoriteTeams.FlatAppearance.BorderSize = 0;
            this.buttonFavoriteTeams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFavoriteTeams.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFavoriteTeams.ForeColor = System.Drawing.Color.White;
            this.buttonFavoriteTeams.Location = new System.Drawing.Point(1, 265);
            this.buttonFavoriteTeams.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFavoriteTeams.Name = "buttonFavoriteTeams";
            this.buttonFavoriteTeams.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonFavoriteTeams.Size = new System.Drawing.Size(288, 65);
            this.buttonFavoriteTeams.TabIndex = 4;
            this.buttonFavoriteTeams.Text = "Favorite Teams";
            this.buttonFavoriteTeams.UseVisualStyleBackColor = false;
            this.buttonFavoriteTeams.Click += new System.EventHandler(this.buttonFavoriteTeams_Click);
            // 
            // buttonGroups
            // 
            this.buttonGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonGroups.Enabled = false;
            this.buttonGroups.FlatAppearance.BorderSize = 0;
            this.buttonGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroups.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonGroups.ForeColor = System.Drawing.Color.White;
            this.buttonGroups.Location = new System.Drawing.Point(1, 200);
            this.buttonGroups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonGroups.Size = new System.Drawing.Size(288, 65);
            this.buttonGroups.TabIndex = 3;
            this.buttonGroups.Text = "Groups";
            this.buttonGroups.UseVisualStyleBackColor = false;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.panelLogin);
            this.panelDesktop.Controls.Add(this.panelSidebar);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1684, 1061);
            this.panelDesktop.TabIndex = 54;
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.Controls.Add(this.checkBoxRememberMe);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.labelLoginMessage);
            this.panelLogin.Controls.Add(this.labelWelcome);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(330, 0);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(1354, 1061);
            this.panelLogin.TabIndex = 54;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxRememberMe.Location = new System.Drawing.Point(579, 504);
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(258, 41);
            this.checkBoxRememberMe.TabIndex = 42;
            this.checkBoxRememberMe.Text = "Remember me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            this.checkBoxRememberMe.Visible = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(543, 428);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(325, 64);
            this.buttonLogin.TabIndex = 41;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Visible = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelLoginMessage
            // 
            this.labelLoginMessage.AutoSize = true;
            this.labelLoginMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLoginMessage.Location = new System.Drawing.Point(421, 349);
            this.labelLoginMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoginMessage.Name = "labelLoginMessage";
            this.labelLoginMessage.Size = new System.Drawing.Size(601, 63);
            this.labelLoginMessage.TabIndex = 40;
            this.labelLoginMessage.Text = "Please login to continue";
            this.labelLoginMessage.Visible = false;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelWelcome.Location = new System.Drawing.Point(273, 188);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(911, 181);
            this.labelWelcome.TabIndex = 39;
            this.labelWelcome.Text = "WELCOME";
            this.labelWelcome.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 1061);
            this.Controls.Add(this.panelDesktop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook";
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebarProfile.ResumeLayout(false);
            this.panelSidebarProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            this.panelSidebarButtons.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

		#endregion
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button buttonStatistics;
        private System.Windows.Forms.Button buttonLikedPages;
        private System.Windows.Forms.Button buttonFavoriteTeams;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.Button buttonAlbums;
        private System.Windows.Forms.Button buttonPosts;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelLoginMessage;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Panel panelSidebarButtons;
        private System.Windows.Forms.Panel panelSidebarProfile;
        private System.Windows.Forms.Label labelProfileName;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
    }
}

