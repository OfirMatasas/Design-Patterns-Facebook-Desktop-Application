namespace FaceBookWinFormsApp.Forms
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
            this.labelFriendProfilePicture = new System.Windows.Forms.Label();
            this.labelFriendAbout = new System.Windows.Forms.Label();
            this.labelFriends = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 25;
            this.listBoxFriends.Location = new System.Drawing.Point(138, 139);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(336, 604);
            this.listBoxFriends.TabIndex = 5;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // pictureBoxFriendProfilePicture
            // 
            this.pictureBoxFriendProfilePicture.Location = new System.Drawing.Point(681, 234);
            this.pictureBoxFriendProfilePicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxFriendProfilePicture.Name = "pictureBoxFriendProfilePicture";
            this.pictureBoxFriendProfilePicture.Size = new System.Drawing.Size(150, 156);
            this.pictureBoxFriendProfilePicture.TabIndex = 6;
            this.pictureBoxFriendProfilePicture.TabStop = false;
            // 
            // richTextBoxFriendAbout
            // 
            this.richTextBoxFriendAbout.Location = new System.Drawing.Point(530, 505);
            this.richTextBoxFriendAbout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxFriendAbout.Name = "richTextBoxFriendAbout";
            this.richTextBoxFriendAbout.Size = new System.Drawing.Size(444, 238);
            this.richTextBoxFriendAbout.TabIndex = 7;
            this.richTextBoxFriendAbout.Text = "";
            this.richTextBoxFriendAbout.Visible = false;
            // 
            // labelFriendProfilePicture
            // 
            this.labelFriendProfilePicture.AutoSize = true;
            this.labelFriendProfilePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendProfilePicture.Location = new System.Drawing.Point(670, 169);
            this.labelFriendProfilePicture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFriendProfilePicture.Name = "labelFriendProfilePicture";
            this.labelFriendProfilePicture.Size = new System.Drawing.Size(230, 37);
            this.labelFriendProfilePicture.TabIndex = 8;
            this.labelFriendProfilePicture.Text = "Profile Picture";
            this.labelFriendProfilePicture.Visible = false;
            // 
            // labelFriendAbout
            // 
            this.labelFriendAbout.AutoSize = true;
            this.labelFriendAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendAbout.Location = new System.Drawing.Point(716, 442);
            this.labelFriendAbout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFriendAbout.Name = "labelFriendAbout";
            this.labelFriendAbout.Size = new System.Drawing.Size(107, 37);
            this.labelFriendAbout.TabIndex = 9;
            this.labelFriendAbout.Text = "About";
            this.labelFriendAbout.Visible = false;
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriends.Location = new System.Drawing.Point(238, 80);
            this.labelFriends.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(153, 44);
            this.labelFriends.TabIndex = 11;
            this.labelFriends.Text = "Friends";
            // 
            // FormFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1314, 988);
            this.Controls.Add(this.labelFriends);
            this.Controls.Add(this.labelFriendAbout);
            this.Controls.Add(this.labelFriendProfilePicture);
            this.Controls.Add(this.richTextBoxFriendAbout);
            this.Controls.Add(this.pictureBoxFriendProfilePicture);
            this.Controls.Add(this.listBoxFriends);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Label labelFriends;
    }
}