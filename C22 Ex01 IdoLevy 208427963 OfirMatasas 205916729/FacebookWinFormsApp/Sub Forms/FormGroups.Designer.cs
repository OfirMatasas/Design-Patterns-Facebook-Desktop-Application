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
            this.pictureBoxSelectedGroup = new System.Windows.Forms.PictureBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.richTextBoxGroupSelectedDescription = new System.Windows.Forms.RichTextBox();
            this.labelPicture = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelGroups = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSelectedGroup
            // 
            this.pictureBoxSelectedGroup.Location = new System.Drawing.Point(384, 94);
            this.pictureBoxSelectedGroup.Name = "pictureBoxSelectedGroup";
            this.pictureBoxSelectedGroup.Size = new System.Drawing.Size(189, 159);
            this.pictureBoxSelectedGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelectedGroup.TabIndex = 7;
            this.pictureBoxSelectedGroup.TabStop = false;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 28;
            this.listBoxGroups.Location = new System.Drawing.Point(78, 94);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(210, 452);
            this.listBoxGroups.TabIndex = 6;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // richTextBoxGroupSelectedDescription
            // 
            this.richTextBoxGroupSelectedDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.richTextBoxGroupSelectedDescription.Location = new System.Drawing.Point(311, 313);
            this.richTextBoxGroupSelectedDescription.Name = "richTextBoxGroupSelectedDescription";
            this.richTextBoxGroupSelectedDescription.Size = new System.Drawing.Size(322, 205);
            this.richTextBoxGroupSelectedDescription.TabIndex = 9;
            this.richTextBoxGroupSelectedDescription.Text = "";
            this.richTextBoxGroupSelectedDescription.Visible = false;
            // 
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPicture.Location = new System.Drawing.Point(339, 94);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(0, 28);
            this.labelPicture.TabIndex = 11;
            this.labelPicture.Visible = false;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDescription.Location = new System.Drawing.Point(421, 282);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(115, 28);
            this.labelDescription.TabIndex = 12;
            this.labelDescription.Text = "Description";
            this.labelDescription.Visible = false;
            // 
            // labelGroups
            // 
            this.labelGroups.AutoSize = true;
            this.labelGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGroups.Location = new System.Drawing.Point(256, 12);
            this.labelGroups.Name = "labelGroups";
            this.labelGroups.Size = new System.Drawing.Size(157, 46);
            this.labelGroups.TabIndex = 16;
            this.labelGroups.Text = "Groups";
            // 
            // FormGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 845);
            this.Controls.Add(this.labelGroups);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelPicture);
            this.Controls.Add(this.richTextBoxGroupSelectedDescription);
            this.Controls.Add(this.pictureBoxSelectedGroup);
            this.Controls.Add(this.listBoxGroups);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)), true);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormGroups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Groups";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxSelectedGroup;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.RichTextBox richTextBoxGroupSelectedDescription;
        private System.Windows.Forms.Label labelPicture;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelGroups;
    }
}