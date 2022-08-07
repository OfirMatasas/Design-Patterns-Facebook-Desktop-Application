namespace FaceBookWinFormsApp.Forms
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
            this.pictureBoxEventPicture = new System.Windows.Forms.PictureBox();
            this.richTextBoxEventDescription = new System.Windows.Forms.RichTextBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.panelEventsSection = new System.Windows.Forms.Panel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPicture = new System.Windows.Forms.Label();
            this.labelEvents = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventPicture)).BeginInit();
            this.panelEventsSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxEventPicture
            // 
            this.pictureBoxEventPicture.Location = new System.Drawing.Point(404, 337);
            this.pictureBoxEventPicture.Name = "pictureBoxEventPicture";
            this.pictureBoxEventPicture.Size = new System.Drawing.Size(205, 166);
            this.pictureBoxEventPicture.TabIndex = 2;
            this.pictureBoxEventPicture.TabStop = false;
            // 
            // richTextBoxEventDescription
            // 
            this.richTextBoxEventDescription.Location = new System.Drawing.Point(360, 122);
            this.richTextBoxEventDescription.Name = "richTextBoxEventDescription";
            this.richTextBoxEventDescription.Size = new System.Drawing.Size(297, 154);
            this.richTextBoxEventDescription.TabIndex = 3;
            this.richTextBoxEventDescription.Text = string.Empty;
            this.richTextBoxEventDescription.Visible = false;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(72, 83);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(251, 420);
            this.listBoxEvents.TabIndex = 4;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // panelEventsSection
            // 
            this.panelEventsSection.Controls.Add(this.labelDescription);
            this.panelEventsSection.Controls.Add(this.labelPicture);
            this.panelEventsSection.Controls.Add(this.labelEvents);
            this.panelEventsSection.Controls.Add(this.pictureBoxEventPicture);
            this.panelEventsSection.Controls.Add(this.listBoxEvents);
            this.panelEventsSection.Controls.Add(this.richTextBoxEventDescription);
            this.panelEventsSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEventsSection.Location = new System.Drawing.Point(0, 0);
            this.panelEventsSection.Name = "panelEventsSection";
            this.panelEventsSection.Size = new System.Drawing.Size(764, 583);
            this.panelEventsSection.TabIndex = 5;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDescription.Location = new System.Drawing.Point(446, 83);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(115, 24);
            this.labelDescription.TabIndex = 7;
            this.labelDescription.Text = "Description";
            this.labelDescription.Visible = false;
            // 
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPicture.Location = new System.Drawing.Point(465, 294);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(75, 24);
            this.labelPicture.TabIndex = 6;
            this.labelPicture.Text = "Picture";
            this.labelPicture.Visible = false;
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEvents.Location = new System.Drawing.Point(149, 43);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(73, 24);
            this.labelEvents.TabIndex = 5;
            this.labelEvents.Text = "Events";
            // 
            // FormEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 583);
            this.Controls.Add(this.panelEventsSection);
            this.Name = "FormEvents";
            this.Text = "FormEvents";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventPicture)).EndInit();
            this.panelEventsSection.ResumeLayout(false);
            this.panelEventsSection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxEventPicture;
        private System.Windows.Forms.RichTextBox richTextBoxEventDescription;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Panel panelEventsSection;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelPicture;
        private System.Windows.Forms.Label labelEvents;
    }
}