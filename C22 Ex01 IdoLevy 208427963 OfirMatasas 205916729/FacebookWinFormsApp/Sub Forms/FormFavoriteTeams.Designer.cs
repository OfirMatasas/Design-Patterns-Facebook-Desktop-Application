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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label likesCountLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label websiteLabel;
            System.Windows.Forms.Label cityLabel;
            this.listBoxFavoriteTeams = new System.Windows.Forms.ListBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBoxSelectedFavoriteTeam = new System.Windows.Forms.PictureBox();
            this.labelTeamInformation = new System.Windows.Forms.Label();
            this.labelFavoriteTeams = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.websiteTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.likesCountTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            categoryLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            likesCountLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            websiteLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedFavoriteTeam)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(18, 140);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(86, 20);
            categoryLabel.TabIndex = 16;
            categoryLabel.Text = "Category:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(18, 172);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(105, 20);
            descriptionLabel.TabIndex = 18;
            descriptionLabel.Text = "Description:";
            // 
            // likesCountLabel
            // 
            likesCountLabel.AutoSize = true;
            likesCountLabel.Location = new System.Drawing.Point(18, 274);
            likesCountLabel.Name = "likesCountLabel";
            likesCountLabel.Size = new System.Drawing.Size(109, 20);
            likesCountLabel.TabIndex = 22;
            likesCountLabel.Text = "Likes Count:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(18, 306);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(65, 20);
            phoneLabel.TabIndex = 24;
            phoneLabel.Text = "Phone:";
            // 
            // websiteLabel
            // 
            websiteLabel.AutoSize = true;
            websiteLabel.Location = new System.Drawing.Point(18, 373);
            websiteLabel.Name = "websiteLabel";
            websiteLabel.Size = new System.Drawing.Size(79, 20);
            websiteLabel.TabIndex = 26;
            websiteLabel.Text = "Website:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(18, 338);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(44, 20);
            cityLabel.TabIndex = 27;
            cityLabel.Text = "City:";
            // 
            // listBoxFavoriteTeams
            // 
            this.listBoxFavoriteTeams.DataSource = this.pageBindingSource;
            this.listBoxFavoriteTeams.DisplayMember = "Name";
            this.listBoxFavoriteTeams.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxFavoriteTeams.FormattingEnabled = true;
            this.listBoxFavoriteTeams.ItemHeight = 17;
            this.listBoxFavoriteTeams.Location = new System.Drawing.Point(44, 108);
            this.listBoxFavoriteTeams.Name = "listBoxFavoriteTeams";
            this.listBoxFavoriteTeams.Size = new System.Drawing.Size(221, 446);
            this.listBoxFavoriteTeams.TabIndex = 0;
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // pictureBoxSelectedFavoriteTeam
            // 
            this.pictureBoxSelectedFavoriteTeam.Location = new System.Drawing.Point(76, 12);
            this.pictureBoxSelectedFavoriteTeam.Name = "pictureBoxSelectedFavoriteTeam";
            this.pictureBoxSelectedFavoriteTeam.Size = new System.Drawing.Size(117, 119);
            this.pictureBoxSelectedFavoriteTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelectedFavoriteTeam.TabIndex = 1;
            this.pictureBoxSelectedFavoriteTeam.TabStop = false;
            // 
            // labelTeamInformation
            // 
            this.labelTeamInformation.AutoSize = true;
            this.labelTeamInformation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTeamInformation.Location = new System.Drawing.Point(414, 108);
            this.labelTeamInformation.Name = "labelTeamInformation";
            this.labelTeamInformation.Size = new System.Drawing.Size(139, 21);
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
            this.labelFavoriteTeams.Size = new System.Drawing.Size(217, 31);
            this.labelFavoriteTeams.TabIndex = 14;
            this.labelFavoriteTeams.Text = "Favorite Teams";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(websiteLabel);
            this.panel1.Controls.Add(cityLabel);
            this.panel1.Controls.Add(this.websiteTextBox);
            this.panel1.Controls.Add(this.pictureBoxSelectedFavoriteTeam);
            this.panel1.Controls.Add(this.cityTextBox);
            this.panel1.Controls.Add(this.descriptionRichTextBox);
            this.panel1.Controls.Add(likesCountLabel);
            this.panel1.Controls.Add(categoryLabel);
            this.panel1.Controls.Add(this.likesCountTextBox);
            this.panel1.Controls.Add(phoneLabel);
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Controls.Add(this.phoneTextBox);
            this.panel1.Controls.Add(this.categoryTextBox);
            this.panel1.Location = new System.Drawing.Point(304, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 406);
            this.panel1.TabIndex = 15;
            // 
            // websiteTextBox
            // 
            this.websiteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Website", true));
            this.websiteTextBox.Location = new System.Drawing.Point(149, 370);
            this.websiteTextBox.Name = "websiteTextBox";
            this.websiteTextBox.Size = new System.Drawing.Size(129, 26);
            this.websiteTextBox.TabIndex = 27;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Location.City", true));
            this.cityTextBox.Location = new System.Drawing.Point(149, 338);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(129, 26);
            this.cityTextBox.TabIndex = 28;
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Description", true));
            this.descriptionRichTextBox.Location = new System.Drawing.Point(149, 169);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(129, 96);
            this.descriptionRichTextBox.TabIndex = 19;
            this.descriptionRichTextBox.Text = "";
            // 
            // likesCountTextBox
            // 
            this.likesCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "LikesCount", true));
            this.likesCountTextBox.Location = new System.Drawing.Point(149, 271);
            this.likesCountTextBox.Name = "likesCountTextBox";
            this.likesCountTextBox.Size = new System.Drawing.Size(129, 26);
            this.likesCountTextBox.TabIndex = 23;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(149, 303);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(129, 26);
            this.phoneTextBox.TabIndex = 25;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(149, 137);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(129, 26);
            this.categoryTextBox.TabIndex = 17;
            // 
            // FormFavoriteTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 840);
            this.Controls.Add(this.labelFavoriteTeams);
            this.Controls.Add(this.labelTeamInformation);
            this.Controls.Add(this.listBoxFavoriteTeams);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)), true);
            this.Name = "FormFavoriteTeams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Favorite Teams";
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedFavoriteTeam)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFavoriteTeams;
        private System.Windows.Forms.PictureBox pictureBoxSelectedFavoriteTeam;
        private System.Windows.Forms.Label labelTeamInformation;
        private System.Windows.Forms.Label labelFavoriteTeams;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox websiteTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.TextBox likesCountTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
    }
}