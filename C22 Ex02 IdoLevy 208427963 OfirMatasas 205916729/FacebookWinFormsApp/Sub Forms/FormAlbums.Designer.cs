namespace FacebookWinFormsApp.Forms
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
            this.components = new System.ComponentModel.Container();
            this.panelChooseAlbum = new System.Windows.Forms.Panel();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.labelAlbums = new System.Windows.Forms.Label();
            this.flowLayoutPanelSelectedAlbumPhotos = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSelectedAlbumName = new System.Windows.Forms.Label();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelChooseAlbum.SuspendLayout();
            this.flowLayoutPanelSelectedAlbumPhotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChooseAlbum
            // 
            this.panelChooseAlbum.BackColor = System.Drawing.Color.White;
            this.panelChooseAlbum.Controls.Add(this.listBoxAlbums);
            this.panelChooseAlbum.Controls.Add(this.labelAlbums);
            this.panelChooseAlbum.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelChooseAlbum.Location = new System.Drawing.Point(0, 0);
            this.panelChooseAlbum.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panelChooseAlbum.Name = "panelChooseAlbum";
            this.panelChooseAlbum.Size = new System.Drawing.Size(195, 550);
            this.panelChooseAlbum.TabIndex = 0;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.DataSource = this.albumBindingSource;
            this.listBoxAlbums.DisplayMember = "Name";
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(12, 34);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(173, 498);
            this.listBoxAlbums.TabIndex = 1;
            this.listBoxAlbums.ValueMember = "Comments";
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // labelAlbums
            // 
            this.labelAlbums.AutoSize = true;
            this.labelAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbums.Location = new System.Drawing.Point(65, 10);
            this.labelAlbums.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
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
            this.flowLayoutPanelSelectedAlbumPhotos.Location = new System.Drawing.Point(195, 23);
            this.flowLayoutPanelSelectedAlbumPhotos.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.flowLayoutPanelSelectedAlbumPhotos.Name = "flowLayoutPanelSelectedAlbumPhotos";
            this.flowLayoutPanelSelectedAlbumPhotos.Size = new System.Drawing.Size(432, 527);
            this.flowLayoutPanelSelectedAlbumPhotos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSelectedAlbumName
            // 
            this.labelSelectedAlbumName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectedAlbumName.AutoSize = true;
            this.labelSelectedAlbumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedAlbumName.Location = new System.Drawing.Point(317, 10);
            this.labelSelectedAlbumName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelSelectedAlbumName.Name = "labelSelectedAlbumName";
            this.labelSelectedAlbumName.Size = new System.Drawing.Size(200, 24);
            this.labelSelectedAlbumName.TabIndex = 2;
            this.labelSelectedAlbumName.Text = "Selected Album Name";
            this.labelSelectedAlbumName.Visible = false;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // FormAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 550);
            this.Controls.Add(this.labelSelectedAlbumName);
            this.Controls.Add(this.flowLayoutPanelSelectedAlbumPhotos);
            this.Controls.Add(this.panelChooseAlbum);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FormAlbums";
            this.Text = "FormAlbums";
            this.panelChooseAlbum.ResumeLayout(false);
            this.panelChooseAlbum.PerformLayout();
            this.flowLayoutPanelSelectedAlbumPhotos.ResumeLayout(false);
            this.flowLayoutPanelSelectedAlbumPhotos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource albumBindingSource;
    }
}