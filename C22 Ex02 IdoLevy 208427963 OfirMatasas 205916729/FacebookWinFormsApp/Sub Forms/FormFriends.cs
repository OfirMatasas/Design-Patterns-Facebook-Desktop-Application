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
        }

        private void fetchFriends()
        {
            listBoxFriends.Invoke(new Action(() => userBindingSource.DataSource = r_Friends));
        }

        protected override void OnShown(EventArgs i_E)
        {
            base.OnShown(i_E);
            fetchFriends();
            if (listBoxFriends.Items.Count == 0)
            {
                MessageDisplayer.NoItemsAppearOnForm("friends");
            }
        }
    }
}
