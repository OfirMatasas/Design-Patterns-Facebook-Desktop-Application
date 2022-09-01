namespace FacebookWinFormsApp.Forms
{
    internal partial class FormEvents
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
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelDataBindings = new System.Windows.Forms.Panel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.labelPicture = new System.Windows.Forms.Label();
            this.labelEvent = new System.Windows.Forms.Label();
            this.panelEventsSection = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            this.panelDataBindings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.panelEventsSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // panelDataBindings
            // 
            this.panelDataBindings.Controls.Add(this.labelDescription);
            this.panelDataBindings.Controls.Add(this.descriptionRichTextBox);
            this.panelDataBindings.Controls.Add(this.imageNormalPictureBox);
            this.panelDataBindings.Location = new System.Drawing.Point(282, 68);
            this.panelDataBindings.Name = "panelDataBindings";
            this.panelDataBindings.Size = new System.Drawing.Size(224, 285);
            this.panelDataBindings.TabIndex = 13;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDescription.Location = new System.Drawing.Point(49, 4);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(115, 24);
            this.labelDescription.TabIndex = 7;
            this.labelDescription.Text = "Description";
            this.labelDescription.Visible = false;
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.descriptionRichTextBox.Location = new System.Drawing.Point(0, 31);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(224, 126);
            this.descriptionRichTextBox.TabIndex = 14;
            this.descriptionRichTextBox.Text = string.Empty;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(64, 183);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(100, 101);
            this.imageNormalPictureBox.TabIndex = 16;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.DataSource = this.eventBindingSource;
            this.listBoxEvents.DisplayMember = "Name";
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(54, 68);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(189, 342);
            this.listBoxEvents.TabIndex = 4;
            // 
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPicture.Location = new System.Drawing.Point(349, 239);
            this.labelPicture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(0, 24);
            this.labelPicture.TabIndex = 6;
            this.labelPicture.Visible = false;
            // 
            // labelEvent
            // 
            this.labelEvent.AutoSize = true;
            this.labelEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEvent.Location = new System.Drawing.Point(241, 6);
            this.labelEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEvent.Name = "labelEvent";
            this.labelEvent.Size = new System.Drawing.Size(104, 31);
            this.labelEvent.TabIndex = 12;
            this.labelEvent.Text = "Events";
            // 
            // panelEventsSection
            // 
            this.panelEventsSection.BackColor = System.Drawing.Color.White;
            this.panelEventsSection.Controls.Add(this.labelEvent);
            this.panelEventsSection.Controls.Add(this.labelPicture);
            this.panelEventsSection.Controls.Add(this.listBoxEvents);
            this.panelEventsSection.Controls.Add(this.panelDataBindings);
            this.panelEventsSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEventsSection.Location = new System.Drawing.Point(0, 0);
            this.panelEventsSection.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelEventsSection.Name = "panelEventsSection";
            this.panelEventsSection.Size = new System.Drawing.Size(627, 502);
            this.panelEventsSection.TabIndex = 5;
            // 
            // FormEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 502);
            this.Controls.Add(this.panelEventsSection);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormEvents";
            this.Text = "FormEvents";
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            this.panelDataBindings.ResumeLayout(false);
            this.panelDataBindings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.panelEventsSection.ResumeLayout(false);
            this.panelEventsSection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.Panel panelDataBindings;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Label labelPicture;
        private System.Windows.Forms.Label labelEvent;
        private System.Windows.Forms.Panel panelEventsSection;
    }
}