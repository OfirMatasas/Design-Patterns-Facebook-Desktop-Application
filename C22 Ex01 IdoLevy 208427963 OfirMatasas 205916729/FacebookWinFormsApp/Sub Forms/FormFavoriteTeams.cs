﻿using BasicFacebookFeatures;
using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Forms
{
    internal partial class FormFavoriteTeams : Form
    {
        private readonly Page[] r_FavoriteTeams;

        public FormFavoriteTeams()
        {
            InitializeComponent();
            r_FavoriteTeams = FacebookAccountManager.Instance.User.FavofriteTeams;
            fetchFavoriteTeams();
        }

        private void fetchFavoriteTeams()
        {
            listBoxFavoriteTeams.Text = Name;

            if (r_FavoriteTeams != null)
            {
                foreach (Page favoriteTeam in r_FavoriteTeams)
                {
                    listBoxFavoriteTeams.Items.Add(favoriteTeam);
                }
            }
        }

        protected override void OnShown(EventArgs i_E)
        {
            base.OnShown(i_E);
            if (listBoxFavoriteTeams.Items.Count == 0)
            {
                MessageDisplayer.NoItemsAppearOnForm("favorite teams");
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
            richTextBoxSelectedTeamInfo.Text = string.Format(
@"Name: {0}
Description: {1}
Category: {2}
Likes: {3}
Phone number: {4}
Location: {5}
Website: {6}",
i_SelectedTeam.Name,
i_SelectedTeam.Description,
i_SelectedTeam.Category,
i_SelectedTeam.LikesCount,
i_SelectedTeam.Phone,
i_SelectedTeam.Location,
i_SelectedTeam.Website);
            richTextBoxSelectedTeamInfo.Visible = true;
            labelTeamInformation.Visible = true;
        }
    }
}
