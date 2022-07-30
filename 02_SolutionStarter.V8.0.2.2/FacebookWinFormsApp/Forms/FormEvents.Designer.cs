
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
            this.pictureBoxEventPicture.Location = new System.Drawing.Point(357, 249);
            this.pictureBoxEventPicture.Name = "pictureBoxEventPicture";
            this.pictureBoxEventPicture.Size = new System.Drawing.Size(231, 208);
            this.pictureBoxEventPicture.TabIndex = 2;
            this.pictureBoxEventPicture.TabStop = false;
            // 
            // richTextBoxEventDescription
            // 
            this.richTextBoxEventDescription.Location = new System.Drawing.Point(309, 52);
            this.richTextBoxEventDescription.Name = "richTextBoxEventDescription";
            this.richTextBoxEventDescription.Size = new System.Drawing.Size(333, 191);
            this.richTextBoxEventDescription.TabIndex = 3;
            this.richTextBoxEventDescription.Text = "";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 20;
            this.listBoxEvents.Location = new System.Drawing.Point(29, 52);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(229, 404);
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
            this.panelEventsSection.Name = "panelEventsSection";
            this.panelEventsSection.Size = new System.Drawing.Size(1467, 1280);
            this.panelEventsSection.TabIndex = 5;
            // 
            // FormEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 853);
            this.Controls.Add(this.panelEventsSection);
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