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
        private AppSetting m_AppSetting;
        private Form ActiveForm { get; set; }
        private FormFavoriteTeams FavoriteTeamsForm { get; set; }
        private FormLikedPages LikedPagesForm { get; set; }
        private FormGroups GroupsForm { get; set; }
        private FormPosts PostsForm { get; set; }
        private FormEvents EventsForm { get; set; }
        private FormAlbums AlbumsForm { get; set; }


        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;

            m_AppSetting = AppSetting.LoadFromFile();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            checkBoxRememberMe.Checked = m_AppSetting.RememberUser;

            if (m_AppSetting.RememberUser && !string.IsNullOrEmpty(m_AppSetting.LastAccessToken))
            {
                m_AccountManager.LoginResult = FacebookService.Connect(m_AppSetting.LastAccessToken);
                populateUI();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            m_AppSetting.RememberUser = checkBoxRememberMe.Checked;
            m_AppSetting.LastAccessToken = m_AppSetting.RememberUser ? m_AccountManager.LoginResult.AccessToken : null;
            m_AppSetting.SaveToFile();
        }


        private void enableAllSidebarButtons()
        {
            foreach(Control control in panelSidebar.Controls)
            {
                control.Enabled = true;
            }
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

        private void buttonFavoriteTeams_Click(object i_Sender, EventArgs i_E)
        {
            if (FavoriteTeamsForm == null)
            {
                FavoriteTeamsForm = new FormFavoriteTeams(m_AccountManager.LoginResult.LoggedInUser.FavofriteTeams);
            }

            openChildForm(FavoriteTeamsForm, i_Sender);
        }

        private void buttonLikedPages_Click(object i_Sender, EventArgs i_E)
        {
            if (LikedPagesForm == null)
            {
                LikedPagesForm = new FormLikedPages(m_AccountManager.LoginResult.LoggedInUser.LikedPages);
            }

            openChildForm(LikedPagesForm, i_Sender);
        }

        private void buttonGroups_Click(object i_Sender, EventArgs i_E)
        {
            if (GroupsForm == null)
            {
                GroupsForm = new FormGroups(m_AccountManager.LoginResult.LoggedInUser.Groups);
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
                EventsForm = new FormEvents(m_AccountManager.LoginResult.LoggedInUser.Events);
            }

            openChildForm(EventsForm, i_Sender);
        }

        private void buttonAlbums_Click(object i_Sender, EventArgs i_E)
        {
            if (AlbumsForm == null)
            {
                AlbumsForm = new FormAlbums(m_AccountManager.LoginResult.LoggedInUser.Albums);
            }

            openChildForm(AlbumsForm, i_Sender);
        }

        private void buttonLogout_Click(object i_Sender, EventArgs i_E)
        {
            FacebookService.LogoutWithUI();
            //buttonLogin.Text = "Login";

            

            ActiveForm?.Hide();
            //visibleAllLoginButtons();
        }

        private void populateUI()
        {
            //buttonLogin.Text = $"Logged in as {m_AccountManager.LoggedInUser.Name}";
            enableAllSidebarButtons();
            //hideAllLoginButtons();
            //FormProfile..
            pictureBoxProfilePicture.Image = m_AccountManager.LoginResult.LoggedInUser.ImageSmall;
            labelProfileName.Text = m_AccountManager.LoginResult.LoggedInUser.Name;
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            if (m_AccountManager.Login())
            {
                populateUI();
            }
        }

        private void visibleAllLoginButtons()
        {
            buttonLogin.Visible = true;
            checkBoxRememberMe.Visible = true;
        }

        private void hideAllLoginButtons()
        {
            buttonLogin.Visible = false;
            checkBoxRememberMe.Visible = false;
        }
    }
}
