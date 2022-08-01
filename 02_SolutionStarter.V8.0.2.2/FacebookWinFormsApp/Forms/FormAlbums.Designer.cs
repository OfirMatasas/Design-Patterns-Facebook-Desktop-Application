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
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelSelectedAlbumPhotos = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSelectedAlbumName = new System.Windows.Forms.Label();
            this.panelChooseAlbum.SuspendLayout();
            this.flowLayoutPanelSelectedAlbumPhotos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChooseAlbum
            // 
            this.panelChooseAlbum.Controls.Add(this.listBoxAlbums);
            this.panelChooseAlbum.Controls.Add(this.label1);
            this.panelChooseAlbum.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelChooseAlbum.Location = new System.Drawing.Point(0, 0);
            this.panelChooseAlbum.Name = "panelChooseAlbum";
            this.panelChooseAlbum.Size = new System.Drawing.Size(360, 1079);
            this.panelChooseAlbum.TabIndex = 0;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 25;
            this.listBoxAlbums.Location = new System.Drawing.Point(24, 65);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(310, 954);
            this.listBoxAlbums.TabIndex = 1;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Albums";
            // 
            // flowLayoutPanelSelectedAlbumPhotos
            // 
            this.flowLayoutPanelSelectedAlbumPhotos.AutoScroll = true;
            this.flowLayoutPanelSelectedAlbumPhotos.Controls.Add(this.label2);
            this.flowLayoutPanelSelectedAlbumPhotos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelSelectedAlbumPhotos.Location = new System.Drawing.Point(360, 65);
            this.flowLayoutPanelSelectedAlbumPhotos.Name = "flowLayoutPanelSelectedAlbumPhotos";
            this.flowLayoutPanelSelectedAlbumPhotos.Size = new System.Drawing.Size(914, 1014);
            this.flowLayoutPanelSelectedAlbumPhotos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 0;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSelectedAlbumName
            // 
            this.labelSelectedAlbumName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectedAlbumName.AutoSize = true;
            this.labelSelectedAlbumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedAlbumName.Location = new System.Drawing.Point(635, 20);
            this.labelSelectedAlbumName.Name = "labelSelectedAlbumName";
            this.labelSelectedAlbumName.Size = new System.Drawing.Size(388, 42);
            this.labelSelectedAlbumName.TabIndex = 2;
            this.labelSelectedAlbumName.Text = "Selected Album Name";
            this.labelSelectedAlbumName.Visible = false;
            // 
            // FormAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 1079);
            this.Controls.Add(this.labelSelectedAlbumName);
            this.Controls.Add(this.flowLayoutPanelSelectedAlbumPhotos);
            this.Controls.Add(this.panelChooseAlbum);
            this.Name = "FormAlbums";
            this.Text = "FormAlbums";
            this.panelChooseAlbum.ResumeLayout(false);
            this.panelChooseAlbum.PerformLayout();
            this.flowLayoutPanelSelectedAlbumPhotos.ResumeLayout(false);
            this.flowLayoutPanelSelectedAlbumPhotos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelChooseAlbum;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSelectedAlbumPhotos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSelectedAlbumName;
    }
}