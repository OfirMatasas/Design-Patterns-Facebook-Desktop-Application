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
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavoriteTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFavoriteTeams
            // 
            this.listBoxFavoriteTeams.FormattingEnabled = true;
            this.listBoxFavoriteTeams.Location = new System.Drawing.Point(30, 50);
            this.listBoxFavoriteTeams.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxFavoriteTeams.Name = "listBoxFavoriteTeams";
            this.listBoxFavoriteTeams.Size = new System.Drawing.Size(260, 290);
            this.listBoxFavoriteTeams.TabIndex = 0;
            this.listBoxFavoriteTeams.SelectedIndexChanged += new System.EventHandler(this.listBoxFavoriteTeams_SelectedIndexChanged);
            // 
            // pictureBoxFavoriteTeam
            // 
            this.pictureBoxFavoriteTeam.Location = new System.Drawing.Point(200, 250);
            this.pictureBoxFavoriteTeam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxFavoriteTeam.Name = "pictureBoxFavoriteTeam";
            this.pictureBoxFavoriteTeam.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxFavoriteTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFavoriteTeam.TabIndex = 1;
            this.pictureBoxFavoriteTeam.TabStop = false;
            // 
            // buttonFetchFavoriteTeams
            // 
            this.buttonFetchFavoriteTeams.AutoSize = true;
            this.buttonFetchFavoriteTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchFavoriteTeams.Location = new System.Drawing.Point(30, 10);
            this.buttonFetchFavoriteTeams.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFetchFavoriteTeams.Name = "buttonFetchFavoriteTeams";
            this.buttonFetchFavoriteTeams.Size = new System.Drawing.Size(175, 30);
            this.buttonFetchFavoriteTeams.TabIndex = 2;
            this.buttonFetchFavoriteTeams.Text = "Fetch Favorite Teams";
            this.buttonFetchFavoriteTeams.UseVisualStyleBackColor = true;
            this.buttonFetchFavoriteTeams.Click += new System.EventHandler(this.buttonFetchFavoriteTeams_Click);
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(392, 263);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(8, 8);
            this.chromiumWebBrowser1.TabIndex = 3;
            // 
            // FormFavoriteTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 351);
            this.Controls.Add(this.chromiumWebBrowser1);
            this.Controls.Add(this.buttonFetchFavoriteTeams);
            this.Controls.Add(this.pictureBoxFavoriteTeam);
            this.Controls.Add(this.listBoxFavoriteTeams);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormFavoriteTeams";
            this.Text = "FormFavoriteTeams";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavoriteTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFavoriteTeams;
        private System.Windows.Forms.PictureBox pictureBoxFavoriteTeam;
        private System.Windows.Forms.Button buttonFetchFavoriteTeams;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
    }
}