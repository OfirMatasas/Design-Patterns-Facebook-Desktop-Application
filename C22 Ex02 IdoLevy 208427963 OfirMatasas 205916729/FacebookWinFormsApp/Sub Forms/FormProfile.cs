using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Forms
{
    internal partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            fetchProfileInfo();
            base.OnShown(e);
        }

        private void fetchProfileInfo()
        {
            FacebookAccountManager accountManager = FacebookAccountManager.Instance;

            labelProfileName.Text = accountManager.Name;
            pictureBoxProfilePicture.Image = accountManager.ProfilePicture;
            setUsersCoverPicture(accountManager);
            labelBirthday.Text += accountManager.Birthday;
            labelGender.Text += accountManager.Gender;
            labelFriendsCount.Text += accountManager.Friends.Count;
            labelHometown.Text += accountManager.Hometown;
            labelLocation.Text += accountManager.Location.Name;
            labelWallPosts.Text += accountManager.WallPosts.Count;
        }

        private void setUsersCoverPicture(FacebookAccountManager i_AccountManager)
        {
            List<string> possibleCoverAlbumNames = getCoversPhotosNamesPossibleNames();
            Album coversAlbum = i_AccountManager.Albums.Find(album => possibleCoverAlbumNames.Contains(album.Name));

            pictureBoxCoverPicture.Image = coversAlbum?.Photos[0].ImageNormal;
        }

        private List<string> getCoversPhotosNamesPossibleNames()
        {
            return new List<string>
            {
                "Cover photos",
                "תמונות נושא"
            };
        }
    }
}
