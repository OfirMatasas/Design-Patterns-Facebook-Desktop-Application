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
            this.pictureBoxEventPicture = new System.Windows.Forms.PictureBox();
            this.richTextBoxEventDescription = new System.Windows.Forms.RichTextBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.panelEventsSection = new System.Windows.Forms.Panel();
            this.labelEvent = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPicture = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventPicture)).BeginInit();
            this.panelEventsSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxEventPicture
            // 
            this.pictureBoxEventPicture.Location = new System.Drawing.Point(454, 422);
            this.pictureBoxEventPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxEventPicture.Name = "pictureBoxEventPicture";
            this.pictureBoxEventPicture.Size = new System.Drawing.Size(231, 207);
            this.pictureBoxEventPicture.TabIndex = 2;
            this.pictureBoxEventPicture.TabStop = false;
            // 
            // richTextBoxEventDescription
            // 
            this.richTextBoxEventDescription.Location = new System.Drawing.Point(405, 153);
            this.richTextBoxEventDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxEventDescription.Name = "richTextBoxEventDescription";
            this.richTextBoxEventDescription.Size = new System.Drawing.Size(334, 191);
            this.richTextBoxEventDescription.TabIndex = 3;
            this.richTextBoxEventDescription.Text = "";
            this.richTextBoxEventDescription.Visible = false;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 20;
            this.listBoxEvents.Location = new System.Drawing.Point(81, 104);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(282, 524);
            this.listBoxEvents.TabIndex = 4;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // panelEventsSection
            // 
            this.panelEventsSection.BackColor = System.Drawing.Color.White;
            this.panelEventsSection.Controls.Add(this.labelEvent);
            this.panelEventsSection.Controls.Add(this.labelDescription);
            this.panelEventsSection.Controls.Add(this.labelPicture);
            this.panelEventsSection.Controls.Add(this.pictureBoxEventPicture);
            this.panelEventsSection.Controls.Add(this.listBoxEvents);
            this.panelEventsSection.Controls.Add(this.richTextBoxEventDescription);
            this.panelEventsSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEventsSection.Location = new System.Drawing.Point(0, 0);
            this.panelEventsSection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelEventsSection.Name = "panelEventsSection";
            this.panelEventsSection.Size = new System.Drawing.Size(982, 844);
            this.panelEventsSection.TabIndex = 5;
            // 
            // labelEvent
            // 
            this.labelEvent.AutoSize = true;
            this.labelEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEvent.Location = new System.Drawing.Point(361, 9);
            this.labelEvent.Name = "labelEvent";
            this.labelEvent.Size = new System.Drawing.Size(147, 46);
            this.labelEvent.TabIndex = 12;
            this.labelEvent.Text = "Events";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDescription.Location = new System.Drawing.Point(492, 104);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(169, 32);
            this.labelDescription.TabIndex = 7;
            this.labelDescription.Text = "Description";
            this.labelDescription.Visible = false;
            // 
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPicture.Location = new System.Drawing.Point(524, 367);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(0, 32);
            this.labelPicture.TabIndex = 6;
            this.labelPicture.Visible = false;
            // 
            // FormEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 844);
            this.Controls.Add(this.panelEventsSection);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Label labelEvent;
    }
}