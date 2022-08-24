using BasicFacebookFeatures;
using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Forms
{
    internal partial class FormEvents : Form
    {
        private readonly FacebookObjectCollection<Event> r_Events;

        public FormEvents()
        {
            InitializeComponent();
            r_Events = FacebookAccountManager.Instance.User.Events;
            fetchEvents();
        }

        private void fetchEvents()
        {
            if (!listBoxEvents.InvokeRequired)
            {
                eventBindingSource.DataSource = r_Events;
            }
            else
            {
                listBoxEvents.Invoke(new Action(() => eventBindingSource.DataSource = r_Events));
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
    }
}
