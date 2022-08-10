namespace FacebookWinFormsApp.Forms
{
    internal partial class FormStatistics
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
            this.dateTimePickerChosenDate = new System.Windows.Forms.DateTimePicker();
            this.labelChooseDate = new System.Windows.Forms.Label();
            this.labelNumberOfLikesOnPhotos = new System.Windows.Forms.Label();
            this.labelNumberOfPosts = new System.Windows.Forms.Label();
            this.labelMonthSummary = new System.Windows.Forms.Label();
            this.panelStatistics1 = new System.Windows.Forms.Panel();
            this.pictureBoxLikesOnPhotos = new System.Windows.Forms.PictureBox();
            this.pictureBoxPosts = new System.Windows.Forms.PictureBox();
            this.labelNumberOfNewPhotos = new System.Windows.Forms.Label();
            this.labelNumberOfNewAlbums = new System.Windows.Forms.Label();
            this.panelStatistics2 = new System.Windows.Forms.Panel();
            this.pictureBoxNewAlbums = new System.Windows.Forms.PictureBox();
            this.pictureBoxNewPhotos = new System.Windows.Forms.PictureBox();
            this.buttonShowStatistics = new System.Windows.Forms.Button();
            this.panelSummary = new System.Windows.Forms.Panel();
            this.panelStatistics1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikesOnPhotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosts)).BeginInit();
            this.panelStatistics2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewAlbums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewPhotos)).BeginInit();
            this.panelSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerChosenDate
            // 
            this.dateTimePickerChosenDate.AllowDrop = true;
            this.dateTimePickerChosenDate.CustomFormat = "MM/yyyy";
            this.dateTimePickerChosenDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerChosenDate.Location = new System.Drawing.Point(272, 59);
            this.dateTimePickerChosenDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerChosenDate.Name = "dateTimePickerChosenDate";
            this.dateTimePickerChosenDate.ShowUpDown = true;
            this.dateTimePickerChosenDate.Size = new System.Drawing.Size(73, 20);
            this.dateTimePickerChosenDate.TabIndex = 1;
            // 
            // labelChooseDate
            // 
            this.labelChooseDate.AutoSize = true;
            this.labelChooseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelChooseDate.Location = new System.Drawing.Point(88, 57);
            this.labelChooseDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChooseDate.Name = "labelChooseDate";
            this.labelChooseDate.Size = new System.Drawing.Size(182, 20);
            this.labelChooseDate.TabIndex = 2;
            this.labelChooseDate.Text = "Please choose a date";
            this.labelChooseDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumberOfLikesOnPhotos
            // 
            this.labelNumberOfLikesOnPhotos.AutoSize = true;
            this.labelNumberOfLikesOnPhotos.Location = new System.Drawing.Point(4, 65);
            this.labelNumberOfLikesOnPhotos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumberOfLikesOnPhotos.Name = "labelNumberOfLikesOnPhotos";
            this.labelNumberOfLikesOnPhotos.Size = new System.Drawing.Size(0, 13);
            this.labelNumberOfLikesOnPhotos.TabIndex = 8;
            // 
            // labelNumberOfPosts
            // 
            this.labelNumberOfPosts.AutoSize = true;
            this.labelNumberOfPosts.Location = new System.Drawing.Point(191, 65);
            this.labelNumberOfPosts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumberOfPosts.Name = "labelNumberOfPosts";
            this.labelNumberOfPosts.Size = new System.Drawing.Size(0, 13);
            this.labelNumberOfPosts.TabIndex = 10;
            // 
            // labelMonthSummary
            // 
            this.labelMonthSummary.AutoSize = true;
            this.labelMonthSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMonthSummary.Location = new System.Drawing.Point(156, 6);
            this.labelMonthSummary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMonthSummary.Name = "labelMonthSummary";
            this.labelMonthSummary.Size = new System.Drawing.Size(246, 31);
            this.labelMonthSummary.TabIndex = 11;
            this.labelMonthSummary.Text = "Monthly Summary";
            // 
            // panelStatistics1
            // 
            this.panelStatistics1.Controls.Add(this.labelNumberOfPosts);
            this.panelStatistics1.Controls.Add(this.labelNumberOfLikesOnPhotos);
            this.panelStatistics1.Controls.Add(this.pictureBoxLikesOnPhotos);
            this.panelStatistics1.Controls.Add(this.pictureBoxPosts);
            this.panelStatistics1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatistics1.Location = new System.Drawing.Point(0, 0);
            this.panelStatistics1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelStatistics1.Name = "panelStatistics1";
            this.panelStatistics1.Size = new System.Drawing.Size(252, 122);
            this.panelStatistics1.TabIndex = 12;
            // 
            // pictureBoxLikesOnPhotos
            // 
            this.pictureBoxLikesOnPhotos.ErrorImage = null;
            this.pictureBoxLikesOnPhotos.Image = global::BasicFacebookFeatures.Properties.Resources.Statistics_Likes;
            this.pictureBoxLikesOnPhotos.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLikesOnPhotos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxLikesOnPhotos.Name = "pictureBoxLikesOnPhotos";
            this.pictureBoxLikesOnPhotos.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxLikesOnPhotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLikesOnPhotos.TabIndex = 7;
            this.pictureBoxLikesOnPhotos.TabStop = false;
            // 
            // pictureBoxPosts
            // 
            this.pictureBoxPosts.ErrorImage = null;
            this.pictureBoxPosts.Image = global::BasicFacebookFeatures.Properties.Resources.Statistics_Posts;
            this.pictureBoxPosts.Location = new System.Drawing.Point(188, 0);
            this.pictureBoxPosts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxPosts.Name = "pictureBoxPosts";
            this.pictureBoxPosts.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxPosts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPosts.TabIndex = 9;
            this.pictureBoxPosts.TabStop = false;
            // 
            // labelNumberOfNewPhotos
            // 
            this.labelNumberOfNewPhotos.AutoSize = true;
            this.labelNumberOfNewPhotos.Location = new System.Drawing.Point(191, 65);
            this.labelNumberOfNewPhotos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumberOfNewPhotos.Name = "labelNumberOfNewPhotos";
            this.labelNumberOfNewPhotos.Size = new System.Drawing.Size(0, 13);
            this.labelNumberOfNewPhotos.TabIndex = 13;
            // 
            // labelNumberOfNewAlbums
            // 
            this.labelNumberOfNewAlbums.AutoSize = true;
            this.labelNumberOfNewAlbums.Location = new System.Drawing.Point(4, 65);
            this.labelNumberOfNewAlbums.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumberOfNewAlbums.Name = "labelNumberOfNewAlbums";
            this.labelNumberOfNewAlbums.Size = new System.Drawing.Size(0, 13);
            this.labelNumberOfNewAlbums.TabIndex = 12;
            // 
            // panelStatistics2
            // 
            this.panelStatistics2.Controls.Add(this.labelNumberOfNewPhotos);
            this.panelStatistics2.Controls.Add(this.pictureBoxNewAlbums);
            this.panelStatistics2.Controls.Add(this.labelNumberOfNewAlbums);
            this.panelStatistics2.Controls.Add(this.pictureBoxNewPhotos);
            this.panelStatistics2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatistics2.Location = new System.Drawing.Point(0, 127);
            this.panelStatistics2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelStatistics2.Name = "panelStatistics2";
            this.panelStatistics2.Size = new System.Drawing.Size(252, 122);
            this.panelStatistics2.TabIndex = 14;
            // 
            // pictureBoxNewAlbums
            // 
            this.pictureBoxNewAlbums.ErrorImage = null;
            this.pictureBoxNewAlbums.Image = global::BasicFacebookFeatures.Properties.Resources.Statistics_Albums;
            this.pictureBoxNewAlbums.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxNewAlbums.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxNewAlbums.Name = "pictureBoxNewAlbums";
            this.pictureBoxNewAlbums.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxNewAlbums.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxNewAlbums.TabIndex = 10;
            this.pictureBoxNewAlbums.TabStop = false;
            // 
            // pictureBoxNewPhotos
            // 
            this.pictureBoxNewPhotos.ErrorImage = null;
            this.pictureBoxNewPhotos.Image = global::BasicFacebookFeatures.Properties.Resources.Statistics_Photos;
            this.pictureBoxNewPhotos.Location = new System.Drawing.Point(188, 0);
            this.pictureBoxNewPhotos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxNewPhotos.Name = "pictureBoxNewPhotos";
            this.pictureBoxNewPhotos.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxNewPhotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxNewPhotos.TabIndex = 11;
            this.pictureBoxNewPhotos.TabStop = false;
            // 
            // buttonShowStatistics
            // 
            this.buttonShowStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonShowStatistics.Location = new System.Drawing.Point(353, 54);
            this.buttonShowStatistics.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonShowStatistics.Name = "buttonShowStatistics";
            this.buttonShowStatistics.Size = new System.Drawing.Size(165, 29);
            this.buttonShowStatistics.TabIndex = 15;
            this.buttonShowStatistics.Text = "Show Statistics";
            this.buttonShowStatistics.UseVisualStyleBackColor = true;
            this.buttonShowStatistics.Click += new System.EventHandler(this.buttonShowStatistics_Click);
            // 
            // panelSummary
            // 
            this.panelSummary.Controls.Add(this.panelStatistics2);
            this.panelSummary.Controls.Add(this.panelStatistics1);
            this.panelSummary.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.panelSummary.Location = new System.Drawing.Point(152, 111);
            this.panelSummary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(252, 249);
            this.panelSummary.TabIndex = 16;
            this.panelSummary.Visible = false;
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 548);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.buttonShowStatistics);
            this.Controls.Add(this.labelMonthSummary);
            this.Controls.Add(this.labelChooseDate);
            this.Controls.Add(this.dateTimePickerChosenDate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormStatistics";
            this.Text = "Statistics";
            this.panelStatistics1.ResumeLayout(false);
            this.panelStatistics1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikesOnPhotos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosts)).EndInit();
            this.panelStatistics2.ResumeLayout(false);
            this.panelStatistics2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewAlbums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewPhotos)).EndInit();
            this.panelSummary.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerChosenDate;
        private System.Windows.Forms.Label labelChooseDate;
        private System.Windows.Forms.PictureBox pictureBoxLikesOnPhotos;
        private System.Windows.Forms.Label labelNumberOfLikesOnPhotos;
        private System.Windows.Forms.PictureBox pictureBoxPosts;
        private System.Windows.Forms.Label labelNumberOfPosts;
        private System.Windows.Forms.Label labelMonthSummary;
        private System.Windows.Forms.Panel panelStatistics1;
        private System.Windows.Forms.PictureBox pictureBoxNewPhotos;
        private System.Windows.Forms.PictureBox pictureBoxNewAlbums;
        private System.Windows.Forms.Label labelNumberOfNewPhotos;
        private System.Windows.Forms.Label labelNumberOfNewAlbums;
        private System.Windows.Forms.Panel panelStatistics2;
        private System.Windows.Forms.Button buttonShowStatistics;
        private System.Windows.Forms.Panel panelSummary;
    }
}