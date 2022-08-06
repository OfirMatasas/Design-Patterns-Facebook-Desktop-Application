namespace BasicFacebookFeatures.Forms
{
    partial class FormFriends
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
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.pictureBoxFriendProfilePicture = new System.Windows.Forms.PictureBox();
            this.richTextBoxFriendAbout = new System.Windows.Forms.RichTextBox();
            this.labelFriendProfilePicture = new System.Windows.Forms.Label();
            this.labelFriendAbout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(93, 79);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(225, 388);
            this.listBoxFriends.TabIndex = 5;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // pictureBoxFriendProfilePicture
            // 
            this.pictureBoxFriendProfilePicture.Location = new System.Drawing.Point(455, 140);
            this.pictureBoxFriendProfilePicture.Name = "pictureBoxFriendProfilePicture";
            this.pictureBoxFriendProfilePicture.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxFriendProfilePicture.TabIndex = 6;
            this.pictureBoxFriendProfilePicture.TabStop = false;
            // 
            // richTextBoxFriendAbout
            // 
            this.richTextBoxFriendAbout.Location = new System.Drawing.Point(354, 313);
            this.richTextBoxFriendAbout.Name = "richTextBoxFriendAbout";
            this.richTextBoxFriendAbout.Size = new System.Drawing.Size(297, 154);
            this.richTextBoxFriendAbout.TabIndex = 7;
            this.richTextBoxFriendAbout.Text = "";
            // 
            // labelFriendProfilePicture
            // 
            this.labelFriendProfilePicture.AutoSize = true;
            this.labelFriendProfilePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendProfilePicture.Location = new System.Drawing.Point(448, 98);
            this.labelFriendProfilePicture.Name = "labelFriendProfilePicture";
            this.labelFriendProfilePicture.Size = new System.Drawing.Size(121, 20);
            this.labelFriendProfilePicture.TabIndex = 8;
            this.labelFriendProfilePicture.Text = "Profile Picture";
            // 
            // labelFriendAbout
            // 
            this.labelFriendAbout.AutoSize = true;
            this.labelFriendAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendAbout.Location = new System.Drawing.Point(478, 273);
            this.labelFriendAbout.Name = "labelFriendAbout";
            this.labelFriendAbout.Size = new System.Drawing.Size(57, 20);
            this.labelFriendAbout.TabIndex = 9;
            this.labelFriendAbout.Text = "About";
            // 
            // FormFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 632);
            this.Controls.Add(this.labelFriendAbout);
            this.Controls.Add(this.labelFriendProfilePicture);
            this.Controls.Add(this.richTextBoxFriendAbout);
            this.Controls.Add(this.pictureBoxFriendProfilePicture);
            this.Controls.Add(this.listBoxFriends);
            this.Name = "FormFriends";
            this.Text = "FormFriends";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.PictureBox pictureBoxFriendProfilePicture;
        private System.Windows.Forms.RichTextBox richTextBoxFriendAbout;
        private System.Windows.Forms.Label labelFriendProfilePicture;
        private System.Windows.Forms.Label labelFriendAbout;
    }
}