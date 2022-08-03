namespace BasicFacebookFeatures
{
    partial class FormPosts
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
            this.PanelViewPosts = new System.Windows.Forms.Panel();
            this.pictureBoxSelectedPostPicture = new System.Windows.Forms.PictureBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.richTextBoxSelectedPost = new System.Windows.Forms.RichTextBox();
            this.labelViewPosts = new System.Windows.Forms.Label();
            this.labelCreateNewPost = new System.Windows.Forms.Label();
            this.splitContainerUpper = new System.Windows.Forms.SplitContainer();
            this.richTextBoxNewPost = new System.Windows.Forms.RichTextBox();
            this.buttonClearNewPostText = new System.Windows.Forms.Button();
            this.buttonPost = new System.Windows.Forms.Button();
            this.panelPostsSection = new System.Windows.Forms.Panel();
            this.PanelViewPosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedPostPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUpper)).BeginInit();
            this.splitContainerUpper.Panel1.SuspendLayout();
            this.splitContainerUpper.Panel2.SuspendLayout();
            this.splitContainerUpper.SuspendLayout();
            this.panelPostsSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelViewPosts
            // 
            this.PanelViewPosts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelViewPosts.BackColor = System.Drawing.Color.White;
            this.PanelViewPosts.Controls.Add(this.pictureBoxSelectedPostPicture);
            this.PanelViewPosts.Controls.Add(this.listBoxPosts);
            this.PanelViewPosts.Controls.Add(this.richTextBoxSelectedPost);
            this.PanelViewPosts.Controls.Add(this.labelViewPosts);
            this.PanelViewPosts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelViewPosts.Location = new System.Drawing.Point(0, 464);
            this.PanelViewPosts.Margin = new System.Windows.Forms.Padding(4);
            this.PanelViewPosts.Name = "PanelViewPosts";
            this.PanelViewPosts.Size = new System.Drawing.Size(1301, 604);
            this.PanelViewPosts.TabIndex = 1;
            // 
            // pictureBoxSelectedPostPicture
            // 
            this.pictureBoxSelectedPostPicture.Location = new System.Drawing.Point(775, 394);
            this.pictureBoxSelectedPostPicture.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBoxSelectedPostPicture.Name = "pictureBoxSelectedPostPicture";
            this.pictureBoxSelectedPostPicture.Size = new System.Drawing.Size(299, 171);
            this.pictureBoxSelectedPostPicture.TabIndex = 7;
            this.pictureBoxSelectedPostPicture.TabStop = false;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 25;
            this.listBoxPosts.Location = new System.Drawing.Point(29, 72);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(560, 504);
            this.listBoxPosts.TabIndex = 6;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // richTextBoxSelectedPost
            // 
            this.richTextBoxSelectedPost.Location = new System.Drawing.Point(660, 72);
            this.richTextBoxSelectedPost.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxSelectedPost.Name = "richTextBoxSelectedPost";
            this.richTextBoxSelectedPost.Size = new System.Drawing.Size(520, 312);
            this.richTextBoxSelectedPost.TabIndex = 3;
            this.richTextBoxSelectedPost.Text = "";
            this.richTextBoxSelectedPost.Visible = false;
            // 
            // labelViewPosts
            // 
            this.labelViewPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelViewPosts.AutoSize = true;
            this.labelViewPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewPosts.Location = new System.Drawing.Point(541, 6);
            this.labelViewPosts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelViewPosts.Name = "labelViewPosts";
            this.labelViewPosts.Size = new System.Drawing.Size(219, 46);
            this.labelViewPosts.TabIndex = 1;
            this.labelViewPosts.Text = "View Posts";
            this.labelViewPosts.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCreateNewPost
            // 
            this.labelCreateNewPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCreateNewPost.AutoSize = true;
            this.labelCreateNewPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateNewPost.Location = new System.Drawing.Point(500, 18);
            this.labelCreateNewPost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCreateNewPost.Name = "labelCreateNewPost";
            this.labelCreateNewPost.Size = new System.Drawing.Size(322, 46);
            this.labelCreateNewPost.TabIndex = 2;
            this.labelCreateNewPost.Text = "Create New Post";
            this.labelCreateNewPost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // splitContainerUpper
            // 
            this.splitContainerUpper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerUpper.Location = new System.Drawing.Point(12, 81);
            this.splitContainerUpper.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerUpper.MaximumSize = new System.Drawing.Size(1200, 385);
            this.splitContainerUpper.MinimumSize = new System.Drawing.Size(1200, 385);
            this.splitContainerUpper.Name = "splitContainerUpper";
            // 
            // splitContainerUpper.Panel1
            // 
            this.splitContainerUpper.Panel1.Controls.Add(this.richTextBoxNewPost);
            // 
            // splitContainerUpper.Panel2
            // 
            this.splitContainerUpper.Panel2.Controls.Add(this.buttonClearNewPostText);
            this.splitContainerUpper.Panel2.Controls.Add(this.buttonPost);
            this.splitContainerUpper.Size = new System.Drawing.Size(1200, 385);
            this.splitContainerUpper.SplitterDistance = 884;
            this.splitContainerUpper.TabIndex = 6;
            // 
            // richTextBoxNewPost
            // 
            this.richTextBoxNewPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxNewPost.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxNewPost.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxNewPost.MaximumSize = new System.Drawing.Size(1036, 382);
            this.richTextBoxNewPost.MinimumSize = new System.Drawing.Size(1036, 382);
            this.richTextBoxNewPost.Name = "richTextBoxNewPost";
            this.richTextBoxNewPost.Size = new System.Drawing.Size(1036, 382);
            this.richTextBoxNewPost.TabIndex = 3;
            this.richTextBoxNewPost.Text = "";
            this.richTextBoxNewPost.TextChanged += new System.EventHandler(this.richTextBoxNewPost_TextChanged);
            // 
            // buttonClearNewPostText
            // 
            this.buttonClearNewPostText.AutoSize = true;
            this.buttonClearNewPostText.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClearNewPostText.Enabled = false;
            this.buttonClearNewPostText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearNewPostText.Location = new System.Drawing.Point(0, 0);
            this.buttonClearNewPostText.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClearNewPostText.Name = "buttonClearNewPostText";
            this.buttonClearNewPostText.Size = new System.Drawing.Size(312, 108);
            this.buttonClearNewPostText.TabIndex = 5;
            this.buttonClearNewPostText.Text = "Clear";
            this.buttonClearNewPostText.UseVisualStyleBackColor = true;
            this.buttonClearNewPostText.Click += new System.EventHandler(this.buttonClearNewPostText_Click);
            // 
            // buttonPost
            // 
            this.buttonPost.AutoSize = true;
            this.buttonPost.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPost.Enabled = false;
            this.buttonPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPost.Location = new System.Drawing.Point(0, 277);
            this.buttonPost.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(312, 108);
            this.buttonPost.TabIndex = 4;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // panelPostsSection
            // 
            this.panelPostsSection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelPostsSection.BackColor = System.Drawing.Color.White;
            this.panelPostsSection.Controls.Add(this.splitContainerUpper);
            this.panelPostsSection.Controls.Add(this.labelCreateNewPost);
            this.panelPostsSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPostsSection.Location = new System.Drawing.Point(0, 0);
            this.panelPostsSection.Margin = new System.Windows.Forms.Padding(4);
            this.panelPostsSection.Name = "panelPostsSection";
            this.panelPostsSection.Size = new System.Drawing.Size(1301, 1068);
            this.panelPostsSection.TabIndex = 0;
            // 
            // FormPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 1068);
            this.Controls.Add(this.PanelViewPosts);
            this.Controls.Add(this.panelPostsSection);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPosts";
            this.Text = "FormPosts";
            this.PanelViewPosts.ResumeLayout(false);
            this.PanelViewPosts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedPostPicture)).EndInit();
            this.splitContainerUpper.Panel1.ResumeLayout(false);
            this.splitContainerUpper.Panel2.ResumeLayout(false);
            this.splitContainerUpper.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUpper)).EndInit();
            this.splitContainerUpper.ResumeLayout(false);
            this.panelPostsSection.ResumeLayout(false);
            this.panelPostsSection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelViewPosts;
        private System.Windows.Forms.RichTextBox richTextBoxSelectedPost;
        private System.Windows.Forms.Label labelViewPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.PictureBox pictureBoxSelectedPostPicture;
        private System.Windows.Forms.Label labelCreateNewPost;
        private System.Windows.Forms.SplitContainer splitContainerUpper;
        private System.Windows.Forms.RichTextBox richTextBoxNewPost;
        private System.Windows.Forms.Button buttonClearNewPostText;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Panel panelPostsSection;
    }
}