using System;
using System.Windows.Forms;
using BasicFacebookFeatures;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp.Forms
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
            listBoxEvents.Text = Name;

            foreach (Event facebookEvent in r_Events)
            {
                listBoxEvents.Items.Add(facebookEvent);
            }
        }

        protected override void OnShown(EventArgs i_E)
        {
            base.OnShown(i_E);
            if (listBoxEvents.Items.Count == 0)
            {
                MessageDisplayer.NoItemsAppearOnForm("events");
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
            richTextBoxEventDescription.Text = string.Format("{0}{1}{1}", i_SelectedEvent.Name, Environment.NewLine);
            richTextBoxEventDescription.Text += i_SelectedEvent.Description;
            richTextBoxEventDescription.Visible = true;
            labelDescription.Visible = true;
        }
    }
}
