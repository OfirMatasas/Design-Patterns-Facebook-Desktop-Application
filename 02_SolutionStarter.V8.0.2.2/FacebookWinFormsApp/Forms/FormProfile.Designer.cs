namespace BasicFacebookFeatures.Forms
{
    partial class FormProfile
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(481, 176);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(320, 302);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxProfilePicture.TabIndex = 0;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // pictureBoxCoverPicture
            // 
            this.pictureBoxCoverPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCoverPicture.Location = new System.Drawing.Point(180, 53);
            this.pictureBoxCoverPicture.Name = "pictureBoxCoverPicture";
            this.pictureBoxCoverPicture.Size = new System.Drawing.Size(936, 258);
            this.pictureBoxCoverPicture.TabIndex = 1;
            this.pictureBoxCoverPicture.TabStop = false;
            // 
            // labelProfileName
            // 
            this.labelProfileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProfileName.AutoSize = true;
            this.labelProfileName.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfileName.Location = new System.Drawing.Point(617, 638);
            this.labelProfileName.Name = "labelProfileName";
            this.labelProfileName.Size = new System.Drawing.Size(401, 59);
            this.labelProfileName.TabIndex = 2;
            this.labelProfileName.Text = "Firstname Lastname";
            this.labelProfileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 1029);
            this.Controls.Add(this.labelProfileName);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.Controls.Add(this.pictureBoxCoverPicture);
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
    }
}