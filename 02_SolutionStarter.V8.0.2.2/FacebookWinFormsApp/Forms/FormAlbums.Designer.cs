namespace BasicFacebookFeatures.Forms
{
    partial class FormAlbums
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
            this.panelChooseAlbum = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.flowLayoutPanelSelectedAlbumPhotos = new System.Windows.Forms.FlowLayoutPanel();
            this.panelChooseAlbum.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChooseAlbum
            // 
            this.panelChooseAlbum.Controls.Add(this.listBoxAlbums);
            this.panelChooseAlbum.Controls.Add(this.label1);
            this.panelChooseAlbum.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelChooseAlbum.Location = new System.Drawing.Point(0, 0);
            this.panelChooseAlbum.Name = "panelChooseAlbum";
            this.panelChooseAlbum.Size = new System.Drawing.Size(304, 1079);
            this.panelChooseAlbum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Albums";
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 25;
            this.listBoxAlbums.Location = new System.Drawing.Point(24, 100);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(260, 954);
            this.listBoxAlbums.TabIndex = 1;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // flowLayoutPanelSelectedAlbumPhotos
            // 
            this.flowLayoutPanelSelectedAlbumPhotos.AutoScroll = true;
            this.flowLayoutPanelSelectedAlbumPhotos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelSelectedAlbumPhotos.Location = new System.Drawing.Point(304, 0);
            this.flowLayoutPanelSelectedAlbumPhotos.Name = "flowLayoutPanelSelectedAlbumPhotos";
            this.flowLayoutPanelSelectedAlbumPhotos.Size = new System.Drawing.Size(970, 1079);
            this.flowLayoutPanelSelectedAlbumPhotos.TabIndex = 1;
            // 
            // FormAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 1079);
            this.Controls.Add(this.flowLayoutPanelSelectedAlbumPhotos);
            this.Controls.Add(this.panelChooseAlbum);
            this.Name = "FormAlbums";
            this.Text = "FormAlbums";
            this.panelChooseAlbum.ResumeLayout(false);
            this.panelChooseAlbum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChooseAlbum;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSelectedAlbumPhotos;
    }
}