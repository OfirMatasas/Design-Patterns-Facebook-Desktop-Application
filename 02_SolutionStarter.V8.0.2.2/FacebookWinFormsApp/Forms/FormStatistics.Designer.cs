namespace BasicFacebookFeatures.Forms
{
    partial class FormStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatistics));
            this.dateTimePickerChoosedMonth = new System.Windows.Forms.DateTimePicker();
            this.labelChooseMonth = new System.Windows.Forms.Label();
            this.labelNumberOfPosts = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerChoosedMonth
            // 
            this.dateTimePickerChoosedMonth.AllowDrop = true;
            this.dateTimePickerChoosedMonth.CustomFormat = "MM-yyyy";
            this.dateTimePickerChoosedMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerChoosedMonth.Location = new System.Drawing.Point(366, 53);
            this.dateTimePickerChoosedMonth.Name = "dateTimePickerChoosedMonth";
            this.dateTimePickerChoosedMonth.Size = new System.Drawing.Size(93, 22);
            this.dateTimePickerChoosedMonth.TabIndex = 1;
            this.dateTimePickerChoosedMonth.ValueChanged += new System.EventHandler(this.dateTimePickerChoosedMonth_ValueChanged);
            // 
            // labelChooseMonth
            // 
            this.labelChooseMonth.AutoSize = true;
            this.labelChooseMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelChooseMonth.Location = new System.Drawing.Point(100, 53);
            this.labelChooseMonth.Name = "labelChooseMonth";
            this.labelChooseMonth.Size = new System.Drawing.Size(196, 20);
            this.labelChooseMonth.TabIndex = 2;
            this.labelChooseMonth.Text = "Please choose a month";
            // 
            // labelNumberOfPosts
            // 
            this.labelNumberOfPosts.AutoSize = true;
            this.labelNumberOfPosts.Location = new System.Drawing.Point(301, 243);
            this.labelNumberOfPosts.Name = "labelNumberOfPosts";
            this.labelNumberOfPosts.Size = new System.Drawing.Size(108, 16);
            this.labelNumberOfPosts.TabIndex = 3;
            this.labelNumberOfPosts.Text = "Number Of Posts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Likes on photos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(160, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(323, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 10;
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNumberOfPosts);
            this.Controls.Add(this.labelChooseMonth);
            this.Controls.Add(this.dateTimePickerChoosedMonth);
            this.Name = "FormStatistics";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerChoosedMonth;
        private System.Windows.Forms.Label labelChooseMonth;
        private System.Windows.Forms.Label labelNumberOfPosts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}