using BasicFacebookFeatures;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Forms
{
    internal partial class FormFriends : Form
    {
        private readonly FacebookObjectCollection<User> r_Friends;

        public FormFriends(FacebookObjectCollection<User> i_Friends)
        {
            InitializeComponent();
            r_Friends = i_Friends;
            fetchFriends();
        }

        private void fetchFriends()
        {
            listBoxFriends.Text = Name;

            foreach (User friend in r_Friends)
            {
                listBoxFriends.Items.Add(friend);
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

        private void listBoxFriends_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            User selectedFriend = listBoxFriends.SelectedItem as User;

            displaySelectedFriendProfilePicture(selectedFriend);
            displaySelectedFriendAbout(selectedFriend);
        }

        private void displaySelectedFriendProfilePicture(User i_SelectedFriend)
        {
            pictureBoxFriendProfilePicture.Image = i_SelectedFriend.ImageNormal;
        }

        private void displaySelectedFriendAbout(User i_SelectedFriend)
        {
            richTextBoxFriendAbout.Text = i_SelectedFriend.About;
            richTextBoxFriendAbout.Visible = true;
            labelFriendsInformation.Visible = true;
        }
    }
}
