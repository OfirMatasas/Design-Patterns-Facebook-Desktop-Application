using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormProfile : Form
    {
        public FormProfile(User i_User)
        {
            InitializeComponent();
            DisplayProfileInfo(i_User);
        }

        private void DisplayProfileInfo(User i_User)
        {
            labelProfileName.Text = i_User.Name;
            pictureBoxProfilePicture.Image = i_User.ImageLarge;
            setUsersCoverPicture(i_User);
            labelBirthday.Text += i_User.Birthday;
            labelGender.Text += i_User.Gender;
            labelFriendsCount.Text += i_User.Friends.Count;
            labelHometown.Text += i_User.Hometown;
            labelLocation.Text += i_User.Location.Name;
            labelWallPosts.Text += i_User.WallPosts.Count;
        }

        private void setUsersCoverPicture(User i_User)
        {
            List<string> possibleCoverAlbumNames = getCoversPhotosNamesPossibleNames();
            Album coversAlbum = i_User.Albums.Find(a => possibleCoverAlbumNames.Contains(a.Name));

            pictureBoxCoverPicture.Image = coversAlbum?.Photos[0].ImageNormal;
        }

        private List<string> getCoversPhotosNamesPossibleNames()
        {
            List<string> possibleCoverAlbumNames = new List<string>();

            possibleCoverAlbumNames.Add("Cover photos");
            possibleCoverAlbumNames.Add("תמונות נושא");

            return possibleCoverAlbumNames;
        }
    }
}
