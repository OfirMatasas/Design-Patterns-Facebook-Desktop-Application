namespace BasicFacebookFeatures
{
    partial class FormGroups
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
            this.buttonFetchGroups = new System.Windows.Forms.Button();
            this.pictureBoxSelectedGroup = new System.Windows.Forms.PictureBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.richTextBoxGroupSelectedDescription = new System.Windows.Forms.RichTextBox();
            this.labelGroupSelectedPicture = new System.Windows.Forms.Label();
            this.labelGroupDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFetchGroups
            // 
            this.buttonFetchGroups.AutoSize = true;
            this.buttonFetchGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchGroups.Location = new System.Drawing.Point(48, 16);
            this.buttonFetchGroups.Name = "buttonFetchGroups";
            this.buttonFetchGroups.Size = new System.Drawing.Size(193, 30);
            this.buttonFetchGroups.TabIndex = 8;
            this.buttonFetchGroups.Text = "Fetch Groups";
            this.buttonFetchGroups.UseVisualStyleBackColor = true;
            this.buttonFetchGroups.Click += new System.EventHandler(this.buttonFetchGroups_Click);
            // 
            // pictureBoxSelectedGroup
            // 
            this.pictureBoxSelectedGroup.Location = new System.Drawing.Point(454, 87);
            this.pictureBoxSelectedGroup.Name = "pictureBoxSelectedGroup";
            this.pictureBoxSelectedGroup.Size = new System.Drawing.Size(130, 130);
            this.pictureBoxSelectedGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxSelectedGroup.TabIndex = 7;
            this.pictureBoxSelectedGroup.TabStop = false;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 21;
            this.listBoxGroups.Location = new System.Drawing.Point(48, 52);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(328, 445);
            this.listBoxGroups.TabIndex = 6;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // richTextBoxGroupSelectedDescription
            // 
            this.richTextBoxGroupSelectedDescription.Location = new System.Drawing.Point(420, 281);
            this.richTextBoxGroupSelectedDescription.Name = "richTextBoxGroupSelectedDescription";
            this.richTextBoxGroupSelectedDescription.Size = new System.Drawing.Size(215, 216);
            this.richTextBoxGroupSelectedDescription.TabIndex = 9;
            this.richTextBoxGroupSelectedDescription.Text = "";
            // 
            // labelGroupSelectedPicture
            // 
            this.labelGroupSelectedPicture.AutoSize = true;
            this.labelGroupSelectedPicture.Location = new System.Drawing.Point(464, 52);
            this.labelGroupSelectedPicture.Name = "labelGroupSelectedPicture";
            this.labelGroupSelectedPicture.Size = new System.Drawing.Size(120, 20);
            this.labelGroupSelectedPicture.TabIndex = 10;
            this.labelGroupSelectedPicture.Text = "Group Picture";
            // 
            // labelGroupDescription
            // 
            this.labelGroupDescription.AutoSize = true;
            this.labelGroupDescription.Location = new System.Drawing.Point(450, 248);
            this.labelGroupDescription.Name = "labelGroupDescription";
            this.labelGroupDescription.Size = new System.Drawing.Size(155, 20);
            this.labelGroupDescription.TabIndex = 11;
            this.labelGroupDescription.Text = "Group Description";
            // 
            // FormGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(681, 513);
            this.Controls.Add(this.labelGroupDescription);
            this.Controls.Add(this.labelGroupSelectedPicture);
            this.Controls.Add(this.richTextBoxGroupSelectedDescription);
            this.Controls.Add(this.buttonFetchGroups);
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

        private System.Windows.Forms.Button buttonFetchGroups;
        private System.Windows.Forms.PictureBox pictureBoxSelectedGroup;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.RichTextBox richTextBoxGroupSelectedDescription;
        private System.Windows.Forms.Label labelGroupSelectedPicture;
        private System.Windows.Forms.Label labelGroupDescription;
    }
}