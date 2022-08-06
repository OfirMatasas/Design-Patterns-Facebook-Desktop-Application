using FacebookWrapper.ObjectModel;
using System;
using System.Text;
using System.Windows.Forms;

namespace FaceBookWinFormsApp.Forms
{
    internal partial class FormFavoriteTeams : Form
    {
        private Page[] m_FavoriteTeams;

        public FormFavoriteTeams(Page[] i_FavoriteTeams)
        {
            InitializeComponent();
            m_FavoriteTeams = i_FavoriteTeams;
            fetchFavoriteTeams();
        }

        private void fetchFavoriteTeams()
        {
            foreach (Page favoriteTeam in m_FavoriteTeams)
            {
                listBoxFavoriteTeams.Items.Add(favoriteTeam);
            }
        }

        protected override void OnShown(EventArgs i_E)
        {
            base.OnShown(i_E);
            if (listBoxFavoriteTeams.Items.Count == 0)
            {
                MessageBox.Show("No favorite teams to retrieve: (", "No Favorite Teams",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listBoxFavoriteTeams_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            Page selectedTeam = listBoxFavoriteTeams.SelectedItem as Page;

            displaySelectedTeamPicture(selectedTeam);
            displaySelectedTeamInformation(selectedTeam);
        }

        private void displaySelectedTeamPicture(Page i_SelectedTeam)
        {
            pictureBoxSelectedFavoriteTeam.LoadAsync(i_SelectedTeam.PictureNormalURL);
        }

        private void displaySelectedTeamInformation(Page i_SelectedTeam)
        {
            string favoriteTeamsInformation = string.Format(
@"Description: {0}
Category: {1}
Likes: {2}
Phone number: {3}
Location: {4}
Website: {5}",
i_SelectedTeam.Description,
i_SelectedTeam.Category,
i_SelectedTeam.LikesCount,
i_SelectedTeam.Phone,
i_SelectedTeam.Location,
i_SelectedTeam.Website);
            richTextBoxSelectedTeamInfo.Text = favoriteTeamsInformation.ToString();
            richTextBoxSelectedTeamInfo.Visible = true;
            labelTeamInformation.Visible = true;
        }
    }
}
