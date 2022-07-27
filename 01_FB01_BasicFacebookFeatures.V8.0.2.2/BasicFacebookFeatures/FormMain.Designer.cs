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
			this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
			this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
			this.listBoxAlbums = new System.Windows.Forms.ListBox();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.listBoxEvents = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxStatus = new System.Windows.Forms.TextBox();
			this.buttonSetStatus = new System.Windows.Forms.Button();
			this.listBoxPosts = new System.Windows.Forms.ListBox();
			this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
			this.linkAlbums = new System.Windows.Forms.LinkLabel();
			this.labelEvents = new System.Windows.Forms.LinkLabel();
			this.linkPosts = new System.Windows.Forms.LinkLabel();
			this.linkFavoriteTeams = new System.Windows.Forms.LinkLabel();
			this.listBoxFavoriteTeams = new System.Windows.Forms.ListBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.pictureBoxFavoriteTeam = new System.Windows.Forms.PictureBox();
			this.buttonLogout = new System.Windows.Forms.Button();
			this.listBoxPostComments = new System.Windows.Forms.ListBox();
			this.pictureBoxPage = new System.Windows.Forms.PictureBox();
			this.pictureBoxGroup = new System.Windows.Forms.PictureBox();
			this.listBoxPages = new System.Windows.Forms.ListBox();
			this.linkPages = new System.Windows.Forms.LinkLabel();
			this.listBoxGroups = new System.Windows.Forms.ListBox();
			this.linkLabelFetchGroups = new System.Windows.Forms.LinkLabel();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.comboBoxActionType = new System.Windows.Forms.ComboBox();
			this.dataGridViewActions = new System.Windows.Forms.DataGridView();
			this.linkUserActions = new System.Windows.Forms.LinkLabel();
			this.buttonSettings = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavoriteTeam)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewActions)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxAlbum
			// 
			this.pictureBoxAlbum.BackColor = System.Drawing.Color.Gainsboro;
			this.pictureBoxAlbum.Location = new System.Drawing.Point(137, 321);
			this.pictureBoxAlbum.Name = "pictureBoxAlbum";
			this.pictureBoxAlbum.Size = new System.Drawing.Size(77, 68);
			this.pictureBoxAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxAlbum.TabIndex = 42;
			this.pictureBoxAlbum.TabStop = false;
			// 
			// pictureBoxProfile
			// 
			this.pictureBoxProfile.Location = new System.Drawing.Point(8, 81);
			this.pictureBoxProfile.Name = "pictureBoxProfile";
			this.pictureBoxProfile.Size = new System.Drawing.Size(156, 107);
			this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxProfile.TabIndex = 41;
			this.pictureBoxProfile.TabStop = false;
			// 
			// listBoxAlbums
			// 
			this.listBoxAlbums.FormattingEnabled = true;
			this.listBoxAlbums.Location = new System.Drawing.Point(8, 242);
			this.listBoxAlbums.Name = "listBoxAlbums";
			this.listBoxAlbums.Size = new System.Drawing.Size(206, 147);
			this.listBoxAlbums.TabIndex = 37;
			this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
			// 
			// buttonLogin
			// 
			this.buttonLogin.Location = new System.Drawing.Point(8, 6);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(75, 23);
			this.buttonLogin.TabIndex = 36;
			this.buttonLogin.Text = "Login";
			this.buttonLogin.UseVisualStyleBackColor = true;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// listBoxEvents
			// 
			this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxEvents.DisplayMember = "name";
			this.listBoxEvents.FormattingEnabled = true;
			this.listBoxEvents.Location = new System.Drawing.Point(220, 242);
			this.listBoxEvents.Name = "listBoxEvents";
			this.listBoxEvents.Size = new System.Drawing.Size(231, 147);
			this.listBoxEvents.TabIndex = 40;
			this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(452, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 13);
			this.label3.TabIndex = 44;
			this.label3.Text = "Post Status:";
			// 
			// textBoxStatus
			// 
			this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxStatus.Location = new System.Drawing.Point(522, 10);
			this.textBoxStatus.Name = "textBoxStatus";
			this.textBoxStatus.Size = new System.Drawing.Size(221, 20);
			this.textBoxStatus.TabIndex = 45;
			// 
			// buttonSetStatus
			// 
			this.buttonSetStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSetStatus.Location = new System.Drawing.Point(749, 8);
			this.buttonSetStatus.Name = "buttonSetStatus";
			this.buttonSetStatus.Size = new System.Drawing.Size(75, 23);
			this.buttonSetStatus.TabIndex = 46;
			this.buttonSetStatus.Text = "Post";
			this.buttonSetStatus.UseVisualStyleBackColor = true;
			this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
			// 
			// listBoxPosts
			// 
			this.listBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxPosts.DisplayMember = "name";
			this.listBoxPosts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxPosts.FormattingEnabled = true;
			this.listBoxPosts.ItemHeight = 19;
			this.listBoxPosts.Location = new System.Drawing.Point(216, 51);
			this.listBoxPosts.Name = "listBoxPosts";
			this.listBoxPosts.Size = new System.Drawing.Size(608, 137);
			this.listBoxPosts.TabIndex = 40;
			this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
			// 
			// pictureBoxEvent
			// 
			this.pictureBoxEvent.BackColor = System.Drawing.Color.Gainsboro;
			this.pictureBoxEvent.Location = new System.Drawing.Point(377, 321);
			this.pictureBoxEvent.Name = "pictureBoxEvent";
			this.pictureBoxEvent.Size = new System.Drawing.Size(74, 68);
			this.pictureBoxEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxEvent.TabIndex = 42;
			this.pictureBoxEvent.TabStop = false;
			// 
			// linkAlbums
			// 
			this.linkAlbums.AutoSize = true;
			this.linkAlbums.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
			this.linkAlbums.Location = new System.Drawing.Point(8, 213);
			this.linkAlbums.Name = "linkAlbums";
			this.linkAlbums.Size = new System.Drawing.Size(206, 30);
			this.linkAlbums.TabIndex = 47;
			this.linkAlbums.TabStop = true;
			this.linkAlbums.Text = "Fetch Albums\r\n(Click an album to view its cover picture)";
			this.linkAlbums.UseCompatibleTextRendering = true;
			this.linkAlbums.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFriends_LinkClicked);
			// 
			// labelEvents
			// 
			this.labelEvents.AutoSize = true;
			this.labelEvents.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
			this.labelEvents.Location = new System.Drawing.Point(220, 213);
			this.labelEvents.Name = "labelEvents";
			this.labelEvents.Size = new System.Drawing.Size(190, 30);
			this.labelEvents.TabIndex = 48;
			this.labelEvents.TabStop = true;
			this.labelEvents.Text = "Fetch Events \r\n(Click on an event to view it\'s picture)";
			this.labelEvents.UseCompatibleTextRendering = true;
			this.labelEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelEvents_LinkClicked);
			// 
			// linkPosts
			// 
			this.linkPosts.AutoSize = true;
			this.linkPosts.LinkArea = new System.Windows.Forms.LinkArea(0, 12);
			this.linkPosts.Location = new System.Drawing.Point(217, 22);
			this.linkPosts.Name = "linkPosts";
			this.linkPosts.Size = new System.Drawing.Size(207, 30);
			this.linkPosts.TabIndex = 49;
			this.linkPosts.TabStop = true;
			this.linkPosts.Text = "Fetch Posts\r\n(Click on a post to view the comments!)\r\n";
			this.linkPosts.UseCompatibleTextRendering = true;
			this.linkPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPosts_LinkClicked);
			// 
			// linkFavoriteTeams
			// 
			this.linkFavoriteTeams.AutoSize = true;
			this.linkFavoriteTeams.LinkArea = new System.Windows.Forms.LinkArea(0, 20);
			this.linkFavoriteTeams.Location = new System.Drawing.Point(8, 409);
			this.linkFavoriteTeams.Name = "linkFavoriteTeams";
			this.linkFavoriteTeams.Size = new System.Drawing.Size(123, 17);
			this.linkFavoriteTeams.TabIndex = 50;
			this.linkFavoriteTeams.TabStop = true;
			this.linkFavoriteTeams.Text = "Fetch Favorite Teams \r\n";
			this.linkFavoriteTeams.UseCompatibleTextRendering = true;
			this.linkFavoriteTeams.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFavoriteTeams_LinkClicked);
			// 
			// listBoxFavoriteTeams
			// 
			this.listBoxFavoriteTeams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.listBoxFavoriteTeams.DisplayMember = "name";
			this.listBoxFavoriteTeams.FormattingEnabled = true;
			this.listBoxFavoriteTeams.Location = new System.Drawing.Point(8, 435);
			this.listBoxFavoriteTeams.Name = "listBoxFavoriteTeams";
			this.listBoxFavoriteTeams.Size = new System.Drawing.Size(206, 173);
			this.listBoxFavoriteTeams.TabIndex = 40;
			this.listBoxFavoriteTeams.SelectedIndexChanged += new System.EventHandler(this.listBoxFavoriteTeams_SelectedIndexChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(842, 657);
			this.tabControl1.TabIndex = 51;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.buttonSettings);
			this.tabPage1.Controls.Add(this.pictureBoxFavoriteTeam);
			this.tabPage1.Controls.Add(this.pictureBoxAlbum);
			this.tabPage1.Controls.Add(this.buttonLogout);
			this.tabPage1.Controls.Add(this.listBoxPostComments);
			this.tabPage1.Controls.Add(this.pictureBoxPage);
			this.tabPage1.Controls.Add(this.pictureBoxGroup);
			this.tabPage1.Controls.Add(this.pictureBoxEvent);
			this.tabPage1.Controls.Add(this.buttonLogin);
			this.tabPage1.Controls.Add(this.linkFavoriteTeams);
			this.tabPage1.Controls.Add(this.listBoxAlbums);
			this.tabPage1.Controls.Add(this.listBoxPages);
			this.tabPage1.Controls.Add(this.linkPages);
			this.tabPage1.Controls.Add(this.listBoxGroups);
			this.tabPage1.Controls.Add(this.linkLabelFetchGroups);
			this.tabPage1.Controls.Add(this.listBoxEvents);
			this.tabPage1.Controls.Add(this.labelEvents);
			this.tabPage1.Controls.Add(this.listBoxFavoriteTeams);
			this.tabPage1.Controls.Add(this.linkAlbums);
			this.tabPage1.Controls.Add(this.listBoxPosts);
			this.tabPage1.Controls.Add(this.buttonSetStatus);
			this.tabPage1.Controls.Add(this.pictureBoxProfile);
			this.tabPage1.Controls.Add(this.textBoxStatus);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.linkPosts);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(834, 631);
			this.tabPage1.TabIndex = 1;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// pictureBoxFavoriteTeam
			// 
			this.pictureBoxFavoriteTeam.BackColor = System.Drawing.Color.Gainsboro;
			this.pictureBoxFavoriteTeam.Location = new System.Drawing.Point(140, 540);
			this.pictureBoxFavoriteTeam.Name = "pictureBoxFavoriteTeam";
			this.pictureBoxFavoriteTeam.Size = new System.Drawing.Size(74, 68);
			this.pictureBoxFavoriteTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxFavoriteTeam.TabIndex = 53;
			this.pictureBoxFavoriteTeam.TabStop = false;
			// 
			// buttonLogout
			// 
			this.buttonLogout.Location = new System.Drawing.Point(89, 6);
			this.buttonLogout.Name = "buttonLogout";
			this.buttonLogout.Size = new System.Drawing.Size(75, 23);
			this.buttonLogout.TabIndex = 52;
			this.buttonLogout.Text = "Logout";
			this.buttonLogout.UseVisualStyleBackColor = true;
			this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
			// 
			// listBoxPostComments
			// 
			this.listBoxPostComments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxPostComments.BackColor = System.Drawing.SystemColors.Info;
			this.listBoxPostComments.DisplayMember = "name";
			this.listBoxPostComments.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxPostComments.FormattingEnabled = true;
			this.listBoxPostComments.ItemHeight = 19;
			this.listBoxPostComments.Location = new System.Drawing.Point(606, 108);
			this.listBoxPostComments.Name = "listBoxPostComments";
			this.listBoxPostComments.Size = new System.Drawing.Size(208, 99);
			this.listBoxPostComments.TabIndex = 51;
			this.listBoxPostComments.DoubleClick += new System.EventHandler(this.listBoxPostComments_DoubleClick);
			// 
			// pictureBoxPage
			// 
			this.pictureBoxPage.BackColor = System.Drawing.Color.Gainsboro;
			this.pictureBoxPage.Location = new System.Drawing.Point(377, 540);
			this.pictureBoxPage.Name = "pictureBoxPage";
			this.pictureBoxPage.Size = new System.Drawing.Size(74, 68);
			this.pictureBoxPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxPage.TabIndex = 42;
			this.pictureBoxPage.TabStop = false;
			// 
			// pictureBoxGroup
			// 
			this.pictureBoxGroup.BackColor = System.Drawing.Color.Gainsboro;
			this.pictureBoxGroup.Location = new System.Drawing.Point(614, 321);
			this.pictureBoxGroup.Name = "pictureBoxGroup";
			this.pictureBoxGroup.Size = new System.Drawing.Size(74, 68);
			this.pictureBoxGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxGroup.TabIndex = 42;
			this.pictureBoxGroup.TabStop = false;
			// 
			// listBoxPages
			// 
			this.listBoxPages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxPages.DisplayMember = "name";
			this.listBoxPages.FormattingEnabled = true;
			this.listBoxPages.Location = new System.Drawing.Point(220, 435);
			this.listBoxPages.Name = "listBoxPages";
			this.listBoxPages.Size = new System.Drawing.Size(231, 173);
			this.listBoxPages.TabIndex = 40;
			this.listBoxPages.SelectedIndexChanged += new System.EventHandler(this.listBoxPages_SelectedIndexChanged);
			// 
			// linkPages
			// 
			this.linkPages.AutoSize = true;
			this.linkPages.LinkArea = new System.Windows.Forms.LinkArea(0, 17);
			this.linkPages.Location = new System.Drawing.Point(220, 406);
			this.linkPages.Name = "linkPages";
			this.linkPages.Size = new System.Drawing.Size(181, 30);
			this.linkPages.TabIndex = 48;
			this.linkPages.TabStop = true;
			this.linkPages.Text = "Fetch Liked Pages \r\n(Click on a page to view it\'s picture)";
			this.linkPages.UseCompatibleTextRendering = true;
			this.linkPages.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPages_LinkClicked);
			// 
			// listBoxGroups
			// 
			this.listBoxGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxGroups.DisplayMember = "name";
			this.listBoxGroups.FormattingEnabled = true;
			this.listBoxGroups.Location = new System.Drawing.Point(457, 242);
			this.listBoxGroups.Name = "listBoxGroups";
			this.listBoxGroups.Size = new System.Drawing.Size(231, 147);
			this.listBoxGroups.TabIndex = 40;
			this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
			// 
			// linkLabelFetchGroups
			// 
			this.linkLabelFetchGroups.AutoSize = true;
			this.linkLabelFetchGroups.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
			this.linkLabelFetchGroups.Location = new System.Drawing.Point(457, 213);
			this.linkLabelFetchGroups.Name = "linkLabelFetchGroups";
			this.linkLabelFetchGroups.Size = new System.Drawing.Size(191, 30);
			this.linkLabelFetchGroups.TabIndex = 48;
			this.linkLabelFetchGroups.TabStop = true;
			this.linkLabelFetchGroups.Text = "Fetch Groups \r\n(Click on an group to view it\'s picture)";
			this.linkLabelFetchGroups.UseCompatibleTextRendering = true;
			this.linkLabelFetchGroups.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelGroups_LinkClicked);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.comboBoxActionType);
			this.tabPage2.Controls.Add(this.dataGridViewActions);
			this.tabPage2.Controls.Add(this.linkUserActions);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(834, 631);
			this.tabPage2.TabIndex = 2;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// comboBoxActionType
			// 
			this.comboBoxActionType.FormattingEnabled = true;
			this.comboBoxActionType.Items.AddRange(new object[] {
            "music",
            "television",
            "movies",
            "books",
            "books.reads",
            "books.wants_to_read",
            "books.rates",
            "books.quotes",
            "fitness.runs",
            "fitness.walks",
            "fitness.bikes",
            "music.listens",
            "music.playlists",
            "news.reads",
            "news.publishes",
            "video.watches",
            "video.rates",
            "videos.wants_to_watch"});
			this.comboBoxActionType.Location = new System.Drawing.Point(120, 6);
			this.comboBoxActionType.Name = "comboBoxActionType";
			this.comboBoxActionType.Size = new System.Drawing.Size(165, 21);
			this.comboBoxActionType.TabIndex = 23;
			// 
			// dataGridViewActions
			// 
			this.dataGridViewActions.AllowUserToAddRows = false;
			this.dataGridViewActions.AllowUserToDeleteRows = false;
			this.dataGridViewActions.AllowUserToOrderColumns = true;
			this.dataGridViewActions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewActions.Location = new System.Drawing.Point(11, 33);
			this.dataGridViewActions.Name = "dataGridViewActions";
			this.dataGridViewActions.ReadOnly = true;
			this.dataGridViewActions.Size = new System.Drawing.Size(815, 571);
			this.dataGridViewActions.TabIndex = 22;
			// 
			// linkUserActions
			// 
			this.linkUserActions.AutoSize = true;
			this.linkUserActions.Location = new System.Drawing.Point(8, 9);
			this.linkUserActions.Name = "linkUserActions";
			this.linkUserActions.Size = new System.Drawing.Size(97, 13);
			this.linkUserActions.TabIndex = 14;
			this.linkUserActions.TabStop = true;
			this.linkUserActions.Text = "Fetch User Actions";
			this.linkUserActions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUserActions_LinkClicked);
			// 
			// buttonSettings
			// 
			this.buttonSettings.Location = new System.Drawing.Point(8, 35);
			this.buttonSettings.Name = "buttonSettings";
			this.buttonSettings.Size = new System.Drawing.Size(156, 23);
			this.buttonSettings.TabIndex = 54;
			this.buttonSettings.Text = "Settings";
			this.buttonSettings.UseVisualStyleBackColor = true;
			this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(842, 657);
			this.Controls.Add(this.tabControl1);
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavoriteTeam)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewActions)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAlbum;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonSetStatus;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
        private System.Windows.Forms.LinkLabel linkAlbums;
        private System.Windows.Forms.LinkLabel labelEvents;
        private System.Windows.Forms.LinkLabel linkPosts;
        private System.Windows.Forms.LinkLabel linkFavoriteTeams;
        private System.Windows.Forms.ListBox listBoxFavoriteTeams;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBoxPage;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.LinkLabel linkPages;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBoxActionType;
        private System.Windows.Forms.DataGridView dataGridViewActions;
        private System.Windows.Forms.LinkLabel linkUserActions;
        private System.Windows.Forms.ListBox listBoxPostComments;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBoxFavoriteTeam;
        private System.Windows.Forms.PictureBox pictureBoxGroup;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.LinkLabel linkLabelFetchGroups;
		private System.Windows.Forms.Button buttonSettings;
	}
}

