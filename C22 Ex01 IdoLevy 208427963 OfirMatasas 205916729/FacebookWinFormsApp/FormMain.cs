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
            loadSelectedForm(ref m_ProfileForm, FacebookFormFactoryMethod.eFormTypes.Profile);
        }

        private void buttonPosts_Click(object i_Sender, EventArgs i_E)
        {
            loadSelectedForm(ref m_PostsForm, FacebookFormFactoryMethod.eFormTypes.Posts);
        }

        private void buttonAlbums_Click(object i_Sender, EventArgs i_E)
        {
            loadSelectedForm(ref m_AlbumsForm, FacebookFormFactoryMethod.eFormTypes.Albums);
        }

        private void buttonEvents_Click(object i_Sender, EventArgs i_E)
        {
            loadSelectedForm(ref m_EventsForm, FacebookFormFactoryMethod.eFormTypes.Events);
        }

        private void buttonGroups_Click(object i_Sender, EventArgs i_E)
        {
            loadSelectedForm(ref m_GroupsForm, FacebookFormFactoryMethod.eFormTypes.Groups);
        }

        private void buttonFavoriteTeams_Click(object i_Sender, EventArgs i_E)
        {
            loadSelectedForm(ref m_FavoriteTeamsForm, FacebookFormFactoryMethod.eFormTypes.FavoriteTeams);
        }

        private void buttonLikedPages_Click(object i_Sender, EventArgs i_E)
        {
            loadSelectedForm(ref m_LikedPagesForm, FacebookFormFactoryMethod.eFormTypes.LikedPages);
        }

        private void buttonFriends_Click(object i_Sender, EventArgs i_E)
        {
            loadSelectedForm(ref m_FriendsForm, FacebookFormFactoryMethod.eFormTypes.Friends);
        }

        private void buttonStatistics_Click(object i_Sender, EventArgs i_E)
        {
            loadSelectedForm(ref m_StatisticsForm, FacebookFormFactoryMethod.eFormTypes.Statistics);
        }

        private void buttonMostPopularFeed_Click(object i_Sender, EventArgs i_E)
        {
            loadSelectedForm(ref m_MostPopularFeedForm, FacebookFormFactoryMethod.eFormTypes.MostPopularFeed);
        }

        private void loadSelectedForm(ref Form io_SelectedForm, FacebookFormFactoryMethod.eFormTypes i_SelectedFormType)
        {
            loadingFormProcessStarted();
            if (io_SelectedForm == null)
            {
                io_SelectedForm = FacebookFormFactoryMethod.CreateForm(i_SelectedFormType);
            }

            openSubForm(io_SelectedForm);
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
