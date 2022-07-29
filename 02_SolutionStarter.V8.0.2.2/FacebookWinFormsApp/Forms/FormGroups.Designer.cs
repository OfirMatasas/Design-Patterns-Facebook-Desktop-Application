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
            this.pictureBoxSelectedGroup.Location = new System.Drawing.Point(369, 387);
            this.pictureBoxSelectedGroup.Name = "pictureBoxSelectedGroup";
            this.pictureBoxSelectedGroup.Size = new System.Drawing.Size(110, 110);
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
            this.listBoxGroups.Size = new System.Drawing.Size(431, 445);
            this.listBoxGroups.TabIndex = 6;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // FormGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(527, 513);
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
    }
}