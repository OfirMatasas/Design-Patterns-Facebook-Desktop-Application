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
using FacebookWinFormsLogic;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private FacebookAccountManager m_AccountManager = new FacebookAccountManager();
        public Form ActiveForm { get; set; }
        public FormFavoriteTeams FavoriteTeamsForm { get; set; }
        public FormLikedPages LikedPagesForm { get; set; }
        public FormGroups GroupsForm { get; set; }


        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(m_AccountManager.Login())
            {
                buttonLogin.Text = $"Logged in as {m_AccountManager.LoggedInUser.Name}";
            }  
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
			FacebookService.LogoutWithUI();
			buttonLogin.Text = "Login";
		}

        private void buttonFavoriteTeams_Click(object sender, EventArgs e)
        {
            FavoriteTeamsForm = new FormFavoriteTeams(m_AccountManager.LoggedInUser);
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


        private void buttonLikedPages_Click(object sender, EventArgs e)
        {
            LikedPagesForm = new FormLikedPages(m_AccountManager.LoggedInUser);
            openChildForm(LikedPagesForm, sender);
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            GroupsForm = new FormGroups(m_AccountManager.LoggedInUser);
            openChildForm(GroupsForm, sender);
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
