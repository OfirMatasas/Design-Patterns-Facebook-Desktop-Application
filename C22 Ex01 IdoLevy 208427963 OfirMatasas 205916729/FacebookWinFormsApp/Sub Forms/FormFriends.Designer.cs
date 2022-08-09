namespace FacebookWinFormsApp.Forms
{
    internal partial class FormFriends
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
            this.labelFriendsInformation = new System.Windows.Forms.Label();
            this.labelFriends = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 21;
            this.listBoxFriends.Location = new System.Drawing.Point(44, 102);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(276, 571);
            this.listBoxFriends.TabIndex = 5;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // pictureBoxFriendProfilePicture
            // 
            this.pictureBoxFriendProfilePicture.Location = new System.Drawing.Point(424, 152);
            this.pictureBoxFriendProfilePicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxFriendProfilePicture.Name = "pictureBoxFriendProfilePicture";
            this.pictureBoxFriendProfilePicture.Size = new System.Drawing.Size(176, 178);
            this.pictureBoxFriendProfilePicture.TabIndex = 6;
            this.pictureBoxFriendProfilePicture.TabStop = false;
            // 
            // richTextBoxFriendAbout
            // 
            this.richTextBoxFriendAbout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxFriendAbout.Location = new System.Drawing.Point(350, 395);
            this.richTextBoxFriendAbout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxFriendAbout.Name = "richTextBoxFriendAbout";
            this.richTextBoxFriendAbout.Size = new System.Drawing.Size(322, 191);
            this.richTextBoxFriendAbout.TabIndex = 7;
            this.richTextBoxFriendAbout.Text = "";
            this.richTextBoxFriendAbout.Visible = false;
            // 
            // labelFriendsInformation
            // 
            this.labelFriendsInformation.AutoSize = true;
            this.labelFriendsInformation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendsInformation.Location = new System.Drawing.Point(432, 358);
            this.labelFriendsInformation.Name = "labelFriendsInformation";
            this.labelFriendsInformation.Size = new System.Drawing.Size(172, 32);
            this.labelFriendsInformation.TabIndex = 9;
            this.labelFriendsInformation.Text = "Friend\'s About";
            this.labelFriendsInformation.Visible = false;
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriends.Location = new System.Drawing.Point(286, 9);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(159, 46);
            this.labelFriends.TabIndex = 15;
            this.labelFriends.Text = "Friends";
            // 
            // FormFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 790);
            this.Controls.Add(this.labelFriends);
            this.Controls.Add(this.labelFriendsInformation);
            this.Controls.Add(this.richTextBoxFriendAbout);
            this.Controls.Add(this.pictureBoxFriendProfilePicture);
            this.Controls.Add(this.listBoxFriends);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Label labelFriendsInformation;
        private System.Windows.Forms.Label labelFriends;
    }
}