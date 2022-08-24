using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Forms
{
    internal partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
            fetchProfileInfo();
        }

        private void fetchProfileInfo()
        {
            User user = FacebookAccountManager.Instance.User;

            labelProfileName.Text = user.Name;
            pictureBoxProfilePicture.Image = user.ImageLarge;
            setUsersCoverPicture(user);
            labelBirthday.Text += user.Birthday;
            labelGender.Text += user.Gender;
            labelFriendsCount.Text += user.Friends.Count;
            labelHometown.Text += user.Hometown;
            labelLocation.Text += user.Location.Name;
            labelWallPosts.Text += user.WallPosts.Count;
        }

        private void setUsersCoverPicture(User i_User)
        {
            List<string> possibleCoverAlbumNames = getCoversPhotosNamesPossibleNames();
            Album coversAlbum = i_User.Albums.Find(album => possibleCoverAlbumNames.Contains(album.Name));

            pictureBoxCoverPicture.Image = coversAlbum?.Photos[0].ImageNormal;
        }

        private List<string> getCoversPhotosNamesPossibleNames()
        {
            List<string> possibleCoverAlbumNames = new List<string>
            {
                "Cover photos",
                "תמונות נושא"
            };

            return possibleCoverAlbumNames;
        }
    }
}
