using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormFavoriteTeams : Form
    {
        public LoginResult LoginResult { get; set; }

        public FormFavoriteTeams(LoginResult i_LoginResult)
        {
            InitializeComponent();
            LoginResult = i_LoginResult;
        }

        private void listBoxFavoriteTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFavoriteTeams.SelectedItems.Count == 1)
            {
                Page selectedTeam = listBoxFavoriteTeams.SelectedItem as Page;
                pictureBoxFavoriteTeam.LoadAsync(selectedTeam.PictureNormalURL);
            }
        }

        private void buttonFetchFavoriteTeams_Click(object sender, EventArgs e)
        {
            listBoxFavoriteTeams.Items.Clear();
            listBoxFavoriteTeams.DisplayMember = "Name";
            foreach (Page team in LoginResult.LoggedInUser.FavofriteTeams)
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
