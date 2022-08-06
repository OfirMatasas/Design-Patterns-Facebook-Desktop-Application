namespace FaceBookWinFormsApp.Forms
{
    internal partial class FormAlbums
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
            this.labelAlbums = new System.Windows.Forms.Label();
            this.flowLayoutPanelSelectedAlbumPhotos = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSelectedAlbumName = new System.Windows.Forms.Label();
            this.panelChooseAlbum.SuspendLayout();
            this.flowLayoutPanelSelectedAlbumPhotos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChooseAlbum
            // 
            this.panelChooseAlbum.BackColor = System.Drawing.Color.White;
            this.panelChooseAlbum.Controls.Add(this.listBoxAlbums);
            this.panelChooseAlbum.Controls.Add(this.labelAlbums);
            this.panelChooseAlbum.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelChooseAlbum.Location = new System.Drawing.Point(0, 0);
            this.panelChooseAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.panelChooseAlbum.Name = "panelChooseAlbum";
            this.panelChooseAlbum.Size = new System.Drawing.Size(240, 679);
            this.panelChooseAlbum.TabIndex = 0;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 16;
            this.listBoxAlbums.Location = new System.Drawing.Point(16, 42);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(208, 612);
            this.listBoxAlbums.TabIndex = 1;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // labelAlbums
            // 
            this.labelAlbums.AutoSize = true;
            this.labelAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbums.Location = new System.Drawing.Point(70, 13);
            this.labelAlbums.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlbums.Name = "labelAlbums";
            this.labelAlbums.Size = new System.Drawing.Size(74, 24);
            this.labelAlbums.TabIndex = 0;
            this.labelAlbums.Text = "Albums";
            // 
            // flowLayoutPanelSelectedAlbumPhotos
            // 
            this.flowLayoutPanelSelectedAlbumPhotos.AutoScroll = true;
            this.flowLayoutPanelSelectedAlbumPhotos.Controls.Add(this.label2);
            this.flowLayoutPanelSelectedAlbumPhotos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelSelectedAlbumPhotos.Location = new System.Drawing.Point(240, 30);
            this.flowLayoutPanelSelectedAlbumPhotos.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelSelectedAlbumPhotos.Name = "flowLayoutPanelSelectedAlbumPhotos";
            this.flowLayoutPanelSelectedAlbumPhotos.Size = new System.Drawing.Size(609, 649);
            this.flowLayoutPanelSelectedAlbumPhotos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 0;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSelectedAlbumName
            // 
            this.labelSelectedAlbumName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectedAlbumName.AutoSize = true;
            this.labelSelectedAlbumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedAlbumName.Location = new System.Drawing.Point(423, 13);
            this.labelSelectedAlbumName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSelectedAlbumName.Name = "labelSelectedAlbumName";
            this.labelSelectedAlbumName.Size = new System.Drawing.Size(200, 24);
            this.labelSelectedAlbumName.TabIndex = 2;
            this.labelSelectedAlbumName.Text = "Selected Album Name";
            this.labelSelectedAlbumName.Visible = false;
            // 
            // FormAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(849, 679);
            this.Controls.Add(this.labelSelectedAlbumName);
            this.Controls.Add(this.flowLayoutPanelSelectedAlbumPhotos);
            this.Controls.Add(this.panelChooseAlbum);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label labelAlbums;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSelectedAlbumPhotos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSelectedAlbumName;
    }
}