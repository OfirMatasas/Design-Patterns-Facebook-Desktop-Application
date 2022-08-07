using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FaceBookWinFormsApp.Forms
{
    internal partial class FormProfile : Form
    {
        private readonly User r_LoggedInUser;

        public FormProfile(User i_LoggedInUser)
        {
            InitializeComponent();
            r_LoggedInUser = i_LoggedInUser;
            fetchProfileInfo();
        }

        private void fetchProfileInfo()
        {
            labelProfileName.Text = r_LoggedInUser.Name;
            pictureBoxProfilePicture.Image = r_LoggedInUser.ImageLarge;
            setUsersCoverPicture();
            labelBirthday.Text += r_LoggedInUser.Birthday;
            labelGender.Text += r_LoggedInUser.Gender;
            labelFriendsCount.Text += r_LoggedInUser.Friends.Count;
            labelHometown.Text += r_LoggedInUser.Hometown;
            labelLocation.Text += r_LoggedInUser.Location.Name;
            labelWallPosts.Text += r_LoggedInUser.WallPosts.Count;
        }

        private void setUsersCoverPicture()
        {
            List<string> possibleCoverAlbumNames = getCoversPhotosNamesPossibleNames();
            Album coversAlbum = r_LoggedInUser.Albums.Find(a => possibleCoverAlbumNames.Contains(a.Name));

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
