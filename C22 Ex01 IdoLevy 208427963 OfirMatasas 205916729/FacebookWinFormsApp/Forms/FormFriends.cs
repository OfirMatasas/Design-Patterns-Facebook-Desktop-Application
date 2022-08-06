﻿using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace FaceBookWinFormsApp.Forms
{
    internal partial class FormFriends : Form
    {
        private FacebookObjectCollection<User> m_Friends;

        public FormFriends(FacebookObjectCollection<User> i_Friends)
        {
            InitializeComponent();
            m_Friends = i_Friends;
            fetchFriends();
        }

        private void fetchFriends()
        {
            foreach (User friend in m_Friends)
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
        }

        private void displaySelectedFriendAbout(User i_SelectedFriend)
        {
            richTextBoxFriendAbout.Text = i_SelectedFriend.About;
        }
    }
}