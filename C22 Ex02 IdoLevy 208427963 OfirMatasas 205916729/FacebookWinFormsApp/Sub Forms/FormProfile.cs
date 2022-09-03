using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp.Forms
{
    internal partial class FormProfile : Form
    {
        //-------------------------------------------- Constructor --------------------------------------------//
        public FormProfile()
        {
            InitializeComponent();
        }

        //--------------------------------------------- On Shown ----------------------------------------------//
        protected override void OnShown(EventArgs i_E)
        {
            new Thread(fetchProfileInfo).Start();
            base.OnShown(i_E);
        }

        private void fetchProfileInfo()
        {
            labelProfileName.Invoke(new Action(() => labelProfileName.Text = FacebookAccountManager.Instance.Name));
            pictureBoxProfilePicture.Invoke(new Action(() => pictureBoxProfilePicture.Image = FacebookAccountManager.Instance.ProfilePicture));
            setUsersCoverPicture();
            labelBirthday.Invoke(new Action(() => labelBirthday.Text += FacebookAccountManager.Instance.Birthday));
            labelGender.Invoke(new Action(() => labelGender.Text += FacebookAccountManager.Instance.Gender));
            labelFriendsCount.Invoke(new Action(() => labelFriendsCount.Text += FacebookAccountManager.Instance.Friends.Count));
            labelHometown.Invoke(new Action(() => labelHometown.Text += FacebookAccountManager.Instance.Hometown));
            labelLocation.Invoke(new Action(() => labelLocation.Text += FacebookAccountManager.Instance.Location.Name));
            labelWallPosts.Invoke(new Action(() => labelWallPosts.Text += FacebookAccountManager.Instance.WallPosts.Count));
        }

        private void setUsersCoverPicture()
        {
            List<string> possibleCoverAlbumNames = getCoversPhotosNamesPossibleNames();
            Album coversAlbum = FacebookAccountManager.Instance.Albums.Find(album => possibleCoverAlbumNames.Contains(album.Name));

            pictureBoxCoverPicture.Invoke(new Action(() => pictureBoxCoverPicture.Image = coversAlbum?.Photos[0].ImageNormal));
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
