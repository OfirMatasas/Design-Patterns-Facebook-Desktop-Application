
namespace BasicFacebookFeatures.Forms
{
    partial class FormEvents
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
            this.pictureBoxEventPicture = new System.Windows.Forms.PictureBox();
            this.richTextBoxEventDescription = new System.Windows.Forms.RichTextBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.panelEventsSection = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventPicture)).BeginInit();
            this.panelEventsSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxEventPicture
            // 
            this.pictureBoxEventPicture.Location = new System.Drawing.Point(484, 311);
            this.pictureBoxEventPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxEventPicture.Name = "pictureBoxEventPicture";
            this.pictureBoxEventPicture.Size = new System.Drawing.Size(308, 260);
            this.pictureBoxEventPicture.TabIndex = 2;
            this.pictureBoxEventPicture.TabStop = false;
            // 
            // richTextBoxEventDescription
            // 
            this.richTextBoxEventDescription.Location = new System.Drawing.Point(412, 65);
            this.richTextBoxEventDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxEventDescription.Name = "richTextBoxEventDescription";
            this.richTextBoxEventDescription.Size = new System.Drawing.Size(443, 238);
            this.richTextBoxEventDescription.TabIndex = 3;
            this.richTextBoxEventDescription.Text = "";
            this.richTextBoxEventDescription.Visible = false;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 25;
            this.listBoxEvents.Location = new System.Drawing.Point(39, 65);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(304, 504);
            this.listBoxEvents.TabIndex = 4;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // panelEventsSection
            // 
            this.panelEventsSection.Controls.Add(this.pictureBoxEventPicture);
            this.panelEventsSection.Controls.Add(this.listBoxEvents);
            this.panelEventsSection.Controls.Add(this.richTextBoxEventDescription);
            this.panelEventsSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEventsSection.Location = new System.Drawing.Point(0, 0);
            this.panelEventsSection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEventsSection.Name = "panelEventsSection";
            this.panelEventsSection.Size = new System.Drawing.Size(1304, 1066);
            this.panelEventsSection.TabIndex = 5;
            // 
            // FormEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 1066);
            this.Controls.Add(this.panelEventsSection);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEvents";
            this.Text = "FormEvents";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventPicture)).EndInit();
            this.panelEventsSection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxEventPicture;
        private System.Windows.Forms.RichTextBox richTextBoxEventDescription;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Panel panelEventsSection;
    }
}