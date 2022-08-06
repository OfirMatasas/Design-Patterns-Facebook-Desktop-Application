using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormMostPopularFeed : Form
    {
        private MostPopularFeedLogic m_MostPopularFeedLogic { get; }
        public FormMostPopularFeed(User i_LoggedInUser)
        {
            InitializeComponent();
            m_MostPopularFeedLogic = new MostPopularFeedLogic(i_LoggedInUser);
        }

        private void fetchMostPopularFeed()
        {
            DateTime dateTimeChosen = new DateTime(dateTimePickerChoosedDate.Value.Year,
               DateTime.Today.Month, DateTime.Today.Day);

            if (dateTimeChosen > DateTime.Today)
            {
                MessageBox.Show($"You can't choose a day from the future !{Environment.NewLine}Please choose a valid date",
                    "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                getMostPopularPost();
                getMostPopularPhoto();
            }
        }

        private void getMostPopularPost()
        {
            int numberOfComments;
            Post mostPopularPost = m_MostPopularFeedLogic.FindMostPopularPost(dateTimePickerChoosedDate.Value);

            if (mostPopularPost != null)
            {
                numberOfComments = mostPopularPost.Comments.Count;
                listBoxMostPopularPost.Items.Clear();
                listBoxMostPopularPost.Items.Add(mostPopularPost);
                labelMostPopularPostCommentsNumber.Text = $"{numberOfComments} {(numberOfComments == 1 ? " Comment" : " Comments")} of you on post";
                labelMostPopularPostDate.Text = $"Published At: {mostPopularPost.CreatedTime}";
            }
            else
            {
                MessageBox.Show($"This year you haven't published any post !", "No posts to show",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void getMostPopularPhoto()
        {
            int numberOfComments;
            Photo mostPopularPhoto = m_MostPopularFeedLogic.FindMostPopularPhoto(dateTimePickerChoosedDate.Value);

            if (mostPopularPhoto != null)
            {
                numberOfComments = mostPopularPhoto.Comments.Count;
                pictureBoxMostPopularPhoto.Image = new Bitmap(mostPopularPhoto.ImageNormal, pictureBoxMostPopularPhoto.Size);
                labelMostPopularPhotoCommentsNumber.Text = $"{numberOfComments} {(numberOfComments == 1 ? " Comment" : " Comments")} of you on photo";
                labelMostPopularPhotoDate.Text = $"Published At: {mostPopularPhoto.CreatedTime}";
            }
            else
            {
                MessageBox.Show($"This year you haven't published any photo !", "No photos to show",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonShowPhotosAndPosts_Click(object sender, EventArgs e)
        {
            panelMostPopular.Visible = true;
            fetchMostPopularFeed();
        }
    }
}
