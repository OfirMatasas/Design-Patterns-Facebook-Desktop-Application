namespace FacebookWinFormsApp.Forms
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
            this.components = new System.ComponentModel.Container();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelPageSelectedPicture = new System.Windows.Forms.Label();
            this.labelLikedPages = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageLargePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.DataSource = this.pageBindingSource;
            this.listBoxLikedPages.DisplayMember = "Name";
            this.listBoxLikedPages.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 21;
            this.listBoxLikedPages.Location = new System.Drawing.Point(62, 66);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(224, 466);
            this.listBoxLikedPages.TabIndex = 3;
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // labelPageSelectedPicture
            // 
            this.labelPageSelectedPicture.AutoSize = true;
            this.labelPageSelectedPicture.Location = new System.Drawing.Point(322, 52);
            this.labelPageSelectedPicture.Name = "labelPageSelectedPicture";
            this.labelPageSelectedPicture.Size = new System.Drawing.Size(0, 20);
            this.labelPageSelectedPicture.TabIndex = 11;
            // 
            // labelLikedPages
            // 
            this.labelLikedPages.AutoSize = true;
            this.labelLikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLikedPages.Location = new System.Drawing.Point(179, 9);
            this.labelLikedPages.Name = "labelLikedPages";
            this.labelLikedPages.Size = new System.Drawing.Size(174, 31);
            this.labelLikedPages.TabIndex = 17;
            this.labelLikedPages.Text = "Liked Pages";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imageLargePictureBox);
            this.panel1.Location = new System.Drawing.Point(336, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 237);
            this.panel1.TabIndex = 18;
            // 
            // imageLargePictureBox
            // 
            this.imageLargePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageLarge", true));
            this.imageLargePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageLargePictureBox.Location = new System.Drawing.Point(0, 0);
            this.imageLargePictureBox.Name = "imageLargePictureBox";
            this.imageLargePictureBox.Size = new System.Drawing.Size(246, 237);
            this.imageLargePictureBox.TabIndex = 20;
            this.imageLargePictureBox.TabStop = false;
            // 
            // FormLikedPages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(706, 555);
            this.Controls.Add(this.labelLikedPages);
            this.Controls.Add(this.labelPageSelectedPicture);
            this.Controls.Add(this.listBoxLikedPages);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)), true);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormLikedPages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liked Pages";
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.Label labelPageSelectedPicture;
        private System.Windows.Forms.Label labelLikedPages;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imageLargePictureBox;
    }
}