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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPosts));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxArrow = new System.Windows.Forms.PictureBox();
            this.richTextBoxSelectedPost = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonClearNewPostText = new System.Windows.Forms.Button();
            this.buttonPost = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.listBoxPosts);
            this.panel2.Controls.Add(this.checkedListBox1);
            this.panel2.Controls.Add(this.pictureBoxArrow);
            this.panel2.Controls.Add(this.richTextBoxSelectedPost);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 375);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1444, 474);
            this.panel2.TabIndex = 1;
            // 
            // pictureBoxArrow
            // 
            this.pictureBoxArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxArrow.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxArrow.ErrorImage")));
            this.pictureBoxArrow.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxArrow.InitialImage")));
            this.pictureBoxArrow.Location = new System.Drawing.Point(513, 255);
            this.pictureBoxArrow.Name = "pictureBoxArrow";
            this.pictureBoxArrow.Size = new System.Drawing.Size(88, 40);
            this.pictureBoxArrow.TabIndex = 4;
            this.pictureBoxArrow.TabStop = false;
            // 
            // richTextBoxSelectedPost
            // 
            this.richTextBoxSelectedPost.Location = new System.Drawing.Point(606, 58);
            this.richTextBoxSelectedPost.Name = "richTextBoxSelectedPost";
            this.richTextBoxSelectedPost.Size = new System.Drawing.Size(751, 407);
            this.richTextBoxSelectedPost.TabIndex = 3;
            this.richTextBoxSelectedPost.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(636, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "View Posts";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1444, 849);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(9, 65);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonClearNewPostText);
            this.splitContainer1.Panel2.Controls.Add(this.buttonPost);
            this.splitContainer1.Size = new System.Drawing.Size(1426, 463);
            this.splitContainer1.SplitterDistance = 1096;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1096, 463);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // buttonClearNewPostText
            // 
            this.buttonClearNewPostText.AutoSize = true;
            this.buttonClearNewPostText.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClearNewPostText.Enabled = false;
            this.buttonClearNewPostText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearNewPostText.Location = new System.Drawing.Point(0, 0);
            this.buttonClearNewPostText.Name = "buttonClearNewPostText";
            this.buttonClearNewPostText.Size = new System.Drawing.Size(327, 86);
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
            this.buttonPost.Location = new System.Drawing.Point(0, 377);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(327, 86);
            this.buttonPost.TabIndex = 4;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(567, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Create A New Post";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(291, 304);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 5;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 20;
            this.listBoxPosts.Location = new System.Drawing.Point(23, 58);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(484, 404);
            this.listBoxPosts.TabIndex = 6;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // FormPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 849);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormPosts";
            this.Text = "FormPosts";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxArrow;
        private System.Windows.Forms.RichTextBox richTextBoxSelectedPost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonClearNewPostText;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}