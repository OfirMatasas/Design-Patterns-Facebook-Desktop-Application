using System;
using System.Windows.Forms;
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
        public FormPosts PostsForm { get; set; }

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(m_AccountManager.Login())
            {
                buttonLogin.Text = $"Logged in as {m_AccountManager.LoggedInUser.Name}";
                EnableAllSidebarButtons();
                InitializeAllSubForms();
            }  
        }

        private void EnableAllSidebarButtons()
        {
            foreach(Control control in panelSidebar.Controls)
            {
                control.Enabled = true;
            }
        }

        private void InitializeAllSubForms()
        {
            GroupsForm = new FormGroups(m_AccountManager.LoggedInUser);
            FavoriteTeamsForm = new FormFavoriteTeams(m_AccountManager.LoggedInUser);
            LikedPagesForm = new FormLikedPages(m_AccountManager.LoggedInUser);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
			FacebookService.LogoutWithUI();
			buttonLogin.Text = "Login";
		}

        private void buttonFavoriteTeams_Click(object sender, EventArgs e)
        {
            openChildForm(FavoriteTeamsForm, sender);
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
            openChildForm(LikedPagesForm, sender);
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            openChildForm(GroupsForm, sender);
        }

        private void buttonPosts_Click(object sender, EventArgs e)
        {
            if(PostsForm == null)
            {
                PostsForm = new FormPosts(m_AccountManager);
            }

            openChildForm(PostsForm, sender);
        }
    }
}
