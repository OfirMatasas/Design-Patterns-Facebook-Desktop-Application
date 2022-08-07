using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FaceBookWinFormsApp.Forms
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
            foreach (User friend in r_Friends)
            {
                listBoxFriends.Items.Add(friend.Name);
            }
        }

        protected override void OnShown(EventArgs i_E)
        {
            base.OnShown(i_E);
            if (listBoxFriends.Items.Count == 0)
            {
                MessageBox.Show("No friends to retrieve: (", "No Friends", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            User selectedFriend = listBoxFriends.SelectedItem as User;

            displaySelectedFriendProfilePicture(selectedFriend);
            displaySelectedFriendAbout(selectedFriend);
        }

        private void displaySelectedFriendProfilePicture(User i_SelectedFriend)
        {
            pictureBoxFriendProfilePicture.Image = i_SelectedFriend.ImageNormal;
            labelFriendProfilePicture.Visible = true;
        }

        private void displaySelectedFriendAbout(User i_SelectedFriend)
        {
            richTextBoxFriendAbout.Text = i_SelectedFriend.About;
            richTextBoxFriendAbout.Visible = true;
            labelFriendAbout.Visible = true;
        }
    }
}
