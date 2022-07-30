using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormFavoriteTeams : Form
    {
        public User User { get; set; }

        public FormFavoriteTeams(User i_User)
        {
            InitializeComponent();
            User = i_User;
        }

        private void listBoxFavoriteTeams_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            if (listBoxFavoriteTeams.SelectedItems.Count == 1)
            {
                Page selectedTeam = listBoxFavoriteTeams.SelectedItem as Page;
                pictureBoxSelectedFavoriteTeam.LoadAsync(selectedTeam.PictureNormalURL);
            }
        }

        private void buttonFetchFavoriteTeams_Click(object i_Sender, EventArgs i_E)
        {
            listBoxFavoriteTeams.Items.Clear();
            listBoxFavoriteTeams.DisplayMember = "Name";
            foreach (Page team in User.FavofriteTeams)
            {
                listBoxFavoriteTeams.Items.Add(team);
            }

            if (listBoxFavoriteTeams.Items.Count == 0)
            {
                MessageBox.Show("No teams to retrieve :(");
            }
        }
    }
}
