using BasicFacebookFeatures;
using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Forms
{
    internal partial class FormMostPopularFeed : Form
    {
        private readonly MostPopularFeedLogic r_MostPopularFeedLogic;

        public FormMostPopularFeed()
        {
            InitializeComponent();
            r_MostPopularFeedLogic = new MostPopularFeedLogic();
        }

        private void fetchMostPopularFeed()
        {
            DateTime chosenDateTime = new DateTime(dateTimePickerChosenDate.Value.Year, DateTime.Today.Month, DateTime.Today.Day);

            if (chosenDateTime > DateTime.Today)
            {
                MessageDisplayer.InvalidTimePeriod("future");
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                new Thread(() =>
                {
                    getMostPopularPost(chosenDateTime);
                    getMostPopularPhoto(chosenDateTime);
                    if (listBoxMostPopularPost.Items.Count == 0 || pictureBoxMostPopularPhoto.Image == null)
                    {
                        notifyUserAboutNonExistedItemsOnSelectedYear();
                    }
                }).Start();
                Cursor.Current = Cursors.Default;
            }
        }

        private void notifyUserAboutNonExistedItemsOnSelectedYear()
        {
            string nonExistedItem;

            if (listBoxMostPopularPost.Items.Count == 0 && pictureBoxMostPopularPhoto.Image == null)
            {
                nonExistedItem = "post / photo";
            }
            else
            {
                nonExistedItem = listBoxMostPopularPost.Items.Count == 0 ? "post" : "photo";
            }

            MessageDisplayer.NoItemsPublishedOnRelevantTime("This year", nonExistedItem);
        }

        private void getMostPopularPost(DateTime i_ChosenDateTime)
        {
            Post mostPopularPost = r_MostPopularFeedLogic.FindMostPopularPost(i_ChosenDateTime);

            listBoxMostPopularPost.Invoke(new Action(() => listBoxMostPopularPost.Items.Clear()));
            if (mostPopularPost != null)
            {
                listBoxMostPopularPost.Invoke(new Action(() => listBoxMostPopularPost.Items.Add(mostPopularPost)));
                labelMostPopularPostCommentsNumber.Invoke(
                    new Action(() => labelMostPopularPostCommentsNumber.Text = $"{mostPopularPost.Comments.Count} Comment{(mostPopularPost.Comments.Count == 1 ? string.Empty : "s")} on your post"));
                labelMostPopularPostDate.Invoke(new Action(() => labelMostPopularPostDate.Text = $"Published At: {mostPopularPost.CreatedTime}"));
            }
        }

        private void getMostPopularPhoto(DateTime i_ChosenDateTime)
        {
            Photo mostPopularPhoto = r_MostPopularFeedLogic.FindMostPopularPhoto(i_ChosenDateTime);

            pictureBoxMostPopularPhoto.Invoke(new Action(() => pictureBoxMostPopularPhoto.Image = null));
            if (mostPopularPhoto != null)
            {
                pictureBoxMostPopularPhoto.Invoke(new Action(() => pictureBoxMostPopularPhoto.Image = new Bitmap(mostPopularPhoto.ImageNormal, pictureBoxMostPopularPhoto.Size)));
                labelMostPopularPhotoCommentsNumber.Invoke(
                    new Action(() => labelMostPopularPhotoCommentsNumber.Text = $"{mostPopularPhoto.Comments.Count} Comment{(mostPopularPhoto.Comments.Count == 1 ? string.Empty : "s")} on your photo"));
                labelMostPopularPhotoDate.Invoke(new Action(() => labelMostPopularPhotoDate.Text = $"Published At: {mostPopularPhoto.CreatedTime}"));
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
