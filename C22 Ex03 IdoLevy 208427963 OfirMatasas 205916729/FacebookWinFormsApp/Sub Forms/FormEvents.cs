using System;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures;
using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp.Forms
{
    internal partial class FormEvents : Form
    {
        //---------------------------------------------- Members ----------------------------------------------//
        private FacebookObjectCollection<Event> m_Events;

        //-------------------------------------------- Constructor --------------------------------------------//
        public FormEvents()
        {
            InitializeComponent();
        }

        //--------------------------------------------- On Shown ----------------------------------------------//
        private void fetchEvents()
        {
            m_Events = FacebookAccountManager.Instance.Events;
            listBoxEvents.Invoke(new Action(() => eventBindingSource.DataSource = m_Events));
        }

        protected override void OnShown(EventArgs i_E)
        {
            new Thread(fetchEventsAndNotifyTheUserIfThereAreNoEventsToRecieve).Start();
            base.OnShown(i_E);
        }

        private void fetchEventsAndNotifyTheUserIfThereAreNoEventsToRecieve()
        {
            Cursor.Current = Cursors.WaitCursor;
            fetchEvents();
            nofityTheUserIfThereAreNoEventsToReceive();
            Cursor.Current = Cursors.Default;
        }

        private void nofityTheUserIfThereAreNoEventsToReceive()
        {
            if (m_Events.Count == 0)
            {
                MessageDisplayer.NoItemsAppearOnForm("events");
            }
        }
    }
}
