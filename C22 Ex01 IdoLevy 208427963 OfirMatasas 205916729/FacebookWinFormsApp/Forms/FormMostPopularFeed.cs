using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FaceBookWinFormsApp.Forms
{
    internal partial class FormMostPopularFeed : Form
    {
        private MostPopularFeedLogic m_MostPopularFeedLogic;

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
                messageBoxNoDetailsInDate("post");
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
                messageBoxNoDetailsInDate("photo");
            }
        }

        private void messageBoxNoDetailsInDate(string i_Details)
        {
            MessageBox.Show($"This year you haven't published any {i_Details} !", $"No {i_Details}s to show",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonShowPhotosAndPosts_Click(object sender, EventArgs e)
        {
            fetchMostPopularFeed();
            panelMostPopular.Visible = true;
            labelMostPopularFeed.Visible = true;
        }
    }
}
