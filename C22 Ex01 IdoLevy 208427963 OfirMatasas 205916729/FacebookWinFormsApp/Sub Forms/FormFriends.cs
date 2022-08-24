using BasicFacebookFeatures;
using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Forms
{
    internal partial class FormFriends : Form
    {
        private readonly FacebookObjectCollection<User> r_Friends;

        public FormFriends()
        {
            InitializeComponent();
            r_Friends = FacebookAccountManager.Instance.User.Friends;
            fetchFriends();
        }

        private void fetchFriends()
        {
            if (!listBoxFriends.InvokeRequired)
            {
                userBindingSource.DataSource = r_Friends;
            }
            else
            {
                listBoxFriends.Invoke(new Action(() => userBindingSource.DataSource = r_Friends));
            }
        }

        protected override void OnShown(EventArgs i_E)
        {
            base.OnShown(i_E);
            if (listBoxFriends.Items.Count == 0)
            {
                MessageDisplayer.NoItemsAppearOnForm("friends");
            }
        }
    }
}
