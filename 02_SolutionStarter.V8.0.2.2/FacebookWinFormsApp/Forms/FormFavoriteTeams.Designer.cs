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
            this.buttonFetchFavoriteTeams = new System.Windows.Forms.Button();
            this.labelFavoriteTeamSelectedPicture = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedFavoriteTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFavoriteTeams
            // 
            this.listBoxFavoriteTeams.FormattingEnabled = true;
            this.listBoxFavoriteTeams.ItemHeight = 21;
            this.listBoxFavoriteTeams.Location = new System.Drawing.Point(50, 48);
            this.listBoxFavoriteTeams.Name = "listBoxFavoriteTeams";
            this.listBoxFavoriteTeams.Size = new System.Drawing.Size(349, 403);
            this.listBoxFavoriteTeams.TabIndex = 0;
            this.listBoxFavoriteTeams.SelectedIndexChanged += new System.EventHandler(this.listBoxFavoriteTeams_SelectedIndexChanged);
            // 
            // pictureBoxSelectedFavoriteTeam
            // 
            this.pictureBoxSelectedFavoriteTeam.Location = new System.Drawing.Point(473, 87);
            this.pictureBoxSelectedFavoriteTeam.Name = "pictureBoxSelectedFavoriteTeam";
            this.pictureBoxSelectedFavoriteTeam.Size = new System.Drawing.Size(130, 130);
            this.pictureBoxSelectedFavoriteTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxSelectedFavoriteTeam.TabIndex = 1;
            this.pictureBoxSelectedFavoriteTeam.TabStop = false;
            // 
            // buttonFetchFavoriteTeams
            // 
            this.buttonFetchFavoriteTeams.AutoSize = true;
            this.buttonFetchFavoriteTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchFavoriteTeams.Location = new System.Drawing.Point(50, 12);
            this.buttonFetchFavoriteTeams.Name = "buttonFetchFavoriteTeams";
            this.buttonFetchFavoriteTeams.Size = new System.Drawing.Size(193, 30);
            this.buttonFetchFavoriteTeams.TabIndex = 2;
            this.buttonFetchFavoriteTeams.Text = "Fetch Favorite Teams";
            this.buttonFetchFavoriteTeams.UseVisualStyleBackColor = true;
            this.buttonFetchFavoriteTeams.Click += new System.EventHandler(this.buttonFetchFavoriteTeams_Click);
            // 
            // labelFavoriteTeamSelectedPicture
            // 
            this.labelFavoriteTeamSelectedPicture.AutoSize = true;
            this.labelFavoriteTeamSelectedPicture.Location = new System.Drawing.Point(433, 48);
            this.labelFavoriteTeamSelectedPicture.Name = "labelFavoriteTeamSelectedPicture";
            this.labelFavoriteTeamSelectedPicture.Size = new System.Drawing.Size(184, 20);
            this.labelFavoriteTeamSelectedPicture.TabIndex = 12;
            this.labelFavoriteTeamSelectedPicture.Text = "Favorite Team Picture";
            // 
            // FormFavoriteTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(664, 488);
            this.Controls.Add(this.labelFavoriteTeamSelectedPicture);
            this.Controls.Add(this.buttonFetchFavoriteTeams);
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
        private System.Windows.Forms.Button buttonFetchFavoriteTeams;
        private System.Windows.Forms.Label labelFavoriteTeamSelectedPicture;
    }
}