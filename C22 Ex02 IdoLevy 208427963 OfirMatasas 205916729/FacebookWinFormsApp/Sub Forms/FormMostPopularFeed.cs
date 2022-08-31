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
                try
                {
                    new Thread(() => getMostPopularPost(chosenDateTime)).Start();
                    new Thread(() => getMostPopularPhoto(chosenDateTime)).Start();
                }
                catch(Exception)
                {
                    notifyUserAboutNonExistedItemsOnSelectedYear();
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void notifyUserAboutNonExistedItemsOnSelectedYear()
        {
            string nonExistedItem;

            if (richTextBoxMostPopularPost.Text == String.Empty && pictureBoxMostPopularPhoto.Image == null)
            {
                nonExistedItem = "post / photo";
            }
            else
            {
                nonExistedItem = richTextBoxMostPopularPost.Text == String.Empty ? "post" : "photo";
            }

            MessageDisplayer.NoItemsPublishedOnRelevantTime("This year", nonExistedItem);
        }

        private void getMostPopularPost(DateTime i_ChosenDateTime)
        {
            int numberOfComments;
            Post mostPopularPost = r_MostPopularFeedLogic.FindMostPopularPost(i_ChosenDateTime);

            richTextBoxMostPopularPost.Invoke(new Action(() => richTextBoxMostPopularPost.Text = String.Empty));
            if (mostPopularPost != null)
            {
                numberOfComments = mostPopularPost.Comments.Count;
                richTextBoxMostPopularPost.Invoke(new Action(() => richTextBoxMostPopularPost.Text = mostPopularPost.Message));
                labelMostPopularPostCommentsNumber.Text = $"{numberOfComments} Comment{(numberOfComments == 1 ? string.Empty : "s")} on your post";
                labelMostPopularPostDate.Text = $"Published At: {mostPopularPost.CreatedTime}";
            }
            else
            {
                throw new Exception();
            }
        }

        private void getMostPopularPhoto(DateTime i_ChosenDateTime)
        {
            Photo mostPopularPhoto = r_MostPopularFeedLogic.FindMostPopularPhoto(i_ChosenDateTime);
            int numberOfComments;

            pictureBoxMostPopularPhoto.Invoke(new Action(() => pictureBoxMostPopularPhoto.Image = null));
            if (mostPopularPhoto != null)
            {
                numberOfComments = mostPopularPhoto.Comments.Count;
                pictureBoxMostPopularPhoto.Invoke(new Action(() => pictureBoxMostPopularPhoto.Image = new Bitmap(mostPopularPhoto.ImageNormal, pictureBoxMostPopularPhoto.Size)));
                labelMostPopularPhotoCommentsNumber.Text = $"{numberOfComments} Comment{(numberOfComments == 1 ? string.Empty : "s")} on your photo";
                labelMostPopularPhotoDate.Text = $"Published At: {mostPopularPhoto.CreatedTime}";
            }
            else
            {
                throw new Exception();
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
