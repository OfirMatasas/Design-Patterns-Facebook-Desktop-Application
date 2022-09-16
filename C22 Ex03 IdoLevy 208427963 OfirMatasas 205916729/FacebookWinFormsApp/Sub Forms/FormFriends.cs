using System;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures;
using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp.Forms
{
    internal partial class FormFriends : Form
    {
        //---------------------------------------------- Members ----------------------------------------------//
        private FacebookObjectCollection<User> m_Friends;

        //-------------------------------------------- Constructor --------------------------------------------//
        public FormFriends()
        {
            InitializeComponent();
        }

        //--------------------------------------------- On Shown ----------------------------------------------//
        protected override void OnShown(EventArgs i_E)
        {
            new Thread(fetchEventsAndNotifyTheUserIfThereAreNoFriendsToRecieve).Start();
            base.OnShown(i_E);
        }

        private void fetchEventsAndNotifyTheUserIfThereAreNoFriendsToRecieve()
        {
            Cursor.Current = Cursors.WaitCursor;
            fetchFriends();
            nofityTheUserIfThereAreNoFriendsToReceive();
            Cursor.Current = Cursors.Default;
        }

        private void fetchFriends()
        {
            m_Friends = FacebookAccountManager.Instance.Friends;
            listBoxFriends.Invoke(new Action(() => userBindingSource.DataSource = m_Friends));
        }

        private void nofityTheUserIfThereAreNoFriendsToReceive()
        {
            if (m_Friends.Count == 0)
            {
                MessageDisplayer.NoItemsAppearOnForm("friends");
            }
        }
    }
}
