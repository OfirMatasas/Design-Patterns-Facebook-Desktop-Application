using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FaceBookWinFormsApp.Forms
{
    internal partial class FormProfile : Form
    {
        private User m_LoggedInUser;
        public FormProfile(User i_LoggedInUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
            fetchProfileInfo();
        }

        private void fetchProfileInfo()
        {
            labelProfileName.Text = m_LoggedInUser.Name;
            pictureBoxProfilePicture.Image = m_LoggedInUser.ImageLarge;
            setUsersCoverPicture();
            labelBirthday.Text += m_LoggedInUser.Birthday;
            labelGender.Text += m_LoggedInUser.Gender;
            labelFriendsCount.Text += m_LoggedInUser.Friends.Count;
            labelHometown.Text += m_LoggedInUser.Hometown;
            labelLocation.Text += m_LoggedInUser.Location.Name;
            labelWallPosts.Text += m_LoggedInUser.WallPosts.Count;
        }

        private void setUsersCoverPicture()
        {
            List<string> possibleCoverAlbumNames = getCoversPhotosNamesPossibleNames();
            Album coversAlbum = m_LoggedInUser.Albums.Find(a => possibleCoverAlbumNames.Contains(a.Name));

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
