namespace FaceBookWinFormsApp.Forms
{
    internal partial class FormMostPopularFeed
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
            this.buttonShowMostPopularFeed = new System.Windows.Forms.Button();
            this.labelChooseDate = new System.Windows.Forms.Label();
            this.dateTimePickerChosenDate = new System.Windows.Forms.DateTimePicker();
            this.panelMostPopular = new System.Windows.Forms.Panel();
            this.panelPhoto = new System.Windows.Forms.Panel();
            this.labelMostPopularPhotoDate = new System.Windows.Forms.Label();
            this.pictureBoxMostPopularPhoto = new System.Windows.Forms.PictureBox();
            this.labelMostPopularPhotoCommentsNumber = new System.Windows.Forms.Label();
            this.panelPost = new System.Windows.Forms.Panel();
            this.labelMostPopularPostDate = new System.Windows.Forms.Label();
            this.labelMostPopularPostCommentsNumber = new System.Windows.Forms.Label();
            this.listBoxMostPopularPost = new System.Windows.Forms.ListBox();
            this.labelMostPopularFeed = new System.Windows.Forms.Label();
            this.panelMostPopular.SuspendLayout();
            this.panelPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostPopularPhoto)).BeginInit();
            this.panelPost.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShowMostPopularFeed
            // 
            this.buttonShowMostPopularFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonShowMostPopularFeed.Location = new System.Drawing.Point(558, 115);
            this.buttonShowMostPopularFeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonShowMostPopularFeed.Name = "buttonShowMostPopularFeed";
            this.buttonShowMostPopularFeed.Size = new System.Drawing.Size(260, 148);
            this.buttonShowMostPopularFeed.TabIndex = 18;
            this.buttonShowMostPopularFeed.Text = "Show Most Popular Feed";
            this.buttonShowMostPopularFeed.UseVisualStyleBackColor = true;
            this.buttonShowMostPopularFeed.Click += new System.EventHandler(this.buttonShowPhotosAndPosts_Click);
            // 
            // labelChooseDate
            // 
            this.labelChooseDate.AutoSize = true;
            this.labelChooseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelChooseDate.Location = new System.Drawing.Point(166, 67);
            this.labelChooseDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChooseDate.Name = "labelChooseDate";
            this.labelChooseDate.Size = new System.Drawing.Size(342, 37);
            this.labelChooseDate.TabIndex = 17;
            this.labelChooseDate.Text = "Please choose a year";
            // 
            // dateTimePickerChosenDate
            // 
            this.dateTimePickerChosenDate.AllowDrop = true;
            this.dateTimePickerChosenDate.CustomFormat = "yyyy";
            this.dateTimePickerChosenDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerChosenDate.Location = new System.Drawing.Point(558, 71);
            this.dateTimePickerChosenDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerChosenDate.Name = "dateTimePickerChosenDate";
            this.dateTimePickerChosenDate.ShowUpDown = true;
            this.dateTimePickerChosenDate.Size = new System.Drawing.Size(260, 31);
            this.dateTimePickerChosenDate.TabIndex = 16;
            // 
            // panelMostPopular
            // 
            this.panelMostPopular.Controls.Add(this.panelPhoto);
            this.panelMostPopular.Controls.Add(this.panelPost);
            this.panelMostPopular.Location = new System.Drawing.Point(252, 427);
            this.panelMostPopular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMostPopular.Name = "panelMostPopular";
            this.panelMostPopular.Size = new System.Drawing.Size(568, 479);
            this.panelMostPopular.TabIndex = 19;
            this.panelMostPopular.Visible = false;
            // 
            // panelPhoto
            // 
            this.panelPhoto.Controls.Add(this.labelMostPopularPhotoDate);
            this.panelPhoto.Controls.Add(this.pictureBoxMostPopularPhoto);
            this.panelPhoto.Controls.Add(this.labelMostPopularPhotoCommentsNumber);
            this.panelPhoto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPhoto.Location = new System.Drawing.Point(0, 244);
            this.panelPhoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPhoto.Name = "panelPhoto";
            this.panelPhoto.Size = new System.Drawing.Size(568, 235);
            this.panelPhoto.TabIndex = 14;
            // 
            // labelMostPopularPhotoDate
            // 
            this.labelMostPopularPhotoDate.AutoSize = true;
            this.labelMostPopularPhotoDate.Location = new System.Drawing.Point(12, 188);
            this.labelMostPopularPhotoDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMostPopularPhotoDate.Name = "labelMostPopularPhotoDate";
            this.labelMostPopularPhotoDate.Size = new System.Drawing.Size(0, 25);
            this.labelMostPopularPhotoDate.TabIndex = 13;
            // 
            // pictureBoxMostPopularPhoto
            // 
            this.pictureBoxMostPopularPhoto.BackColor = System.Drawing.Color.White;
            this.pictureBoxMostPopularPhoto.ErrorImage = null;
            this.pictureBoxMostPopularPhoto.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMostPopularPhoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxMostPopularPhoto.Name = "pictureBoxMostPopularPhoto";
            this.pictureBoxMostPopularPhoto.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxMostPopularPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMostPopularPhoto.TabIndex = 10;
            this.pictureBoxMostPopularPhoto.TabStop = false;
            // 
            // labelMostPopularPhotoCommentsNumber
            // 
            this.labelMostPopularPhotoCommentsNumber.AutoSize = true;
            this.labelMostPopularPhotoCommentsNumber.Location = new System.Drawing.Point(12, 140);
            this.labelMostPopularPhotoCommentsNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMostPopularPhotoCommentsNumber.Name = "labelMostPopularPhotoCommentsNumber";
            this.labelMostPopularPhotoCommentsNumber.Size = new System.Drawing.Size(0, 25);
            this.labelMostPopularPhotoCommentsNumber.TabIndex = 12;
            // 
            // panelPost
            // 
            this.panelPost.Controls.Add(this.labelMostPopularPostDate);
            this.panelPost.Controls.Add(this.labelMostPopularPostCommentsNumber);
            this.panelPost.Controls.Add(this.listBoxMostPopularPost);
            this.panelPost.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPost.Location = new System.Drawing.Point(0, 0);
            this.panelPost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPost.Name = "panelPost";
            this.panelPost.Size = new System.Drawing.Size(568, 235);
            this.panelPost.TabIndex = 12;
            // 
            // labelMostPopularPostDate
            // 
            this.labelMostPopularPostDate.AutoSize = true;
            this.labelMostPopularPostDate.Location = new System.Drawing.Point(12, 163);
            this.labelMostPopularPostDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMostPopularPostDate.Name = "labelMostPopularPostDate";
            this.labelMostPopularPostDate.Size = new System.Drawing.Size(0, 25);
            this.labelMostPopularPostDate.TabIndex = 2;
            // 
            // labelMostPopularPostCommentsNumber
            // 
            this.labelMostPopularPostCommentsNumber.AutoSize = true;
            this.labelMostPopularPostCommentsNumber.Location = new System.Drawing.Point(12, 117);
            this.labelMostPopularPostCommentsNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMostPopularPostCommentsNumber.Name = "labelMostPopularPostCommentsNumber";
            this.labelMostPopularPostCommentsNumber.Size = new System.Drawing.Size(0, 25);
            this.labelMostPopularPostCommentsNumber.TabIndex = 1;
            // 
            // listBoxMostPopularPost
            // 
            this.listBoxMostPopularPost.FormattingEnabled = true;
            this.listBoxMostPopularPost.ItemHeight = 25;
            this.listBoxMostPopularPost.Location = new System.Drawing.Point(0, 0);
            this.listBoxMostPopularPost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxMostPopularPost.Name = "listBoxMostPopularPost";
            this.listBoxMostPopularPost.Size = new System.Drawing.Size(502, 104);
            this.listBoxMostPopularPost.TabIndex = 0;
            // 
            // labelMostPopularFeed
            // 
            this.labelMostPopularFeed.AutoSize = true;
            this.labelMostPopularFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMostPopularFeed.Location = new System.Drawing.Point(276, 342);
            this.labelMostPopularFeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMostPopularFeed.Name = "labelMostPopularFeed";
            this.labelMostPopularFeed.Size = new System.Drawing.Size(499, 63);
            this.labelMostPopularFeed.TabIndex = 20;
            this.labelMostPopularFeed.Text = "Most Popular Feed";
            this.labelMostPopularFeed.Visible = false;
            // 
            // FormMostPopularFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 988);
            this.Controls.Add(this.labelMostPopularFeed);
            this.Controls.Add(this.panelMostPopular);
            this.Controls.Add(this.buttonShowMostPopularFeed);
            this.Controls.Add(this.labelChooseDate);
            this.Controls.Add(this.dateTimePickerChosenDate);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMostPopularFeed";
            this.Text = "FormMostPopularFeed";
            this.panelMostPopular.ResumeLayout(false);
            this.panelPhoto.ResumeLayout(false);
            this.panelPhoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostPopularPhoto)).EndInit();
            this.panelPost.ResumeLayout(false);
            this.panelPost.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowMostPopularFeed;
        private System.Windows.Forms.Label labelChooseDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerChosenDate;
        private System.Windows.Forms.Panel panelMostPopular;
        private System.Windows.Forms.Panel panelPhoto;
        private System.Windows.Forms.PictureBox pictureBoxMostPopularPhoto;
        private System.Windows.Forms.Label labelMostPopularPhotoCommentsNumber;
        private System.Windows.Forms.Panel panelPost;
        private System.Windows.Forms.Label labelMostPopularPostCommentsNumber;
        private System.Windows.Forms.ListBox listBoxMostPopularPost;
        private System.Windows.Forms.Label labelMostPopularPostDate;
        private System.Windows.Forms.Label labelMostPopularPhotoDate;
        private System.Windows.Forms.Label labelMostPopularFeed;
    }
}