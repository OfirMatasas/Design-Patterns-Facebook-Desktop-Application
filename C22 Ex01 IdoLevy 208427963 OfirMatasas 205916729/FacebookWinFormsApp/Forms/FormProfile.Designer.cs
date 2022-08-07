namespace FaceBookWinFormsApp.Forms
{
    internal partial class FormProfile
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
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoverPicture = new System.Windows.Forms.PictureBox();
            this.labelProfileName = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelFriendsCount = new System.Windows.Forms.Label();
            this.labelHometown = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelWallPosts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(238, 132);
            this.pictureBoxProfilePicture.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(160, 183);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilePicture.TabIndex = 0;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // pictureBoxCoverPicture
            // 
            this.pictureBoxCoverPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCoverPicture.Location = new System.Drawing.Point(33, 12);
            this.pictureBoxCoverPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoverPicture.Name = "pictureBoxCoverPicture";
            this.pictureBoxCoverPicture.Size = new System.Drawing.Size(576, 185);
            this.pictureBoxCoverPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoverPicture.TabIndex = 1;
            this.pictureBoxCoverPicture.TabStop = false;
            // 
            // labelProfileName
            // 
            this.labelProfileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProfileName.AutoSize = true;
            this.labelProfileName.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfileName.Location = new System.Drawing.Point(215, 336);
            this.labelProfileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProfileName.Name = "labelProfileName";
            this.labelProfileName.Size = new System.Drawing.Size(204, 30);
            this.labelProfileName.TabIndex = 2;
            this.labelProfileName.Text = "Firstname Lastname";
            this.labelProfileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBirthday
            // 
            this.labelBirthday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthday.Location = new System.Drawing.Point(89, 404);
            this.labelBirthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(104, 30);
            this.labelBirthday.TabIndex = 3;
            this.labelBirthday.Text = "Birthday: ";
            this.labelBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLocation
            // 
            this.labelLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(372, 442);
            this.labelLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(105, 30);
            this.labelLocation.TabIndex = 4;
            this.labelLocation.Text = "Location: ";
            this.labelLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFriendsCount
            // 
            this.labelFriendsCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFriendsCount.AutoSize = true;
            this.labelFriendsCount.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsCount.Location = new System.Drawing.Point(89, 481);
            this.labelFriendsCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFriendsCount.Name = "labelFriendsCount";
            this.labelFriendsCount.Size = new System.Drawing.Size(94, 30);
            this.labelFriendsCount.TabIndex = 5;
            this.labelFriendsCount.Text = "Friends: ";
            this.labelFriendsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHometown
            // 
            this.labelHometown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHometown.AutoSize = true;
            this.labelHometown.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHometown.Location = new System.Drawing.Point(372, 404);
            this.labelHometown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHometown.Name = "labelHometown";
            this.labelHometown.Size = new System.Drawing.Size(132, 30);
            this.labelHometown.TabIndex = 6;
            this.labelHometown.Text = "Hometown: ";
            this.labelHometown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGender
            // 
            this.labelGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(89, 442);
            this.labelGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(96, 30);
            this.labelGender.TabIndex = 7;
            this.labelGender.Text = "Gender: ";
            this.labelGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWallPosts
            // 
            this.labelWallPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWallPosts.AutoSize = true;
            this.labelWallPosts.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWallPosts.Location = new System.Drawing.Point(372, 481);
            this.labelWallPosts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWallPosts.Name = "labelWallPosts";
            this.labelWallPosts.Size = new System.Drawing.Size(120, 30);
            this.labelWallPosts.TabIndex = 8;
            this.labelWallPosts.Text = "Wall Posts: ";
            this.labelWallPosts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 535);
            this.Controls.Add(this.labelWallPosts);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelHometown);
            this.Controls.Add(this.labelFriendsCount);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelProfileName);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.Controls.Add(this.pictureBoxCoverPicture);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormProfile";
            this.Text = "FormProfile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.PictureBox pictureBoxCoverPicture;
        private System.Windows.Forms.Label labelProfileName;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelFriendsCount;
        private System.Windows.Forms.Label labelHometown;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelWallPosts;
    }
}