namespace BasicFacebookFeatures.Forms
{
    partial class FormStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatistics));
            this.dateTimePickerChoosedMonth = new System.Windows.Forms.DateTimePicker();
            this.labelChooseMonth = new System.Windows.Forms.Label();
            this.pictureBoxLikesOnPhotos = new System.Windows.Forms.PictureBox();
            this.labelNumberOfLikesOnPhotos = new System.Windows.Forms.Label();
            this.pictureBoxPosts = new System.Windows.Forms.PictureBox();
            this.labelNumberOfPosts = new System.Windows.Forms.Label();
            this.labelMonthSummary = new System.Windows.Forms.Label();
            this.panelStatistics1 = new System.Windows.Forms.Panel();
            this.labelNumberOfNewPhotos = new System.Windows.Forms.Label();
            this.labelNumberOfNewAlbums = new System.Windows.Forms.Label();
            this.pictureBoxNewPhotos = new System.Windows.Forms.PictureBox();
            this.pictureBoxNewAlbums = new System.Windows.Forms.PictureBox();
            this.panelStatistics2 = new System.Windows.Forms.Panel();
            this.buttonShowStatistics = new System.Windows.Forms.Button();
            this.panelSummary = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikesOnPhotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosts)).BeginInit();
            this.panelStatistics1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewPhotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewAlbums)).BeginInit();
            this.panelStatistics2.SuspendLayout();
            this.panelSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerChoosedMonth
            // 
            this.dateTimePickerChoosedMonth.AllowDrop = true;
            this.dateTimePickerChoosedMonth.CustomFormat = "MM/yyyy";
            this.dateTimePickerChoosedMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerChoosedMonth.Location = new System.Drawing.Point(364, 27);
            this.dateTimePickerChoosedMonth.Name = "dateTimePickerChoosedMonth";
            this.dateTimePickerChoosedMonth.ShowUpDown = true;
            this.dateTimePickerChoosedMonth.Size = new System.Drawing.Size(131, 22);
            this.dateTimePickerChoosedMonth.TabIndex = 1;
            // 
            // labelChooseMonth
            // 
            this.labelChooseMonth.AutoSize = true;
            this.labelChooseMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelChooseMonth.Location = new System.Drawing.Point(76, 30);
            this.labelChooseMonth.Name = "labelChooseMonth";
            this.labelChooseMonth.Size = new System.Drawing.Size(196, 20);
            this.labelChooseMonth.TabIndex = 2;
            this.labelChooseMonth.Text = "Please choose a month";
            // 
            // pictureBoxLikesOnPhotos
            // 
            this.pictureBoxLikesOnPhotos.ErrorImage = null;
            this.pictureBoxLikesOnPhotos.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLikesOnPhotos.Image")));
            this.pictureBoxLikesOnPhotos.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLikesOnPhotos.Name = "pictureBoxLikesOnPhotos";
            this.pictureBoxLikesOnPhotos.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxLikesOnPhotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLikesOnPhotos.TabIndex = 7;
            this.pictureBoxLikesOnPhotos.TabStop = false;
            // 
            // labelNumberOfLikesOnPhotos
            // 
            this.labelNumberOfLikesOnPhotos.AutoSize = true;
            this.labelNumberOfLikesOnPhotos.Location = new System.Drawing.Point(5, 80);
            this.labelNumberOfLikesOnPhotos.Name = "labelNumberOfLikesOnPhotos";
            this.labelNumberOfLikesOnPhotos.Size = new System.Drawing.Size(0, 16);
            this.labelNumberOfLikesOnPhotos.TabIndex = 8;
            // 
            // pictureBoxPosts
            // 
            this.pictureBoxPosts.ErrorImage = null;
            this.pictureBoxPosts.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPosts.Image")));
            this.pictureBoxPosts.Location = new System.Drawing.Point(250, 0);
            this.pictureBoxPosts.Name = "pictureBoxPosts";
            this.pictureBoxPosts.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxPosts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPosts.TabIndex = 9;
            this.pictureBoxPosts.TabStop = false;
            // 
            // labelNumberOfPosts
            // 
            this.labelNumberOfPosts.AutoSize = true;
            this.labelNumberOfPosts.Location = new System.Drawing.Point(255, 80);
            this.labelNumberOfPosts.Name = "labelNumberOfPosts";
            this.labelNumberOfPosts.Size = new System.Drawing.Size(0, 16);
            this.labelNumberOfPosts.TabIndex = 10;
            // 
            // labelMonthSummary
            // 
            this.labelMonthSummary.AutoSize = true;
            this.labelMonthSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMonthSummary.Location = new System.Drawing.Point(267, 150);
            this.labelMonthSummary.Name = "labelMonthSummary";
            this.labelMonthSummary.Size = new System.Drawing.Size(246, 31);
            this.labelMonthSummary.TabIndex = 11;
            this.labelMonthSummary.Text = "Monthly Summary";
            this.labelMonthSummary.Visible = false;
            // 
            // panelStatistics1
            // 
            this.panelStatistics1.Controls.Add(this.labelNumberOfPosts);
            this.panelStatistics1.Controls.Add(this.labelNumberOfLikesOnPhotos);
            this.panelStatistics1.Controls.Add(this.pictureBoxLikesOnPhotos);
            this.panelStatistics1.Controls.Add(this.pictureBoxPosts);
            this.panelStatistics1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatistics1.Location = new System.Drawing.Point(0, 0);
            this.panelStatistics1.Name = "panelStatistics1";
            this.panelStatistics1.Size = new System.Drawing.Size(336, 150);
            this.panelStatistics1.TabIndex = 12;
            // 
            // labelNumberOfNewPhotos
            // 
            this.labelNumberOfNewPhotos.AutoSize = true;
            this.labelNumberOfNewPhotos.Location = new System.Drawing.Point(255, 80);
            this.labelNumberOfNewPhotos.Name = "labelNumberOfNewPhotos";
            this.labelNumberOfNewPhotos.Size = new System.Drawing.Size(0, 16);
            this.labelNumberOfNewPhotos.TabIndex = 13;
            // 
            // labelNumberOfNewAlbums
            // 
            this.labelNumberOfNewAlbums.AutoSize = true;
            this.labelNumberOfNewAlbums.Location = new System.Drawing.Point(5, 80);
            this.labelNumberOfNewAlbums.Name = "labelNumberOfNewAlbums";
            this.labelNumberOfNewAlbums.Size = new System.Drawing.Size(0, 16);
            this.labelNumberOfNewAlbums.TabIndex = 12;
            // 
            // pictureBoxNewPhotos
            // 
            this.pictureBoxNewPhotos.ErrorImage = null;
            this.pictureBoxNewPhotos.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNewPhotos.Image")));
            this.pictureBoxNewPhotos.Location = new System.Drawing.Point(250, 0);
            this.pictureBoxNewPhotos.Name = "pictureBoxNewPhotos";
            this.pictureBoxNewPhotos.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxNewPhotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxNewPhotos.TabIndex = 11;
            this.pictureBoxNewPhotos.TabStop = false;
            // 
            // pictureBoxNewAlbums
            // 
            this.pictureBoxNewAlbums.ErrorImage = null;
            this.pictureBoxNewAlbums.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNewAlbums.Image")));
            this.pictureBoxNewAlbums.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxNewAlbums.Name = "pictureBoxNewAlbums";
            this.pictureBoxNewAlbums.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxNewAlbums.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxNewAlbums.TabIndex = 10;
            this.pictureBoxNewAlbums.TabStop = false;
            // 
            // panelStatistics2
            // 
            this.panelStatistics2.Controls.Add(this.labelNumberOfNewPhotos);
            this.panelStatistics2.Controls.Add(this.pictureBoxNewAlbums);
            this.panelStatistics2.Controls.Add(this.labelNumberOfNewAlbums);
            this.panelStatistics2.Controls.Add(this.pictureBoxNewPhotos);
            this.panelStatistics2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatistics2.Location = new System.Drawing.Point(0, 157);
            this.panelStatistics2.Name = "panelStatistics2";
            this.panelStatistics2.Size = new System.Drawing.Size(336, 150);
            this.panelStatistics2.TabIndex = 14;
            // 
            // buttonShowStatistics
            // 
            this.buttonShowStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonShowStatistics.Location = new System.Drawing.Point(364, 68);
            this.buttonShowStatistics.Name = "buttonShowStatistics";
            this.buttonShowStatistics.Size = new System.Drawing.Size(131, 63);
            this.buttonShowStatistics.TabIndex = 15;
            this.buttonShowStatistics.Text = "Show Statistics";
            this.buttonShowStatistics.UseVisualStyleBackColor = true;
            this.buttonShowStatistics.Click += new System.EventHandler(this.buttonShowStatistics_Click);
            // 
            // panelSummary
            // 
            this.panelSummary.Controls.Add(this.panelStatistics2);
            this.panelSummary.Controls.Add(this.panelStatistics1);
            this.panelSummary.Location = new System.Drawing.Point(223, 225);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(336, 307);
            this.panelSummary.TabIndex = 16;
            this.panelSummary.Visible = false;
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(697, 589);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.buttonShowStatistics);
            this.Controls.Add(this.labelMonthSummary);
            this.Controls.Add(this.labelChooseMonth);
            this.Controls.Add(this.dateTimePickerChoosedMonth);
            this.Name = "FormStatistics";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikesOnPhotos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosts)).EndInit();
            this.panelStatistics1.ResumeLayout(false);
            this.panelStatistics1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewPhotos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewAlbums)).EndInit();
            this.panelStatistics2.ResumeLayout(false);
            this.panelStatistics2.PerformLayout();
            this.panelSummary.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerChoosedMonth;
        private System.Windows.Forms.Label labelChooseMonth;
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