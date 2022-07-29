namespace BasicFacebookFeatures
{
    partial class FormLikedPages
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
            this.buttonFetchLikedPages = new System.Windows.Forms.Button();
            this.pictureBoxLikedPage = new System.Windows.Forms.PictureBox();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFetchLikedPages
            // 
            this.buttonFetchLikedPages.AutoSize = true;
            this.buttonFetchLikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchLikedPages.Location = new System.Drawing.Point(48, 16);
            this.buttonFetchLikedPages.Name = "buttonFetchLikedPages";
            this.buttonFetchLikedPages.Size = new System.Drawing.Size(193, 30);
            this.buttonFetchLikedPages.TabIndex = 5;
            this.buttonFetchLikedPages.Text = "Fetch Liked Pages";
            this.buttonFetchLikedPages.UseVisualStyleBackColor = true;
            this.buttonFetchLikedPages.Click += new System.EventHandler(this.buttonFetchLikedPages_Click_1);
            // 
            // pictureBoxLikedPage
            // 
            this.pictureBoxLikedPage.Location = new System.Drawing.Point(369, 387);
            this.pictureBoxLikedPage.Name = "pictureBoxLikedPage";
            this.pictureBoxLikedPage.Size = new System.Drawing.Size(110, 110);
            this.pictureBoxLikedPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLikedPage.TabIndex = 4;
            this.pictureBoxLikedPage.TabStop = false;
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 21;
            this.listBoxLikedPages.Location = new System.Drawing.Point(48, 52);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(431, 445);
            this.listBoxLikedPages.TabIndex = 3;
            this.listBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikedPages_SelectedIndexChanged_1);
            // 
            // FormLikedPages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(527, 513);
            this.Controls.Add(this.buttonFetchLikedPages);
            this.Controls.Add(this.pictureBoxLikedPage);
            this.Controls.Add(this.listBoxLikedPages);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)), true);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormLikedPages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liked Pages";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFetchLikedPages;
        private System.Windows.Forms.PictureBox pictureBoxLikedPage;
        private System.Windows.Forms.ListBox listBoxLikedPages;
    }
}