﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public LoginResult LoginResult { get; set; }

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter

            FacebookWrapper.LoginResult loginResult = FacebookService.Login(
                    /// (This is Desig Patter's App ID. replace it with your own)
                    "473768324575372", 
                    /// requested permissions:
					"email",
                    "public_profile"
                    /// add any relevant permissions
                    );
            LoginResult = loginResult;
            buttonLogin.Text = $"Logged in as {loginResult.LoggedInUser.Name}";
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
			FacebookService.LogoutWithUI();
			buttonLogin.Text = "Login";
		}

        private void buttonFavoriteTeams_Click(object sender, EventArgs e)
        {
            FormFavoriteTeams favoriteTeamsForm = new FormFavoriteTeams(LoginResult);
            favoriteTeamsForm.ShowDialog();
        }
    }
}
