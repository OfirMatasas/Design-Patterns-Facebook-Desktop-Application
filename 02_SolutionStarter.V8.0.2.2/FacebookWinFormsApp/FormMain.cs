using System;
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
        public Form ActiveForm { get; set; }

        public FormFavoriteTeams FavoriteTeamsForm { get; set; }

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
            
            FavoriteTeamsForm = new FormFavoriteTeams(LoginResult);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
			FacebookService.LogoutWithUI();
			buttonLogin.Text = "Login";
		}

        private void buttonFavoriteTeams_Click(object sender, EventArgs e)
        {
            openChildForm(FavoriteTeamsForm, sender);
            //FavoriteTeamsForm.ShowDialog();
        }

        private void openChildForm(Form i_ChildForm, object i_Sender)
        {
            ActiveForm?.Close();
            //selectButton(i_Sender);
            ActiveForm = i_ChildForm;
            i_ChildForm.TopLevel = false;
            i_ChildForm.FormBorderStyle = FormBorderStyle.None;
            i_ChildForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(i_ChildForm);
            panel2.Tag = i_ChildForm;
            i_ChildForm.BringToFront();
            i_ChildForm.Show();
            //labelTitleBar.Text = i_ChildForm.Text;
        }

        //private void buttonEvents_Click(object i_Sender, EventArgs e)
        //{
        //    openChildForm(new Forms.FormPosts(r_FacebookUserManager), i_Sender);
        //}

        //private void buttonFeature1_Click(object i_Sender, EventArgs e)
        //{
        //    openChildForm(new Forms.FormCollage(r_FacebookUserManager), i_Sender);
        //}


    }
}
