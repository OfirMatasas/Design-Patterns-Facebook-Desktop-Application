namespace FacebookWinFormsApp.Forms
{
    internal partial class FormFavoriteTeams
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
            this.labelTeamInformation = new System.Windows.Forms.Label();
            this.labelFavoriteTeams = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedFavoriteTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFavoriteTeams
            // 
            this.listBoxFavoriteTeams.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxFavoriteTeams.FormattingEnabled = true;
            this.listBoxFavoriteTeams.ItemHeight = 28;
            this.listBoxFavoriteTeams.Location = new System.Drawing.Point(44, 108);
            this.listBoxFavoriteTeams.Name = "listBoxFavoriteTeams";
            this.listBoxFavoriteTeams.Size = new System.Drawing.Size(221, 452);
            this.listBoxFavoriteTeams.TabIndex = 0;
            this.listBoxFavoriteTeams.SelectedIndexChanged += new System.EventHandler(this.listBoxFavoriteTeams_SelectedIndexChanged);
            // 
            // pictureBoxSelectedFavoriteTeam
            // 
            this.pictureBoxSelectedFavoriteTeam.Location = new System.Drawing.Point(353, 399);
            this.pictureBoxSelectedFavoriteTeam.Name = "pictureBoxSelectedFavoriteTeam";
            this.pictureBoxSelectedFavoriteTeam.Size = new System.Drawing.Size(186, 150);
            this.pictureBoxSelectedFavoriteTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelectedFavoriteTeam.TabIndex = 1;
            this.pictureBoxSelectedFavoriteTeam.TabStop = false;
            // 
            // richTextBoxSelectedTeamInfo
            // 
            this.richTextBoxSelectedTeamInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.richTextBoxSelectedTeamInfo.Location = new System.Drawing.Point(304, 143);
            this.richTextBoxSelectedTeamInfo.Name = "richTextBoxSelectedTeamInfo";
            this.richTextBoxSelectedTeamInfo.Size = new System.Drawing.Size(278, 250);
            this.richTextBoxSelectedTeamInfo.TabIndex = 2;
            this.richTextBoxSelectedTeamInfo.Text = "";
            this.richTextBoxSelectedTeamInfo.Visible = false;
            // 
            // labelTeamInformation
            // 
            this.labelTeamInformation.AutoSize = true;
            this.labelTeamInformation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTeamInformation.Location = new System.Drawing.Point(414, 108);
            this.labelTeamInformation.Name = "labelTeamInformation";
            this.labelTeamInformation.Size = new System.Drawing.Size(209, 32);
            this.labelTeamInformation.TabIndex = 13;
            this.labelTeamInformation.Text = "Team Information";
            this.labelTeamInformation.Visible = false;
            // 
            // labelFavoriteTeams
            // 
            this.labelFavoriteTeams.AutoSize = true;
            this.labelFavoriteTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFavoriteTeams.Location = new System.Drawing.Point(154, 20);
            this.labelFavoriteTeams.Name = "labelFavoriteTeams";
            this.labelFavoriteTeams.Size = new System.Drawing.Size(309, 46);
            this.labelFavoriteTeams.TabIndex = 14;
            this.labelFavoriteTeams.Text = "Favorite Teams";
            // 
            // FormFavoriteTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 840);
            this.Controls.Add(this.labelFavoriteTeams);
            this.Controls.Add(this.labelTeamInformation);
            this.Controls.Add(this.richTextBoxSelectedTeamInfo);
            this.Controls.Add(this.pictureBoxSelectedFavoriteTeam);
            this.Controls.Add(this.listBoxFavoriteTeams);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)), true);
            this.Name = "FormFavoriteTeams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Favorite Teams";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedFavoriteTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFavoriteTeams;
        private System.Windows.Forms.PictureBox pictureBoxSelectedFavoriteTeam;
        private System.Windows.Forms.RichTextBox richTextBoxSelectedTeamInfo;
        private System.Windows.Forms.Label labelTeamInformation;
        private System.Windows.Forms.Label labelFavoriteTeams;
    }
}