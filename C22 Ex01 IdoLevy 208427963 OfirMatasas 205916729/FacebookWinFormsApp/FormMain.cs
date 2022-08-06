using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWinFormsLogic;
using FaceBookWinFormsApp.Forms;

namespace FaceBookWinFormsApp
{
    internal partial class FormMain : Form
    {
        private AppSetting m_AppSetting;
        private FacebookAccountManager m_AccountManager = new FacebookAccountManager();
        private Form m_ActivateForm;
        private FormProfile m_ProfileForm;
        private FormPosts m_PostsForm;
        private FormAlbums m_AlbumsForm;
        private FormEvents m_EventsForm;
        private FormGroups m_GroupsForm;
        private FormFavoriteTeams m_FavoriteTeamsForm;
        private FormLikedPages m_LikedPagesForm;
        private FormFriends m_FriendsForm;
        private FormStatistics m_StatisticsForm;
        private FormMostPopularFeed m_MostPopularFeedForm;

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
            m_AppSetting = AppSetting.LoadFromFile();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            checkBoxRememberMe.Checked = m_AppSetting.RememberUserInfo;
            displayLoginControllers(!m_AppSetting.RememberUserInfo);
            if (m_AppSetting.RememberUserInfo && !string.IsNullOrEmpty(m_AppSetting.LastAccessToken))
            {
                m_AccountManager.Connect(m_AppSetting.LastAccessToken);
                populateUI();
            }
        }

        private void displayLoginControllers(bool i_ToDisplay)
        {
            foreach (Control control in panelLogin.Controls)
            {
                control.Visible = i_ToDisplay;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (m_AccountManager.Login())
            {
                populateUI();
                if (checkBoxRememberMe.Checked)
                {
                    m_AppSetting.RememberUser(m_AccountManager.LoginResult.AccessToken);
                }
            }
            else
            {
                MessageBox.Show($"You must login to facebook !",
                   "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void populateUI()
        {
            displayUsersProfileInfoOnSidebar();
            enableAllSidebarButtons();
            showUsersProfileForm(null, null);
        }

        private void displayUsersProfileInfoOnSidebar()
        {
            pictureBoxProfilePicture.Image = m_AccountManager.LoginResult.LoggedInUser.ImageSmall;
            labelProfileName.Text = m_AccountManager.LoginResult.LoggedInUser.Name;
            labelProfileName.Visible = true;
        }

        private void enableAllSidebarButtons()
        {
            foreach (Control control in panelSidebarButtons.Controls)
            {
                control.Enabled = true;
            }
        }

        private void openSubForm(Form i_SubForm)
        {
            m_ActivateForm?.Hide();
            m_ActivateForm = i_SubForm;
            i_SubForm.TopLevel = false;
            i_SubForm.FormBorderStyle = FormBorderStyle.None;
            i_SubForm.Dock = DockStyle.Fill;
            panelLogin.Controls.Add(i_SubForm);
            i_SubForm.BringToFront();
            i_SubForm.Show();
        }

        private void showUsersProfileForm(object i_Sender, EventArgs i_E)
        {
            if (m_ProfileForm == null)
            {
                m_ProfileForm = new FormProfile(m_AccountManager.LoginResult.LoggedInUser);
            }

            openSubForm(m_ProfileForm);
        }       

        private void buttonPosts_Click(object i_Sender, EventArgs i_E)
        {
            if (m_PostsForm == null)
            {
                m_PostsForm = new FormPosts(m_AccountManager);
            }

            openSubForm(m_PostsForm);
        }

        private void buttonAlbums_Click(object i_Sender, EventArgs i_E)
        {
            if (m_AlbumsForm == null)
            {
                m_AlbumsForm = new FormAlbums(m_AccountManager.LoginResult.LoggedInUser.Albums);
            }

            openSubForm(m_AlbumsForm);
        }

        private void buttonEvents_Click(object i_Sender, EventArgs i_E)
        {
            if (m_EventsForm == null)
            {
                m_EventsForm = new FormEvents(m_AccountManager.LoginResult.LoggedInUser.Events);
            }

            openSubForm(m_EventsForm);
        }

        private void buttonGroups_Click(object i_Sender, EventArgs i_E)
        {
            if (m_GroupsForm == null)
            {
                m_GroupsForm = new FormGroups(m_AccountManager.LoginResult.LoggedInUser.Groups);
            }

            openSubForm(m_GroupsForm);
        }

        private void buttonFavoriteTeams_Click(object i_Sender, EventArgs i_E)
        {
            if (m_FavoriteTeamsForm == null)
            {
                m_FavoriteTeamsForm = new FormFavoriteTeams(m_AccountManager.LoginResult.LoggedInUser.FavofriteTeams);
            }

            openSubForm(m_FavoriteTeamsForm);
        }

        private void buttonLikedPages_Click(object i_Sender, EventArgs i_E)
        {
            if (m_LikedPagesForm == null)
            {
                m_LikedPagesForm = new FormLikedPages(m_AccountManager.LoginResult.LoggedInUser.LikedPages);
            }

            openSubForm(m_LikedPagesForm);
        }

        private void buttonFriends_Click(object sender, EventArgs e)
        {
            if (m_FriendsForm == null)
            {
                m_FriendsForm = new FormFriends(m_AccountManager.LoginResult.LoggedInUser.Friends);
            }

            openSubForm(m_FriendsForm);
        }

        private void buttonStatistics_Click(object i_Sender, EventArgs i_E)
        {
            if (m_StatisticsForm == null)
            {
                m_StatisticsForm = new FormStatistics(m_AccountManager.LoginResult.LoggedInUser);
            }

            openSubForm(m_StatisticsForm);
        }

        private void buttonMostPopularFeed_Click(object sender, EventArgs e)
        {
            if (m_MostPopularFeedForm == null)
            {
                m_MostPopularFeedForm = new FormMostPopularFeed(m_AccountManager.LoginResult.LoggedInUser);
            }

            openSubForm(m_MostPopularFeedForm);
        }

        private void buttonLogout_Click(object i_Sender, EventArgs i_E)
        {
            FacebookService.LogoutWithUI();
            ActiveForm?.Hide();
            displayLoginControllers(true);
            m_AppSetting.ForgetUser();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if(m_AppSetting.RememberUserInfo)
            {
                m_AppSetting.RememberUser(m_AccountManager.LoginResult.AccessToken);
            }
            else
            {
                m_AppSetting.ForgetUser();
            }

            m_AppSetting.SaveToFile();
        }
    }
}
