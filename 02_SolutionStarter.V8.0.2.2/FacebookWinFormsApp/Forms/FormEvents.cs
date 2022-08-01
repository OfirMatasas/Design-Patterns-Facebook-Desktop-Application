using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormEvents : Form
    {
        public FacebookObjectCollection<Event> FBEvents { get; }

        public FormEvents(FacebookObjectCollection<Event> i_Events)
        {
            InitializeComponent();
            FBEvents = i_Events;
            fetchEvents();
        }

        private void fetchEvents()
        {
            foreach (Event fbEvent in FBEvents)
            {
                listBoxEvents.Items.Add(fbEvent.Name);
            }
        }

        protected override void OnShown(EventArgs i_E)
        {
            base.OnShown(i_E);
            if (listBoxEvents.Items.Count == 0)
            {
                MessageBox.Show("No events to retrieve :(");
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
        }

        private void displaySelectedEventDescription(Event i_SelectedEvent)
        {
            richTextBoxEventDescription.Text = i_SelectedEvent.Description;
            richTextBoxEventDescription.Visible = true;
        }
    }
}
