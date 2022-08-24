using BasicFacebookFeatures;
using FacebookWinFormsLogic;
using FacebookWrapper;
using System;
using System.Windows.Forms;

namespace FacebookWinFormsApp
{
    internal partial class FormMain : Form
    {
        private readonly AppSetting r_AppSetting;
        private readonly FacebookAccountManager r_AccountManager = new FacebookAccountManager();
        private Form m_ActivateForm;
        private Form m_ProfileForm;
        private Form m_PostsForm;
        private Form m_AlbumsForm;
        private Form m_EventsForm;
        private Form m_GroupsForm;
        private Form m_FavoriteTeamsForm;
        private Form m_LikedPagesForm;
        private Form m_FriendsForm;
        private Form m_StatisticsForm;
        private Form m_MostPopularFeedForm;

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
                FacebookFormFactoryMethod.SetFacebookAccountManager(r_AccountManager);
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
                FacebookFormFactoryMethod.SetFacebookAccountManager(r_AccountManager);
                if (checkBoxRememberMe.Checked)
                {
                    r_AppSetting.RememberUser(r_AccountManager.LoginResult.AccessToken);
                }
            }
            else
            {
                MessageDisplayer.ActionFailed("login");
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
                m_ProfileForm = FacebookFormFactoryMethod.CreateForm(FacebookFormFactoryMethod.eFormTypes.Profile);
            }

            openSubForm(m_ProfileForm);
            loadingFormProcessDone();
        }

        private void buttonPosts_Click(object i_Sender, EventArgs i_E)
        {
            loadingFormProcessStarted();
            if (m_PostsForm == null)
            {
                m_PostsForm = FacebookFormFactoryMethod.CreateForm(FacebookFormFactoryMethod.eFormTypes.Posts);
            }

            openSubForm(m_PostsForm);
            loadingFormProcessDone();
        }

        private void buttonAlbums_Click(object i_Sender, EventArgs i_E)
        {
            loadingFormProcessStarted();
            if (m_AlbumsForm == null)
            {
                m_AlbumsForm = FacebookFormFactoryMethod.CreateForm(FacebookFormFactoryMethod.eFormTypes.Albums);
            }

            openSubForm(m_AlbumsForm);
            loadingFormProcessDone();
        }

        private void buttonEvents_Click(object i_Sender, EventArgs i_E)
        {
            loadingFormProcessStarted();
            if (m_EventsForm == null)
            {
                m_EventsForm = FacebookFormFactoryMethod.CreateForm(FacebookFormFactoryMethod.eFormTypes.Events);
            }

            openSubForm(m_EventsForm);
            loadingFormProcessDone();
        }

        private void buttonGroups_Click(object i_Sender, EventArgs i_E)
        {
            loadingFormProcessStarted();
            if (m_GroupsForm == null)
            {
                m_GroupsForm = FacebookFormFactoryMethod.CreateForm(FacebookFormFactoryMethod.eFormTypes.Groups);
            }

            openSubForm(m_GroupsForm);
            loadingFormProcessDone();
        }

        private void buttonFavoriteTeams_Click(object i_Sender, EventArgs i_E)
        {
            loadingFormProcessStarted();
            if (m_FavoriteTeamsForm == null)
            {
                m_FavoriteTeamsForm = FacebookFormFactoryMethod.CreateForm(FacebookFormFactoryMethod.eFormTypes.FavoriteTeams);
            }

            openSubForm(m_FavoriteTeamsForm);
            loadingFormProcessDone();
        }

        private void buttonLikedPages_Click(object i_Sender, EventArgs i_E)
        {
            loadingFormProcessStarted();
            if (m_LikedPagesForm == null)
            {
                m_LikedPagesForm = FacebookFormFactoryMethod.CreateForm(FacebookFormFactoryMethod.eFormTypes.LikedPages);
            }

            openSubForm(m_LikedPagesForm);
            loadingFormProcessDone();
        }

        private void buttonFriends_Click(object i_Sender, EventArgs i_E)
        {
            loadingFormProcessStarted();
            if (m_FriendsForm == null)
            {
                m_FriendsForm = FacebookFormFactoryMethod.CreateForm(FacebookFormFactoryMethod.eFormTypes.Friends);
            }

            openSubForm(m_FriendsForm);
            loadingFormProcessDone();
        }

        private void buttonStatistics_Click(object i_Sender, EventArgs i_E)
        {
            loadingFormProcessStarted();
            if (m_StatisticsForm == null)
            {
                m_StatisticsForm = FacebookFormFactoryMethod.CreateForm(FacebookFormFactoryMethod.eFormTypes.Statistics);
            }

            openSubForm(m_StatisticsForm);
            loadingFormProcessDone();
        }

        private void buttonMostPopularFeed_Click(object i_Sender, EventArgs i_E)
        {
            loadingFormProcessStarted();
            if (m_MostPopularFeedForm == null)
            {
                m_MostPopularFeedForm = FacebookFormFactoryMethod.CreateForm(FacebookFormFactoryMethod.eFormTypes.MostPopularFeed);
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
            if (r_AppSetting.RememberUserInfo)
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
