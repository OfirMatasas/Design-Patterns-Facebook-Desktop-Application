using System;
using System.Windows.Forms;
using BasicFacebookFeatures.Forms;
using FacebookWrapper;
using FacebookWinFormsLogic;
using System.ComponentModel;

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
        private FormStatistics StatisticsForm { get; set; }
        private FormProfile ProfileForm { get; set; }
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
                displayLoginControllers(false);
            }
            else
            {
                displayLoginControllers(true);
            }
        }

        private void displayLoginControllers(bool i_ToDisplay)
        {
            foreach(Control control in panelLogin.Controls)
            {
                control.Visible = i_ToDisplay;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            m_AppSetting.LastAccessToken = m_AppSetting.RememberUser ? m_AccountManager.LoginResult.AccessToken : null;
            m_AppSetting.SaveToFile();
        }


        private void enableAllSidebarButtons()
        {
            foreach(Control control in panelSidebarButtons.Controls)
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
            panelLogin.Controls.Add(i_ChildForm);
            panelLogin.Tag = i_ChildForm;
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
            ActiveForm?.Hide();
            displayLoginControllers(true);
            m_AppSetting.forgetUser();
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

        private void buttonStatistics_Click(object i_Sender, EventArgs i_E)
        {
            if (StatisticsForm == null)
            {
                StatisticsForm = new FormStatistics(m_AccountManager.LoginResult.LoggedInUser);
            }

            openChildForm(StatisticsForm, i_Sender);
        }

        private void showUsersProfileForm(object i_Sender, EventArgs i_E)
        {
            if (ProfileForm == null)
            {
                ProfileForm = new FormProfile(m_AccountManager.LoginResult.LoggedInUser);
            }

            openChildForm(ProfileForm, i_Sender);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (m_AccountManager.Login())
            {
                populateUI();
                if(checkBoxRememberMe.Checked)
                {
                    m_AppSetting.RememberUser = true;
                    m_AppSetting.LastAccessToken = m_AccountManager.LoginResult.AccessToken;
                    
                }
            }
        }
    }
}
