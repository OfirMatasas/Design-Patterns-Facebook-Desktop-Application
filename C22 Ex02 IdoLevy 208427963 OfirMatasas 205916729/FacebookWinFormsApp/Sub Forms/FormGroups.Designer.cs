namespace FacebookWinFormsApp.Forms
{
    internal partial class FormGroups
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
            System.Windows.Forms.Label descriptionLabel;
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelPicture = new System.Windows.Forms.Label();
            this.labelGroups = new System.Windows.Forms.Label();
            this.panelDataBindings = new System.Windows.Forms.Panel();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.panelDataBindings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(108, 142);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(105, 20);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.DataSource = this.groupBindingSource;
            this.listBoxGroups.DisplayMember = "Name";
            this.listBoxGroups.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 17;
            this.listBoxGroups.Location = new System.Drawing.Point(58, 65);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(210, 446);
            this.listBoxGroups.TabIndex = 6;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
            // 
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPicture.Location = new System.Drawing.Point(339, 94);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(0, 19);
            this.labelPicture.TabIndex = 11;
            this.labelPicture.Visible = false;
            // 
            // labelGroups
            // 
            this.labelGroups.AutoSize = true;
            this.labelGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGroups.Location = new System.Drawing.Point(256, 12);
            this.labelGroups.Name = "labelGroups";
            this.labelGroups.Size = new System.Drawing.Size(109, 31);
            this.labelGroups.TabIndex = 16;
            this.labelGroups.Text = "Groups";
            // 
            // panelDataBindings
            // 
            this.panelDataBindings.Controls.Add(this.imageNormalPictureBox);
            this.panelDataBindings.Controls.Add(descriptionLabel);
            this.panelDataBindings.Controls.Add(this.descriptionRichTextBox);
            this.panelDataBindings.Location = new System.Drawing.Point(296, 65);
            this.panelDataBindings.Name = "panelDataBindings";
            this.panelDataBindings.Size = new System.Drawing.Size(306, 384);
            this.panelDataBindings.TabIndex = 17;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.groupBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(103, 13);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(110, 100);
            this.imageNormalPictureBox.TabIndex = 3;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Description", true));
            this.descriptionRichTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.descriptionRichTextBox.Location = new System.Drawing.Point(0, 183);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(306, 201);
            this.descriptionRichTextBox.TabIndex = 1;
            this.descriptionRichTextBox.Text = "";
            // 
            // FormGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 542);
            this.Controls.Add(this.labelGroups);
            this.Controls.Add(this.labelPicture);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.panelDataBindings);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)), true);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormGroups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Groups";
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.panelDataBindings.ResumeLayout(false);
            this.panelDataBindings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Label labelPicture;
        private System.Windows.Forms.Label labelGroups;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.Panel panelDataBindings;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
    }
}