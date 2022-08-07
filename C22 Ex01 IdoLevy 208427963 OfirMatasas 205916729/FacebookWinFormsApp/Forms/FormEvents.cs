using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FaceBookWinFormsApp.Forms
{
    internal partial class FormEvents : Form
    {
        private readonly FacebookObjectCollection<Event> r_Events;

        public FormEvents(FacebookObjectCollection<Event> i_Events)
        {
            InitializeComponent();
            r_Events = i_Events;
            fetchEvents();
        }

        private void fetchEvents()
        {
            foreach (Event facebookEvent in r_Events)
            {
                listBoxEvents.Items.Add(facebookEvent.Name);
            }
        }

        protected override void OnShown(EventArgs i_E)
        {
            base.OnShown(i_E);
            if (listBoxEvents.Items.Count == 0)
            {
                MessageBox.Show("No events to retrieve :(", 
                    "No Events", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }

        private void listBoxEvents_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            Event selectedEvent = listBoxEvents.SelectedItem as Event;

            displaySelectedEventPicture(selectedEvent);
            displaySelectedEventDescription(selectedEvent);
        }

        private void displaySelectedEventPicture(Event i_SelectedEvent)
        {
            pictureBoxEventPicture.LoadAsync(i_SelectedEvent.Cover.SourceURL);
            labelPicture.Visible = true;
        }

        private void displaySelectedEventDescription(Event i_SelectedEvent)
        {
            richTextBoxEventDescription.Text = i_SelectedEvent.Description;
            richTextBoxEventDescription.Visible = true;
            labelDescription.Visible = true;
        }
    }
}
