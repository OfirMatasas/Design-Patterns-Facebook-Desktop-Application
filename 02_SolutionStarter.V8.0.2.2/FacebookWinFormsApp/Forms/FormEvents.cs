using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormEvents : Form
    {
        public User User { get; }

        public FormEvents(User i_User)
        {
            User = i_User;
            InitializeComponent();
            fetchEvents();
        }

        private void fetchEvents()
        {
            listBoxEvents.Items.Clear();
            foreach (Event fbEvent in User.Events)
            {
                listBoxEvents.Items.Add(fbEvent.Name);
            }

            listBoxEvents.Show();
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
            if (listBoxEvents.SelectedItems.Count == 1)
            {
                Event selectedEvent = listBoxEvents.SelectedItem as Event;
                pictureBoxEventPicture.LoadAsync(selectedEvent.Cover.SourceURL);
            }
        }
    }
}
