using System;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures;
using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp.Forms
{
    internal partial class FormGroups : Form
    {
        //---------------------------------------------- Members ----------------------------------------------//
        private FacebookObjectCollection<Group> m_Groups;

        //-------------------------------------------- Constructor --------------------------------------------//
        public FormGroups()
        {
            InitializeComponent();
        }

        //--------------------------------------------- On Shown ----------------------------------------------//
        protected override void OnShown(EventArgs i_E)
        {
            new Thread(fetchEventsAndNotifyTheUserIfThereAreNoGroupsToRecieve).Start();
            base.OnShown(i_E);
        }

        private void fetchEventsAndNotifyTheUserIfThereAreNoGroupsToRecieve()
        {
            Cursor.Current = Cursors.WaitCursor;
            fetchGroups();
            nofityTheUserIfThereAreNoGroupsToReceive();
            Cursor.Current = Cursors.Default;
        }

        private void fetchGroups()
        {
            m_Groups = FacebookAccountManager.Instance.Groups;
            listBoxGroups.Invoke(new Action(() => groupBindingSource.DataSource = m_Groups));
        }

        private void nofityTheUserIfThereAreNoGroupsToReceive()
        {
            if (m_Groups.Count == 0)
            {
                MessageDisplayer.NoItemsAppearOnForm("groups");
            }
        }
    }
}
