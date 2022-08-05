namespace BasicFacebookFeatures.Forms
{
    partial class FormMostPopularFeed
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
            this.labelChooseYear = new System.Windows.Forms.Label();
            this.dateTimePickerChoosedYear = new System.Windows.Forms.DateTimePicker();
            this.panelMostPopular = new System.Windows.Forms.Panel();
            this.panelPhoto = new System.Windows.Forms.Panel();
            this.pictureBoxMostPopularPhoto = new System.Windows.Forms.PictureBox();
            this.labelMostPopularPhoto = new System.Windows.Forms.Label();
            this.panelPost = new System.Windows.Forms.Panel();
            this.listBoxMostPopularPost = new System.Windows.Forms.ListBox();
            this.labelMostPopularPost = new System.Windows.Forms.Label();
            this.panelMostPopular.SuspendLayout();
            this.panelPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostPopularPhoto)).BeginInit();
            this.panelPost.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShowMostPopularFeed
            // 
            this.buttonShowMostPopularFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonShowMostPopularFeed.Location = new System.Drawing.Point(372, 74);
            this.buttonShowMostPopularFeed.Name = "buttonShowMostPopularFeed";
            this.buttonShowMostPopularFeed.Size = new System.Drawing.Size(174, 95);
            this.buttonShowMostPopularFeed.TabIndex = 18;
            this.buttonShowMostPopularFeed.Text = "Show Most Popular Feed";
            this.buttonShowMostPopularFeed.UseVisualStyleBackColor = true;
            this.buttonShowMostPopularFeed.Click += new System.EventHandler(this.buttonShowPhotosAndPosts_Click);
            // 
            // labelChooseYear
            // 
            this.labelChooseYear.AutoSize = true;
            this.labelChooseYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelChooseYear.Location = new System.Drawing.Point(110, 48);
            this.labelChooseYear.Name = "labelChooseYear";
            this.labelChooseYear.Size = new System.Drawing.Size(180, 20);
            this.labelChooseYear.TabIndex = 17;
            this.labelChooseYear.Text = "Please choose a year";
            // 
            // dateTimePickerChoosedYear
            // 
            this.dateTimePickerChoosedYear.AllowDrop = true;
            this.dateTimePickerChoosedYear.CustomFormat = "yyyy";
            this.dateTimePickerChoosedYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerChoosedYear.Location = new System.Drawing.Point(372, 46);
            this.dateTimePickerChoosedYear.Name = "dateTimePickerChoosedYear";
            this.dateTimePickerChoosedYear.ShowUpDown = true;
            this.dateTimePickerChoosedYear.Size = new System.Drawing.Size(174, 22);
            this.dateTimePickerChoosedYear.TabIndex = 16;
            // 
            // panelMostPopular
            // 
            this.panelMostPopular.Controls.Add(this.panelPhoto);
            this.panelMostPopular.Controls.Add(this.panelPost);
            this.panelMostPopular.Location = new System.Drawing.Point(210, 208);
            this.panelMostPopular.Name = "panelMostPopular";
            this.panelMostPopular.Size = new System.Drawing.Size(336, 307);
            this.panelMostPopular.TabIndex = 19;
            this.panelMostPopular.Visible = false;
            // 
            // panelPhoto
            // 
            this.panelPhoto.Controls.Add(this.pictureBoxMostPopularPhoto);
            this.panelPhoto.Controls.Add(this.labelMostPopularPhoto);
            this.panelPhoto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPhoto.Location = new System.Drawing.Point(0, 157);
            this.panelPhoto.Name = "panelPhoto";
            this.panelPhoto.Size = new System.Drawing.Size(336, 150);
            this.panelPhoto.TabIndex = 14;
            // 
            // pictureBoxMostPopularPhoto
            // 
            this.pictureBoxMostPopularPhoto.ErrorImage = null;
            this.pictureBoxMostPopularPhoto.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMostPopularPhoto.Name = "pictureBoxMostPopularPhoto";
            this.pictureBoxMostPopularPhoto.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxMostPopularPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMostPopularPhoto.TabIndex = 10;
            this.pictureBoxMostPopularPhoto.TabStop = false;
            // 
            // labelMostPopularPhoto
            // 
            this.labelMostPopularPhoto.AutoSize = true;
            this.labelMostPopularPhoto.Location = new System.Drawing.Point(5, 80);
            this.labelMostPopularPhoto.Name = "labelMostPopularPhoto";
            this.labelMostPopularPhoto.Size = new System.Drawing.Size(0, 16);
            this.labelMostPopularPhoto.TabIndex = 12;
            // 
            // panelPost
            // 
            this.panelPost.Controls.Add(this.labelMostPopularPost);
            this.panelPost.Controls.Add(this.listBoxMostPopularPost);
            this.panelPost.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPost.Location = new System.Drawing.Point(0, 0);
            this.panelPost.Name = "panelPost";
            this.panelPost.Size = new System.Drawing.Size(336, 150);
            this.panelPost.TabIndex = 12;
            // 
            // listBoxMostPopularPost
            // 
            this.listBoxMostPopularPost.FormattingEnabled = true;
            this.listBoxMostPopularPost.ItemHeight = 16;
            this.listBoxMostPopularPost.Location = new System.Drawing.Point(0, 0);
            this.listBoxMostPopularPost.Name = "listBoxMostPopularPost";
            this.listBoxMostPopularPost.Size = new System.Drawing.Size(336, 68);
            this.listBoxMostPopularPost.TabIndex = 0;
            // 
            // labelMostPopularPost
            // 
            this.labelMostPopularPost.AutoSize = true;
            this.labelMostPopularPost.Location = new System.Drawing.Point(8, 75);
            this.labelMostPopularPost.Name = "labelMostPopularPost";
            this.labelMostPopularPost.Size = new System.Drawing.Size(0, 16);
            this.labelMostPopularPost.TabIndex = 1;
            // 
            // FormMostPopularFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.panelMostPopular);
            this.Controls.Add(this.buttonShowMostPopularFeed);
            this.Controls.Add(this.labelChooseYear);
            this.Controls.Add(this.dateTimePickerChoosedYear);
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.Label labelChooseYear;
        private System.Windows.Forms.DateTimePicker dateTimePickerChoosedYear;
        private System.Windows.Forms.Panel panelMostPopular;
        private System.Windows.Forms.Panel panelPhoto;
        private System.Windows.Forms.PictureBox pictureBoxMostPopularPhoto;
        private System.Windows.Forms.Label labelMostPopularPhoto;
        private System.Windows.Forms.Panel panelPost;
        private System.Windows.Forms.Label labelMostPopularPost;
        private System.Windows.Forms.ListBox listBoxMostPopularPost;
    }
}