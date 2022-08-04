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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNumberOfLikesOnPhotos = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelNumberOfPosts = new System.Windows.Forms.Label();
            this.labelMonthSummary = new System.Windows.Forms.Label();
            this.panelStatistics = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelNumberOfNewAlbums = new System.Windows.Forms.Label();
            this.labelNumberOfNewPhotos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNumberOfPostsTaggedIn = new System.Windows.Forms.Label();
            this.labelNumberOfPostsInFavoriteTeams = new System.Windows.Forms.Label();
            this.labelNumberOfPostsInGroups = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerChoosedMonth
            // 
            this.dateTimePickerChoosedMonth.AllowDrop = true;
            this.dateTimePickerChoosedMonth.CustomFormat = "MM-yyyy";
            this.dateTimePickerChoosedMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerChoosedMonth.Location = new System.Drawing.Point(344, 34);
            this.dateTimePickerChoosedMonth.Name = "dateTimePickerChoosedMonth";
            this.dateTimePickerChoosedMonth.Size = new System.Drawing.Size(93, 22);
            this.dateTimePickerChoosedMonth.TabIndex = 1;
            this.dateTimePickerChoosedMonth.ValueChanged += new System.EventHandler(this.dateTimePickerChoosedMonth_ValueChanged);
            // 
            // labelChooseMonth
            // 
            this.labelChooseMonth.AutoSize = true;
            this.labelChooseMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelChooseMonth.Location = new System.Drawing.Point(78, 34);
            this.labelChooseMonth.Name = "labelChooseMonth";
            this.labelChooseMonth.Size = new System.Drawing.Size(196, 20);
            this.labelChooseMonth.TabIndex = 2;
            this.labelChooseMonth.Text = "Please choose a month";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // labelNumberOfLikesOnPhotos
            // 
            this.labelNumberOfLikesOnPhotos.AutoSize = true;
            this.labelNumberOfLikesOnPhotos.Location = new System.Drawing.Point(5, 75);
            this.labelNumberOfLikesOnPhotos.Name = "labelNumberOfLikesOnPhotos";
            this.labelNumberOfLikesOnPhotos.Size = new System.Drawing.Size(0, 16);
            this.labelNumberOfLikesOnPhotos.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(150, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // labelNumberOfPosts
            // 
            this.labelNumberOfPosts.AutoSize = true;
            this.labelNumberOfPosts.Location = new System.Drawing.Point(155, 75);
            this.labelNumberOfPosts.Name = "labelNumberOfPosts";
            this.labelNumberOfPosts.Size = new System.Drawing.Size(0, 16);
            this.labelNumberOfPosts.TabIndex = 10;
            // 
            // labelMonthSummary
            // 
            this.labelMonthSummary.AutoSize = true;
            this.labelMonthSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMonthSummary.Location = new System.Drawing.Point(254, 110);
            this.labelMonthSummary.Name = "labelMonthSummary";
            this.labelMonthSummary.Size = new System.Drawing.Size(246, 31);
            this.labelMonthSummary.TabIndex = 11;
            this.labelMonthSummary.Text = "Monthly Summary";
            // 
            // panelStatistics
            // 
            this.panelStatistics.Controls.Add(this.labelNumberOfNewPhotos);
            this.panelStatistics.Controls.Add(this.labelNumberOfNewAlbums);
            this.panelStatistics.Controls.Add(this.labelNumberOfPosts);
            this.panelStatistics.Controls.Add(this.labelNumberOfLikesOnPhotos);
            this.panelStatistics.Controls.Add(this.pictureBox4);
            this.panelStatistics.Controls.Add(this.pictureBox3);
            this.panelStatistics.Controls.Add(this.pictureBox1);
            this.panelStatistics.Controls.Add(this.pictureBox2);
            this.panelStatistics.Location = new System.Drawing.Point(110, 158);
            this.panelStatistics.Name = "panelStatistics";
            this.panelStatistics.Size = new System.Drawing.Size(514, 131);
            this.panelStatistics.TabIndex = 12;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(300, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.ErrorImage = null;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(450, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // labelNumberOfNewAlbums
            // 
            this.labelNumberOfNewAlbums.AutoSize = true;
            this.labelNumberOfNewAlbums.Location = new System.Drawing.Point(305, 75);
            this.labelNumberOfNewAlbums.Name = "labelNumberOfNewAlbums";
            this.labelNumberOfNewAlbums.Size = new System.Drawing.Size(0, 16);
            this.labelNumberOfNewAlbums.TabIndex = 12;
            // 
            // labelNumberOfNewPhotos
            // 
            this.labelNumberOfNewPhotos.AutoSize = true;
            this.labelNumberOfNewPhotos.Location = new System.Drawing.Point(455, 75);
            this.labelNumberOfNewPhotos.Name = "labelNumberOfNewPhotos";
            this.labelNumberOfNewPhotos.Size = new System.Drawing.Size(0, 16);
            this.labelNumberOfNewPhotos.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelNumberOfPostsTaggedIn);
            this.panel1.Controls.Add(this.labelNumberOfPostsInFavoriteTeams);
            this.panel1.Controls.Add(this.labelNumberOfPostsInGroups);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Location = new System.Drawing.Point(110, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 131);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 13;
            // 
            // labelNumberOfPostsTaggedIn
            // 
            this.labelNumberOfPostsTaggedIn.AutoSize = true;
            this.labelNumberOfPostsTaggedIn.Location = new System.Drawing.Point(305, 75);
            this.labelNumberOfPostsTaggedIn.Name = "labelNumberOfPostsTaggedIn";
            this.labelNumberOfPostsTaggedIn.Size = new System.Drawing.Size(0, 16);
            this.labelNumberOfPostsTaggedIn.TabIndex = 12;
            // 
            // labelNumberOfPostsInFavoriteTeams
            // 
            this.labelNumberOfPostsInFavoriteTeams.AutoSize = true;
            this.labelNumberOfPostsInFavoriteTeams.Location = new System.Drawing.Point(155, 75);
            this.labelNumberOfPostsInFavoriteTeams.Name = "labelNumberOfPostsInFavoriteTeams";
            this.labelNumberOfPostsInFavoriteTeams.Size = new System.Drawing.Size(0, 16);
            this.labelNumberOfPostsInFavoriteTeams.TabIndex = 10;
            // 
            // labelNumberOfPostsInGroups
            // 
            this.labelNumberOfPostsInGroups.AutoSize = true;
            this.labelNumberOfPostsInGroups.Location = new System.Drawing.Point(5, 75);
            this.labelNumberOfPostsInGroups.Name = "labelNumberOfPostsInGroups";
            this.labelNumberOfPostsInGroups.Size = new System.Drawing.Size(0, 16);
            this.labelNumberOfPostsInGroups.TabIndex = 8;
            // 
            // pictureBox5
            // 
            this.pictureBox5.ErrorImage = null;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(450, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 64);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.ErrorImage = null;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(300, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(64, 64);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.ErrorImage = null;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(64, 64);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.ErrorImage = null;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(150, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(64, 64);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 9;
            this.pictureBox8.TabStop = false;
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelStatistics);
            this.Controls.Add(this.labelMonthSummary);
            this.Controls.Add(this.labelChooseMonth);
            this.Controls.Add(this.dateTimePickerChoosedMonth);
            this.Name = "FormStatistics";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelStatistics.ResumeLayout(false);
            this.panelStatistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerChoosedMonth;
        private System.Windows.Forms.Label labelChooseMonth;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNumberOfLikesOnPhotos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelNumberOfPosts;
        private System.Windows.Forms.Label labelMonthSummary;
        private System.Windows.Forms.Panel panelStatistics;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelNumberOfNewPhotos;
        private System.Windows.Forms.Label labelNumberOfNewAlbums;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumberOfPostsTaggedIn;
        private System.Windows.Forms.Label labelNumberOfPostsInFavoriteTeams;
        private System.Windows.Forms.Label labelNumberOfPostsInGroups;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}