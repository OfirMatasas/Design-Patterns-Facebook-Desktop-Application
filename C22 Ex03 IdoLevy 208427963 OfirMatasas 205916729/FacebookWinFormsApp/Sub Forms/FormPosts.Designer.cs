namespace FacebookWinFormsApp.Forms
{
    internal partial class FormPosts
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
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label messageLabel;
            this.PanelViewPosts = new System.Windows.Forms.Panel();
            this.panelPostsDetails = new System.Windows.Forms.Panel();
            this.createdTimeTextBox = new System.Windows.Forms.TextBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.pictureURLPictureBox = new System.Windows.Forms.PictureBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.labelViewPosts = new System.Windows.Forms.Label();
            this.labelCreateNewPost = new System.Windows.Forms.Label();
            this.splitContainerUpper = new System.Windows.Forms.SplitContainer();
            this.richTextBoxNewPost = new System.Windows.Forms.RichTextBox();
            this.buttonClearNewPostText = new System.Windows.Forms.Button();
            this.buttonPost = new System.Windows.Forms.Button();
            this.panelPostsSection = new System.Windows.Forms.Panel();
            createdTimeLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            this.PanelViewPosts.SuspendLayout();
            this.panelPostsDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureURLPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUpper)).BeginInit();
            this.splitContainerUpper.Panel1.SuspendLayout();
            this.splitContainerUpper.Panel2.SuspendLayout();
            this.splitContainerUpper.SuspendLayout();
            this.panelPostsSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            createdTimeLabel.Location = new System.Drawing.Point(46, 122);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(110, 17);
            createdTimeLabel.TabIndex = 0;
            createdTimeLabel.Text = "Created Time:";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            messageLabel.Location = new System.Drawing.Point(46, 148);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(77, 17);
            messageLabel.TabIndex = 2;
            messageLabel.Text = "Message:";
            // 
            // PanelViewPosts
            // 
            this.PanelViewPosts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelViewPosts.BackColor = System.Drawing.Color.White;
            this.PanelViewPosts.Controls.Add(this.panelPostsDetails);
            this.PanelViewPosts.Controls.Add(this.listBoxPosts);
            this.PanelViewPosts.Controls.Add(this.labelViewPosts);
            this.PanelViewPosts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelViewPosts.Location = new System.Drawing.Point(0, 245);
            this.PanelViewPosts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PanelViewPosts.Name = "PanelViewPosts";
            this.PanelViewPosts.Size = new System.Drawing.Size(650, 315);
            this.PanelViewPosts.TabIndex = 1;
            // 
            // panelPostsDetails
            // 
            this.panelPostsDetails.Controls.Add(createdTimeLabel);
            this.panelPostsDetails.Controls.Add(this.createdTimeTextBox);
            this.panelPostsDetails.Controls.Add(messageLabel);
            this.panelPostsDetails.Controls.Add(this.messageRichTextBox);
            this.panelPostsDetails.Controls.Add(this.pictureURLPictureBox);
            this.panelPostsDetails.Location = new System.Drawing.Point(301, 37);
            this.panelPostsDetails.Name = "panelPostsDetails";
            this.panelPostsDetails.Size = new System.Drawing.Size(346, 264);
            this.panelPostsDetails.TabIndex = 7;
            // 
            // createdTimeTextBox
            // 
            this.createdTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "CreatedTime", true));
            this.createdTimeTextBox.Location = new System.Drawing.Point(164, 121);
            this.createdTimeTextBox.Name = "createdTimeTextBox";
            this.createdTimeTextBox.ReadOnly = true;
            this.createdTimeTextBox.Size = new System.Drawing.Size(122, 20);
            this.createdTimeTextBox.TabIndex = 1;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // messageRichTextBox
            // 
            this.messageRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true));
            this.messageRichTextBox.Location = new System.Drawing.Point(164, 147);
            this.messageRichTextBox.Name = "messageRichTextBox";
            this.messageRichTextBox.ReadOnly = true;
            this.messageRichTextBox.Size = new System.Drawing.Size(122, 96);
            this.messageRichTextBox.TabIndex = 3;
            this.messageRichTextBox.Text = string.Empty;
            // 
            // pictureURLPictureBox
            // 
            this.pictureURLPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.postBindingSource, "PictureURL", true));
            this.pictureURLPictureBox.ImageLocation = string.Empty;
            this.pictureURLPictureBox.Location = new System.Drawing.Point(112, 3);
            this.pictureURLPictureBox.Name = "pictureURLPictureBox";
            this.pictureURLPictureBox.Size = new System.Drawing.Size(122, 90);
            this.pictureURLPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureURLPictureBox.TabIndex = 5;
            this.pictureURLPictureBox.TabStop = false;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.DataSource = this.postBindingSource;
            this.listBoxPosts.DisplayMember = "Message";
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(14, 37);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(282, 264);
            this.listBoxPosts.TabIndex = 6;
            // 
            // labelViewPosts
            // 
            this.labelViewPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelViewPosts.AutoSize = true;
            this.labelViewPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewPosts.Location = new System.Drawing.Point(270, 3);
            this.labelViewPosts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelViewPosts.Name = "labelViewPosts";
            this.labelViewPosts.Size = new System.Drawing.Size(109, 25);
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
            this.labelCreateNewPost.Location = new System.Drawing.Point(250, 10);
            this.labelCreateNewPost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreateNewPost.Name = "labelCreateNewPost";
            this.labelCreateNewPost.Size = new System.Drawing.Size(159, 25);
            this.labelCreateNewPost.TabIndex = 2;
            this.labelCreateNewPost.Text = "Create New Post";
            this.labelCreateNewPost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // splitContainerUpper
            // 
            this.splitContainerUpper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerUpper.Location = new System.Drawing.Point(6, 42);
            this.splitContainerUpper.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitContainerUpper.MaximumSize = new System.Drawing.Size(600, 200);
            this.splitContainerUpper.MinimumSize = new System.Drawing.Size(600, 200);
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
            this.splitContainerUpper.Size = new System.Drawing.Size(600, 200);
            this.splitContainerUpper.SplitterDistance = 441;
            this.splitContainerUpper.SplitterWidth = 2;
            this.splitContainerUpper.TabIndex = 6;
            // 
            // richTextBoxNewPost
            // 
            this.richTextBoxNewPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxNewPost.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxNewPost.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.richTextBoxNewPost.MaximumSize = new System.Drawing.Size(520, 201);
            this.richTextBoxNewPost.MinimumSize = new System.Drawing.Size(520, 201);
            this.richTextBoxNewPost.Name = "richTextBoxNewPost";
            this.richTextBoxNewPost.Size = new System.Drawing.Size(520, 201);
            this.richTextBoxNewPost.TabIndex = 3;
            this.richTextBoxNewPost.Text = string.Empty;
            this.richTextBoxNewPost.TextChanged += new System.EventHandler(this.richTextBoxNewPost_TextChanged);
            // 
            // buttonClearNewPostText
            // 
            this.buttonClearNewPostText.AutoSize = true;
            this.buttonClearNewPostText.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClearNewPostText.Enabled = false;
            this.buttonClearNewPostText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearNewPostText.Location = new System.Drawing.Point(0, 0);
            this.buttonClearNewPostText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonClearNewPostText.Name = "buttonClearNewPostText";
            this.buttonClearNewPostText.Size = new System.Drawing.Size(157, 56);
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
            this.buttonPost.Location = new System.Drawing.Point(0, 144);
            this.buttonPost.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(157, 56);
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
            this.panelPostsSection.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelPostsSection.Name = "panelPostsSection";
            this.panelPostsSection.Size = new System.Drawing.Size(650, 560);
            this.panelPostsSection.TabIndex = 0;
            // 
            // FormPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 560);
            this.Controls.Add(this.PanelViewPosts);
            this.Controls.Add(this.panelPostsSection);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormPosts";
            this.Text = "FormPosts";
            this.PanelViewPosts.ResumeLayout(false);
            this.PanelViewPosts.PerformLayout();
            this.panelPostsDetails.ResumeLayout(false);
            this.panelPostsDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureURLPictureBox)).EndInit();
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
        private System.Windows.Forms.Label labelViewPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label labelCreateNewPost;
        private System.Windows.Forms.SplitContainer splitContainerUpper;
        private System.Windows.Forms.RichTextBox richTextBoxNewPost;
        private System.Windows.Forms.Button buttonClearNewPostText;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Panel panelPostsSection;
        private System.Windows.Forms.Panel panelPostsDetails;
        private System.Windows.Forms.TextBox createdTimeTextBox;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.RichTextBox messageRichTextBox;
        private System.Windows.Forms.PictureBox pictureURLPictureBox;
    }
}