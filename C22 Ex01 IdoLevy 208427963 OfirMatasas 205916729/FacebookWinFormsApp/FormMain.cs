using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWinFormsLogic;
using FacebookWinFormsApp.Forms;

namespace FacebookWinFormsApp
{
    internal partial class FormMain : Form
    {
        private readonly AppSetting r_AppSetting;
        private readonly FacebookAccountManager r_AccountManager = new FacebookAccountManager();
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
            r_AppSetting = AppSetting.LoadFromFile();
        }

        protected override void OnShown(EventArgs i_E)
        {
            base.OnShown(i_E);
            checkBoxRememberMe.Checked = r_AppSetting.RememberUserInfo;
            displayLoginControllers(!r_AppSetting.RememberUserInfo);
            if (r_AppSetting.RememberUserInfo && !string.IsNullOrEmpty(r_AppSetting.LastAccessToken))
            {
                r_AccountManager.Connect(r_AppSetting.LastAccessToken);
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

        private void buttonLogin_Click(object i_Sender, EventArgs i_E)
        {
            if (r_AccountManager.Login())
            {
                populateUI();
                if (checkBoxRememberMe.Checked)
                {
                    r_AppSetting.RememberUser(r_AccountManager.LoginResult.AccessToken);
                }
            }
            else
            {
                MessageBox.Show($"You must login to facebook !", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void populateUI()
        {
            Cursor.Current = Cursors.WaitCursor;
            displayUsersProfileInfoOnSidebar();
            enableAllSidebarButtons();
            showUsersProfileForm(null, null);
            Cursor.Current = Cursors.WaitCursor;
        }

        private void displayUsersProfileInfoOnSidebar()
        {
            pictureBoxProfilePicture.Image = r_AccountManager.LoginResult.LoggedInUser.ImageNormal;
            labelProfileName.Text = r_AccountManager.LoginResult.LoggedInUser.Name;
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
            loadingFormProcessStarted();
            if (m_ProfileForm == null)
            {
                m_ProfileForm = new FormProfile(r_AccountManager.LoginResult.LoggedInUser);
            }

            openSubForm(m_ProfileForm);
            loadingFormProcessDone();
        }

        private void buttonPosts_Click(object i_Sender, EventArgs i_E)
        {
            loadingFormProcessStarted();
            if (m_PostsForm == null)
            {
                m_PostsForm = new FormPosts(r_AccountManager);
            }

            openSubForm(m_PostsForm);
            loadingFormProcessDone();
        }

        private void buttonAlbums_Click(object i_Sender, EventArgs i_E)
        {
            loadingFormProcessStarted();
            if (m_AlbumsForm == null)
            {
                m_AlbumsForm = new FormAlbums(r_AccountManager.LoginResult.LoggedInUser.Albums);
            }

            openSubForm(m_AlbumsForm);
            loadingFormProcessDone();
        }

        private void buttonEvents_Click(object i_Sender, EventArgs i_E)
        {
            loadingFormProcessStarted();
            if (m_EventsForm == null)
            {
                m_EventsForm = new FormEvents(r_AccountManager.LoginResult.LoggedInUser.Events);
            }

            openSubForm(m_EventsForm);
            loadingFormProcessDone();
        }

        private void buttonGroups_Click(object i_Sender, EventArgs i_E)
        {
            loadingFormProcessStarted();
            if (m_GroupsForm == null)
            {
                m_GroupsForm = new FormGroups(r_AccountManager.LoginResult.LoggedInUser.Groups);
            }

            openSubForm(m_GroupsForm);
            loadingFormProcessDone();
        }

        private void buttonFavoriteTeams_Click(object i_Sender, EventArgs i_E)
        {
            loadingFormProcessStarted();
            if (m_FavoriteTeamsForm == null)
            {
                m_FavoriteTeamsForm = new FormFavoriteTeams(r_AccountManager.LoginResult.LoggedInUser.FavofriteTeams);
            }

            openSubForm(m_FavoriteTeamsForm);
            loadingFormProcessDone();
        }

        private void buttonLikedPages_Click(object i_Sender, EventArgs i_E)
        {
            loadingFormProcessStarted();
            if (m_LikedPagesForm == null)
            {
                m_LikedPagesForm = new FormLikedPages(r_AccountManager.LoginResult.LoggedInUser.LikedPages);
            }

            openSubForm(m_LikedPagesForm);
            loadingFormProcessDone();
        }

        private void buttonFriends_Click(object i_Sender, EventArgs i_E)
        {
            loadingFormProcessStarted();
            if (m_FriendsForm == null)
            {
                m_FriendsForm = new FormFriends(r_AccountManager.LoginResult.LoggedInUser.Friends);
            }

            openSubForm(m_FriendsForm);
            loadingFormProcessDone();
        }

        private void buttonStatistics_Click(object i_Sender, EventArgs i_E)
        {
            loadingFormProcessStarted();
            if (m_StatisticsForm == null)
            {
                m_StatisticsForm = new FormStatistics(r_AccountManager.LoginResult.LoggedInUser);
            }

            openSubForm(m_StatisticsForm);
            loadingFormProcessDone();
        }

        private void buttonMostPopularFeed_Click(object i_Sender, EventArgs i_E)
        {
            loadingFormProcessStarted();
            if (m_MostPopularFeedForm == null)
            {
                m_MostPopularFeedForm = new FormMostPopularFeed(r_AccountManager.LoginResult.LoggedInUser);
            }

            openSubForm(m_MostPopularFeedForm);
            loadingFormProcessDone();
        }

        private void buttonLogout_Click(object i_Sender, EventArgs i_E)
        {
            r_AccountManager.Logout();
            r_AppSetting.ForgetUser();
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs i_E)
        {
            base.OnFormClosing(i_E);
            if(r_AppSetting.RememberUserInfo)
            {
                r_AppSetting.RememberUser(r_AccountManager.LoginResult.AccessToken);
            }
            else
            {
                r_AppSetting.ForgetUser();
            }

            r_AppSetting.SaveToFile();
        }

        private void loadingFormProcessStarted()
        {
            Cursor.Current = Cursors.WaitCursor;
        }

        private void loadingFormProcessDone()
        {
            Cursor.Current = Cursors.Default;
        }
    }
}
