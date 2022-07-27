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
            this.pictureBoxFavoriteTeam = new System.Windows.Forms.PictureBox();
            this.buttonFetchFavoriteTeams = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavoriteTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFavoriteTeams
            // 
            this.listBoxFavoriteTeams.FormattingEnabled = true;
            this.listBoxFavoriteTeams.ItemHeight = 16;
            this.listBoxFavoriteTeams.Location = new System.Drawing.Point(25, 47);
            this.listBoxFavoriteTeams.Name = "listBoxFavoriteTeams";
            this.listBoxFavoriteTeams.Size = new System.Drawing.Size(353, 356);
            this.listBoxFavoriteTeams.TabIndex = 0;
            this.listBoxFavoriteTeams.SelectedIndexChanged += new System.EventHandler(this.listBoxFavoriteTeams_SelectedIndexChanged);
            // 
            // pictureBoxFavoriteTeam
            // 
            this.pictureBoxFavoriteTeam.Location = new System.Drawing.Point(253, 278);
            this.pictureBoxFavoriteTeam.Name = "pictureBoxFavoriteTeam";
            this.pictureBoxFavoriteTeam.Size = new System.Drawing.Size(125, 125);
            this.pictureBoxFavoriteTeam.TabIndex = 1;
            this.pictureBoxFavoriteTeam.TabStop = false;
            // 
            // buttonFetchFavoriteTeams
            // 
            this.buttonFetchFavoriteTeams.Location = new System.Drawing.Point(25, 13);
            this.buttonFetchFavoriteTeams.Name = "buttonFetchFavoriteTeams";
            this.buttonFetchFavoriteTeams.Size = new System.Drawing.Size(146, 28);
            this.buttonFetchFavoriteTeams.TabIndex = 2;
            this.buttonFetchFavoriteTeams.Text = "Fetch Favorite Teams";
            this.buttonFetchFavoriteTeams.UseVisualStyleBackColor = true;
            this.buttonFetchFavoriteTeams.Click += new System.EventHandler(this.buttonFetchFavoriteTeams_Click);
            // 
            // FormFavoriteTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFetchFavoriteTeams);
            this.Controls.Add(this.pictureBoxFavoriteTeam);
            this.Controls.Add(this.listBoxFavoriteTeams);
            this.Name = "FormFavoriteTeams";
            this.Text = "FormFavoriteTeams";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavoriteTeam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFavoriteTeams;
        private System.Windows.Forms.PictureBox pictureBoxFavoriteTeam;
        private System.Windows.Forms.Button buttonFetchFavoriteTeams;
    }
}