using FacebookWrapper.ObjectModel;
using System;
using System.Text;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormFavoriteTeams : Form
    {
        private Page[] FavoriteTeams { get; }

        public FormFavoriteTeams(Page[] i_FavoriteTeams)
        {
            InitializeComponent();
            FavoriteTeams = i_FavoriteTeams;
            fetchFavoriteTeams();
        }

        private void fetchFavoriteTeams()
        {
            listBoxFavoriteTeams.DisplayMember = "Name";
            if(FavoriteTeams != null)
            {
                foreach (Page team in FavoriteTeams)
                {
                    listBoxFavoriteTeams.Items.Add(team);
                }
            }
        }

        protected override void OnShown(EventArgs i_E)
        {
            base.OnShown(i_E);
            if (listBoxFavoriteTeams.Items.Count == 0)
            {
                MessageBox.Show("No favorite teams to retrieve :(");
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
            StringBuilder teamsInfo = new StringBuilder();
            
            teamsInfo.AppendFormat("Description: {0}", i_SelectedTeam.Description).Append(Environment.NewLine);
            teamsInfo.AppendFormat("Category: {0}", i_SelectedTeam.Category).Append(Environment.NewLine);
            teamsInfo.AppendFormat("Likes: {0}", i_SelectedTeam.LikesCount).Append(Environment.NewLine);
            teamsInfo.AppendFormat("Phone number: {0}", i_SelectedTeam.Phone).Append(Environment.NewLine);
            teamsInfo.AppendFormat("Location: {0}", i_SelectedTeam.Location).Append(Environment.NewLine);
            teamsInfo.AppendFormat("Website: {0}", i_SelectedTeam.Website).Append(Environment.NewLine);
            richTextBoxSelectedTeamInfo.Text = teamsInfo.ToString();
            richTextBoxSelectedTeamInfo.Visible = true;
        }
    }
}
