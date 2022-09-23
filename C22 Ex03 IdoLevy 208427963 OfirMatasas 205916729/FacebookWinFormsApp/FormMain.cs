using System;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures;
using FacebookExceptions;
using FacebookWinFormsLogic;
using FacebookWrapper;

namespace FacebookWinFormsApp
{
    internal partial class FormMain : Form
    {
        //---------------------------------------------- Members ----------------------------------------------//
        private readonly AppSetting r_AppSetting;
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

        //-------------------------------------------- Constructor --------------------------------------------//
        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
            r_AppSetting = AppSetting.LoadFromFile();
            setListeners();
        }

        //---------------------------------------------- Start Up ---------------------------------------------//
        protected override void OnLoad(EventArgs i_E)
        {
            base.OnLoad(i_E);
            displayLoginControllers(!r_AppSetting.RememberUserInfo);
            if (r_AppSetting.RememberUserInfo && !string.IsNullOrEmpty(r_AppSetting.LastAccessToken))
            {
                new Thread(() =>
                {
                    loadingFormProcessStarted();
                    FacebookAccountManager.Instance.Connect(r_AppSetting.LastAccessToken);
                    populateUI();
                    loadingFormProcessDone();
                }).Start();
            }
        }

        private void setListeners()
        {
            FacebookAccountManager accountManager = FacebookAccountManager.Instance;

            accountManager.LoggedInOrOut += enableAllSidebarButtons;
        }

        //----------------------------------------------- Login -----------------------------------------------//
        private void buttonLogin_Click(object i_Sender, EventArgs i_E)
        {
            try
            {
                FacebookAccountManager.Instance.Login();
                populateUI();
                if (checkBoxRememberMe.Checked)
                {
                    r_AppSetting.RememberUser(FacebookAccountManager.Instance.AccessToken);
                }
            }
            catch (LoginFailureException)
            {
                MessageDisplayer.ActionFailed("login");
            }
            catch (UserAlreadyLoggedInException)
            {
                MessageDisplayer.InvalidOperation("User already logged in!");
            }
        }

        private void displayLoginControllers(bool i_ToDisplay)
        {
            foreach (Control control in panelLogin.Controls)
            {
                control.Visible = i_ToDisplay;
            }
        }

        private void populateUI()
        {
            displayUsersProfileInfoOnSidebar();
            enableAllSidebarButtons(true);
            showUsersProfileForm(null, null);
        }

        //---------------------------------------------- Sidebar ----------------------------------------------//
        private void displayUsersProfileInfoOnSidebar()
        {
            pictureBoxProfilePicture.Invoke(new Action(() => pictureBoxProfilePicture.Image = FacebookAccountManager.Instance.ProfilePicture));
            labelProfileName.Invoke(new Action(() => labelProfileName.Text = FacebookAccountManager.Instance.Name));
            labelProfileName.Invoke(new Action(() => labelProfileName.Visible = true));
        }

        private void enableAllSidebarButtons(bool i_ToEnable)
        {
            foreach (Control control in panelSidebarButtons.Controls)
            {
                control.Invoke(new Action(() => control.Enabled = i_ToEnable));
            }
        }

        //--------------------------------------------- Sub Forms ---------------------------------------------//
        private void showUsersProfileForm(object i_Sender, EventArgs i_E)
        {
            loadSelectedForm(ref m_ProfileForm, FacebookFormFactory.eFormTypes.Profile);
        }

        private void buttonPosts_Click(object i_Sender, EventArgs i_E)
        {
            loadSelectedForm(ref m_PostsForm, FacebookFormFactory.eFormTypes.Posts);
        }

        private void buttonAlbums_Click(object i_Sender, EventArgs i_E)
        {
            loadSelectedForm(ref m_AlbumsForm, FacebookFormFactory.eFormTypes.Albums);
        }

        private void buttonEvents_Click(object i_Sender, EventArgs i_E)
        {
            loadSelectedForm(ref m_EventsForm, FacebookFormFactory.eFormTypes.Events);
        }

        private void buttonGroups_Click(object i_Sender, EventArgs i_E)
        {
            loadSelectedForm(ref m_GroupsForm, FacebookFormFactory.eFormTypes.Groups);
        }

        private void buttonFavoriteTeams_Click(object i_Sender, EventArgs i_E)
        {
            loadSelectedForm(ref m_FavoriteTeamsForm, FacebookFormFactory.eFormTypes.FavoriteTeams);
        }

        private void buttonLikedPages_Click(object i_Sender, EventArgs i_E)
        {
            loadSelectedForm(ref m_LikedPagesForm, FacebookFormFactory.eFormTypes.LikedPages);
        }

        private void buttonFriends_Click(object i_Sender, EventArgs i_E)
        {
            loadSelectedForm(ref m_FriendsForm, FacebookFormFactory.eFormTypes.Friends);
        }

        private void buttonStatistics_Click(object i_Sender, EventArgs i_E)
        {
            loadSelectedForm(ref m_StatisticsForm, FacebookFormFactory.eFormTypes.Statistics);
        }

        private void buttonMostPopularFeed_Click(object i_Sender, EventArgs i_E)
        {
            loadSelectedForm(ref m_MostPopularFeedForm, FacebookFormFactory.eFormTypes.MostPopularFeed);
        }

        private void loadSelectedForm(ref Form io_SelectedForm, FacebookFormFactory.eFormTypes i_SelectedFormType)
        {
            try
            {
                loadingFormProcessStarted();
                if (io_SelectedForm == null)
                {
                    io_SelectedForm = FacebookFormFactory.CreateForm(i_SelectedFormType);
                }

                switchDisplayedSubForm(io_SelectedForm);
                loadingFormProcessDone();
            }
            catch (Exception ex)
            {
                MessageDisplayer.InvalidOperation(ex.Message);
            }
        }

        private void switchDisplayedSubForm(Form i_SubForm)
        {
            m_ActivateForm?.Hide();
            m_ActivateForm = i_SubForm;
            i_SubForm.TopLevel = false;
            i_SubForm.FormBorderStyle = FormBorderStyle.None;
            i_SubForm.Dock = DockStyle.Fill;
            panelLogin.Invoke(new Action(() => panelLogin.Controls.Add(i_SubForm)));
            i_SubForm.BringToFront();
            i_SubForm.Invoke(new Action(() => i_SubForm.Show()));
        }

        //---------------------------------------------- Logout -----------------------------------------------//
        private void buttonLogout_Click(object i_Sender, EventArgs i_E)
        {
            FacebookAccountManager.Instance.Logout();
            r_AppSetting.ForgetUser();
            Close();
        }

        //---------------------------------------------- Methods ----------------------------------------------//
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
