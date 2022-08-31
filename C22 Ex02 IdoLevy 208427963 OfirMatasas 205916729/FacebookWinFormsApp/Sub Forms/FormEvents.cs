using BasicFacebookFeatures;
using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Threading;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Forms
{
    internal partial class FormEvents : Form
    {
        private readonly FacebookObjectCollection<Event> r_Events;

        public FormEvents()
        {
            InitializeComponent();
            r_Events = FacebookAccountManager.Instance.Events;
        }

        private void fetchEvents()
        {
            listBoxEvents.Invoke(new Action(() => eventBindingSource.DataSource = r_Events));
        }

        protected override void OnShown(EventArgs i_E)
        {
            base.OnShown(i_E);
            new Thread(fetchEvents).Start();
            if (r_Events.Count == 0)
            {
                MessageDisplayer.NoItemsAppearOnForm("events");
            }
        }
    }
}
