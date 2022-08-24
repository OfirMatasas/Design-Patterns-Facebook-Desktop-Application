using System;
using System.Drawing;
using System.Windows.Forms;
using BasicFacebookFeatures;
using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp.Forms
{
    internal partial class FormMostPopularFeed : Form
    {
        private readonly MostPopularFeedLogic r_MostPopularFeedLogic;

        public FormMostPopularFeed(User i_LoggedInUser)
        {
            InitializeComponent();
            r_MostPopularFeedLogic = new MostPopularFeedLogic(i_LoggedInUser);
        }

        private void fetchMostPopularFeed()
        {
            DateTime chosenDateTime = new DateTime(dateTimePickerChosenDate.Value.Year, DateTime.Today.Month, DateTime.Today.Day);
            bool foundMostPopularPost, foundMostPopularPhoto;

            if (chosenDateTime > DateTime.Today)
            {
                MessageDisplayer.InvalidTimePeriod("future");
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                getMostPopularPost(chosenDateTime, out foundMostPopularPost);
                getMostPopularPhoto(chosenDateTime, out foundMostPopularPhoto);
                Cursor.Current = Cursors.Default;
                if (!foundMostPopularPost || !foundMostPopularPhoto)
                {
                    notifyUserAboutNonExistedItemsOnSelectedYear(foundMostPopularPost, foundMostPopularPhoto);
                }
            }
        }

        private void notifyUserAboutNonExistedItemsOnSelectedYear(bool i_FoundMostPopularPost, bool i_FoundMostPopularPhoto)
        {
            string nonExistedItem;

            if(!i_FoundMostPopularPost && !i_FoundMostPopularPhoto)
            {
                nonExistedItem = "post / photo";
            }
            else
            {
                nonExistedItem = !i_FoundMostPopularPost ? "post" : "photo";
            }

            MessageDisplayer.NoItemsPublishedOnRelevantTime("This year", nonExistedItem);
        }

        private void getMostPopularPost(DateTime i_ChosenDateTime, out bool o_FoundMostPopularPost)
        {
            int numberOfComments;
            Post mostPopularPost = r_MostPopularFeedLogic.FindMostPopularPost(i_ChosenDateTime);

            o_FoundMostPopularPost = mostPopularPost != null;
            if (o_FoundMostPopularPost)
            {
                numberOfComments = mostPopularPost.Comments.Count;
                listBoxMostPopularPost.Items.Clear();
                listBoxMostPopularPost.Items.Add(mostPopularPost);
                labelMostPopularPostCommentsNumber.Text = $"{numberOfComments} Comment{(numberOfComments == 1 ? string.Empty : "s")} on your post";
                labelMostPopularPostDate.Text = $"Published At: {mostPopularPost.CreatedTime}";
            }
        }

        private void getMostPopularPhoto(DateTime i_ChosenDateTime, out bool o_FoundMostPopularPhoto)
        {
            Photo mostPopularPhoto = r_MostPopularFeedLogic.FindMostPopularPhoto(i_ChosenDateTime);
            int numberOfComments;

            o_FoundMostPopularPhoto = mostPopularPhoto != null;
            if (o_FoundMostPopularPhoto)
            {
                numberOfComments = mostPopularPhoto.Comments.Count;
                pictureBoxMostPopularPhoto.Image = new Bitmap(mostPopularPhoto.ImageNormal, pictureBoxMostPopularPhoto.Size);
                labelMostPopularPhotoCommentsNumber.Text = $"{numberOfComments} Comment{(numberOfComments == 1 ? string.Empty : "s")} on your photo";
                labelMostPopularPhotoDate.Text = $"Published At: {mostPopularPhoto.CreatedTime}";
            }
        }

        private void buttonShowPhotosAndPosts_Click(object i_Sender, EventArgs i_E)
        {
            fetchMostPopularFeed();
            panelMostPopular.Visible = true;
            labelMostPopularFeed.Visible = true;
        }
    }
}
