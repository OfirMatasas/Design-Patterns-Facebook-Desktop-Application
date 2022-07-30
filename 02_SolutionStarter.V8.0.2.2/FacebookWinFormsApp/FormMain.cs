using System;
using System.Windows.Forms;
using BasicFacebookFeatures.Forms;
using FacebookWrapper;
using FacebookWinFormsLogic;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private FacebookAccountManager m_AccountManager = new FacebookAccountManager();
        private Form ActiveForm { get; set; }
        private FormFavoriteTeams FavoriteTeamsForm { get; set; }
        private FormLikedPages LikedPagesForm { get; set; }
        private FormGroups GroupsForm { get; set; }
        private FormPosts PostsForm { get; set; }
        private FormEvents EventsForm { get; set; }

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object i_Sender, EventArgs i_E)
        {
            if(m_AccountManager.Login())
            {
                buttonLogin.Text = $"Logged in as {m_AccountManager.LoggedInUser.Name}";
                enableAllSidebarButtons();
            }  
        }

        private void enableAllSidebarButtons()
        {
            foreach(Control control in panelSidebar.Controls)
            {
                control.Enabled = true;
            }
        }

        private void buttonLogout_Click(object i_Sender, EventArgs i_E)
        {
			FacebookService.LogoutWithUI();
			buttonLogin.Text = "Login";
		}

        private void buttonFavoriteTeams_Click(object i_Sender, EventArgs i_E)
        {
            if (FavoriteTeamsForm == null)
            {
                FavoriteTeamsForm = new FormFavoriteTeams(m_AccountManager.LoggedInUser);
            }

            openChildForm(FavoriteTeamsForm, i_Sender);
        }

        private void openChildForm(Form i_ChildForm, object i_Sender)
        {
            ActiveForm?.Hide();
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


        private void buttonLikedPages_Click(object i_Sender, EventArgs i_E)
        {
            if (LikedPagesForm == null)
            {
                LikedPagesForm = new FormLikedPages(m_AccountManager.LoggedInUser);
            }

            openChildForm(LikedPagesForm, i_Sender);
        }

        private void buttonGroups_Click(object i_Sender, EventArgs i_E)
        {
            if (GroupsForm == null)
            {
                GroupsForm = new FormGroups(m_AccountManager.LoggedInUser);
            }

            openChildForm(GroupsForm, i_Sender);
        }

        private void buttonPosts_Click(object i_Sender, EventArgs i_E)
        {
            if(PostsForm == null)
            {
                PostsForm = new FormPosts(m_AccountManager);
            }

            openChildForm(PostsForm, i_Sender);
        }

        private void buttonEvents_Click(object i_Sender, EventArgs i_E)
        {
            if (EventsForm == null)
            {
                EventsForm = new FormEvents(m_AccountManager.LoggedInUser);
            }

            openChildForm(EventsForm, i_Sender);
        }
    }
}
