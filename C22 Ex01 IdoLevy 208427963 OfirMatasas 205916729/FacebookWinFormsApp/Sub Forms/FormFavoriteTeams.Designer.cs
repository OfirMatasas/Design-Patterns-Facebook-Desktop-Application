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
            this.labelTeamInformation = new System.Windows.Forms.Label();
            this.labelFavoriteTeams = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.likesCountTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.websiteTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            categoryLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            likesCountLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            websiteLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
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
            // labelTeamInformation
            // 
            this.labelTeamInformation.AutoSize = true;
            this.labelTeamInformation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTeamInformation.Location = new System.Drawing.Point(396, 95);
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
            this.panel1.Controls.Add(cityLabel);
            this.panel1.Controls.Add(this.imageNormalPictureBox);
            this.panel1.Controls.Add(this.cityTextBox);
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Controls.Add(likesCountLabel);
            this.panel1.Controls.Add(categoryLabel);
            this.panel1.Controls.Add(this.likesCountTextBox);
            this.panel1.Controls.Add(this.descriptionRichTextBox);
            this.panel1.Controls.Add(phoneLabel);
            this.panel1.Controls.Add(this.categoryTextBox);
            this.panel1.Controls.Add(this.phoneTextBox);
            this.panel1.Controls.Add(websiteLabel);
            this.panel1.Controls.Add(this.websiteTextBox);
            this.panel1.Location = new System.Drawing.Point(306, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 406);
            this.panel1.TabIndex = 15;
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(18, 129);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(86, 20);
            categoryLabel.TabIndex = 16;
            categoryLabel.Text = "Category:";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(149, 126);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(126, 26);
            this.categoryTextBox.TabIndex = 17;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(18, 161);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(105, 20);
            descriptionLabel.TabIndex = 18;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Description", true));
            this.descriptionRichTextBox.Location = new System.Drawing.Point(149, 158);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(126, 96);
            this.descriptionRichTextBox.TabIndex = 19;
            this.descriptionRichTextBox.Text = "";
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(85, 16);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(100, 93);
            this.imageNormalPictureBox.TabIndex = 21;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // likesCountLabel
            // 
            likesCountLabel.AutoSize = true;
            likesCountLabel.Location = new System.Drawing.Point(18, 262);
            likesCountLabel.Name = "likesCountLabel";
            likesCountLabel.Size = new System.Drawing.Size(109, 20);
            likesCountLabel.TabIndex = 22;
            likesCountLabel.Text = "Likes Count:";
            // 
            // likesCountTextBox
            // 
            this.likesCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "LikesCount", true));
            this.likesCountTextBox.Location = new System.Drawing.Point(149, 259);
            this.likesCountTextBox.Name = "likesCountTextBox";
            this.likesCountTextBox.Size = new System.Drawing.Size(126, 26);
            this.likesCountTextBox.TabIndex = 23;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(18, 294);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(65, 20);
            phoneLabel.TabIndex = 24;
            phoneLabel.Text = "Phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(149, 291);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(126, 26);
            this.phoneTextBox.TabIndex = 25;
            // 
            // websiteLabel
            // 
            websiteLabel.AutoSize = true;
            websiteLabel.Location = new System.Drawing.Point(18, 326);
            websiteLabel.Name = "websiteLabel";
            websiteLabel.Size = new System.Drawing.Size(79, 20);
            websiteLabel.TabIndex = 26;
            websiteLabel.Text = "Website:";
            // 
            // websiteTextBox
            // 
            this.websiteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Website", true));
            this.websiteTextBox.Location = new System.Drawing.Point(149, 323);
            this.websiteTextBox.Name = "websiteTextBox";
            this.websiteTextBox.Size = new System.Drawing.Size(126, 26);
            this.websiteTextBox.TabIndex = 27;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(21, 355);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(44, 20);
            cityLabel.TabIndex = 27;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Location.City", true));
            this.cityTextBox.Location = new System.Drawing.Point(149, 355);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(126, 26);
            this.cityTextBox.TabIndex = 28;
            // 
            // FormFavoriteTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 840);
            this.Controls.Add(this.labelFavoriteTeams);
            this.Controls.Add(this.labelTeamInformation);
            this.Controls.Add(this.listBoxFavoriteTeams);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)), true);
            this.Name = "FormFavoriteTeams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Favorite Teams";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFavoriteTeams;
        private System.Windows.Forms.Label labelTeamInformation;
        private System.Windows.Forms.Label labelFavoriteTeams;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox likesCountTextBox;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox websiteTextBox;
    }
}