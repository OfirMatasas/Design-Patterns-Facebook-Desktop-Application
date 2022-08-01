namespace BasicFacebookFeatures
{
    partial class FormFavoriteTeams
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
            this.listBoxFavoriteTeams = new System.Windows.Forms.ListBox();
            this.pictureBoxSelectedFavoriteTeam = new System.Windows.Forms.PictureBox();
            this.richTextBoxSelectedTeamInfo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedFavoriteTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFavoriteTeams
            // 
            this.listBoxFavoriteTeams.FormattingEnabled = true;
            this.listBoxFavoriteTeams.ItemHeight = 45;
            this.listBoxFavoriteTeams.Location = new System.Drawing.Point(26, 36);
            this.listBoxFavoriteTeams.Name = "listBoxFavoriteTeams";
            this.listBoxFavoriteTeams.Size = new System.Drawing.Size(159, 229);
            this.listBoxFavoriteTeams.TabIndex = 0;
            this.listBoxFavoriteTeams.SelectedIndexChanged += new System.EventHandler(this.listBoxFavoriteTeams_SelectedIndexChanged);
            // 
            // pictureBoxSelectedFavoriteTeam
            // 
            this.pictureBoxSelectedFavoriteTeam.Location = new System.Drawing.Point(26, 286);
            this.pictureBoxSelectedFavoriteTeam.Name = "pictureBoxSelectedFavoriteTeam";
            this.pictureBoxSelectedFavoriteTeam.Size = new System.Drawing.Size(159, 150);
            this.pictureBoxSelectedFavoriteTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelectedFavoriteTeam.TabIndex = 1;
            this.pictureBoxSelectedFavoriteTeam.TabStop = false;
            // 
            // richTextBoxSelectedTeamInfo
            // 
            this.richTextBoxSelectedTeamInfo.Location = new System.Drawing.Point(227, 36);
            this.richTextBoxSelectedTeamInfo.Name = "richTextBoxSelectedTeamInfo";
            this.richTextBoxSelectedTeamInfo.Size = new System.Drawing.Size(278, 400);
            this.richTextBoxSelectedTeamInfo.TabIndex = 2;
            this.richTextBoxSelectedTeamInfo.Text = "";
            this.richTextBoxSelectedTeamInfo.Visible = false;
            // 
            // FormFavoriteTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1074, 929);
            this.Controls.Add(this.richTextBoxSelectedTeamInfo);
            this.Controls.Add(this.pictureBoxSelectedFavoriteTeam);
            this.Controls.Add(this.listBoxFavoriteTeams);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)), true);
            this.Name = "FormFavoriteTeams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Favorite Teams";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedFavoriteTeam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFavoriteTeams;
        private System.Windows.Forms.PictureBox pictureBoxSelectedFavoriteTeam;
        private System.Windows.Forms.RichTextBox richTextBoxSelectedTeamInfo;
    }
}