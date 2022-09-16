namespace FacebookWinFormsApp.Forms
{
    internal partial class FormFriends
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
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelFriendsInformation = new System.Windows.Forms.Label();
            this.labelFriends = new System.Windows.Forms.Label();
            this.panelDataBindings = new System.Windows.Forms.Panel();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.aboutRichTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.panelDataBindings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.DataSource = this.userBindingSource;
            this.listBoxFriends.DisplayMember = "Name";
            this.listBoxFriends.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(29, 66);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(185, 368);
            this.listBoxFriends.TabIndex = 5;
            this.listBoxFriends.ValueMember = "About";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // labelFriendsInformation
            // 
            this.labelFriendsInformation.AutoSize = true;
            this.labelFriendsInformation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendsInformation.Location = new System.Drawing.Point(50, 124);
            this.labelFriendsInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFriendsInformation.Name = "labelFriendsInformation";
            this.labelFriendsInformation.Size = new System.Drawing.Size(116, 21);
            this.labelFriendsInformation.TabIndex = 9;
            this.labelFriendsInformation.Text = "Friend\'s About";
            this.labelFriendsInformation.Visible = false;
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriends.Location = new System.Drawing.Point(191, 6);
            this.labelFriends.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(112, 31);
            this.labelFriends.TabIndex = 15;
            this.labelFriends.Text = "Friends";
            // 
            // panelDataBindings
            // 
            this.panelDataBindings.Controls.Add(this.imageNormalPictureBox);
            this.panelDataBindings.Controls.Add(this.aboutRichTextBox);
            this.panelDataBindings.Controls.Add(this.labelFriendsInformation);
            this.panelDataBindings.Location = new System.Drawing.Point(271, 70);
            this.panelDataBindings.Name = "panelDataBindings";
            this.panelDataBindings.Size = new System.Drawing.Size(216, 284);
            this.panelDataBindings.TabIndex = 16;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(49, 0);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(117, 116);
            this.imageNormalPictureBox.TabIndex = 20;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // aboutRichTextBox
            // 
            this.aboutRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "About", true));
            this.aboutRichTextBox.Location = new System.Drawing.Point(0, 158);
            this.aboutRichTextBox.Name = "aboutRichTextBox";
            this.aboutRichTextBox.Size = new System.Drawing.Size(216, 126);
            this.aboutRichTextBox.TabIndex = 18;
            this.aboutRichTextBox.Text = string.Empty;
            // 
            // FormFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 510);
            this.Controls.Add(this.labelFriends);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.panelDataBindings);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormFriends";
            this.Text = "FormFriends";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.panelDataBindings.ResumeLayout(false);
            this.panelDataBindings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label labelFriendsInformation;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.Panel panelDataBindings;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.RichTextBox aboutRichTextBox;
    }
}