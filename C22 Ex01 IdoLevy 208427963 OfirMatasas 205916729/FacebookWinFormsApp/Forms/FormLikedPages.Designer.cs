namespace FaceBookWinFormsApp.Forms
{
    internal partial class FormLikedPages
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
            this.pictureBoxSelectedLikedPage = new System.Windows.Forms.PictureBox();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.labelPageSelectedPicture = new System.Windows.Forms.Label();
            this.labelLikedPages = new System.Windows.Forms.Label();
            this.labelPicture = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedLikedPage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSelectedLikedPage
            // 
            this.pictureBoxSelectedLikedPage.Location = new System.Drawing.Point(449, 126);
            this.pictureBoxSelectedLikedPage.Name = "pictureBoxSelectedLikedPage";
            this.pictureBoxSelectedLikedPage.Size = new System.Drawing.Size(130, 130);
            this.pictureBoxSelectedLikedPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxSelectedLikedPage.TabIndex = 4;
            this.pictureBoxSelectedLikedPage.TabStop = false;
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 21;
            this.listBoxLikedPages.Location = new System.Drawing.Point(69, 90);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(318, 403);
            this.listBoxLikedPages.TabIndex = 3;
            this.listBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikedPages_SelectedIndexChanged);
            // 
            // labelPageSelectedPicture
            // 
            this.labelPageSelectedPicture.AutoSize = true;
            this.labelPageSelectedPicture.Location = new System.Drawing.Point(489, 52);
            this.labelPageSelectedPicture.Name = "labelPageSelectedPicture";
            this.labelPageSelectedPicture.Size = new System.Drawing.Size(0, 20);
            this.labelPageSelectedPicture.TabIndex = 11;
            // 
            // labelLikedPages
            // 
            this.labelLikedPages.AutoSize = true;
            this.labelLikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLikedPages.Location = new System.Drawing.Point(180, 52);
            this.labelLikedPages.Name = "labelLikedPages";
            this.labelLikedPages.Size = new System.Drawing.Size(118, 24);
            this.labelLikedPages.TabIndex = 13;
            this.labelLikedPages.Text = "LikedPages";
            this.labelLikedPages.Visible = false;
            // 
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPicture.Location = new System.Drawing.Point(474, 90);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(75, 24);
            this.labelPicture.TabIndex = 14;
            this.labelPicture.Text = "Picture";
            this.labelPicture.Visible = false;
            // 
            // FormLikedPages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 566);
            this.Controls.Add(this.labelPicture);
            this.Controls.Add(this.labelLikedPages);
            this.Controls.Add(this.labelPageSelectedPicture);
            this.Controls.Add(this.pictureBoxSelectedLikedPage);
            this.Controls.Add(this.listBoxLikedPages);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)), true);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormLikedPages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liked Pages";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedLikedPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxSelectedLikedPage;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.Label labelPageSelectedPicture;
        private System.Windows.Forms.Label labelLikedPages;
        private System.Windows.Forms.Label labelPicture;
    }
}