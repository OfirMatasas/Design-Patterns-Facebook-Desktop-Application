﻿using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures;
using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;
using FacebookWinFormsLogic.DateComparatiorStrategies;

namespace FacebookWinFormsApp.Forms
{
    internal partial class FormMostPopularFeed : Form
    {
        //---------------------------------------------- Members ----------------------------------------------//
        private readonly MostPopularFeedLogic r_MostPopularFeedLogic;

        //-------------------------------------------- Constructor --------------------------------------------//
        public FormMostPopularFeed()
        {
            InitializeComponent();
            r_MostPopularFeedLogic = new MostPopularFeedLogic();
        }

        //---------------------------------------------- Methods ----------------------------------------------//
        private void buttonShowPhotosAndPosts_Click(object i_Sender, EventArgs i_E)
        {
            fetchMostPopularFeed();
            panelMostPopular.Visible = true;
            labelMostPopularFeed.Visible = true;
        }

        private void fetchMostPopularFeed()
        {
            r_MostPopularFeedLogic.ChosenDate = new DateTime(dateTimePickerChosenDate.Value.Year, DateTime.Today.Month, DateTime.Today.Day);
            r_MostPopularFeedLogic.CompareDateStrategy = new YearCompareStrategy();

            if (r_MostPopularFeedLogic.ChosenDate > DateTime.Today)
            {
                MessageDisplayer.InvalidTimePeriod("future");
            }
            else
            {
                new Thread(() =>
                {
                    Cursor.Current = Cursors.WaitCursor;
                    updateMostPopularPost();
                    updateMostPopularPhoto();
                    Cursor.Current = Cursors.Default;
                    if (listBoxMostPopularPost.Items.Count == 0 || pictureBoxMostPopularPhoto.Image == null)
                    {
                        notifyUserAboutNonExistedItemsOnSelectedYear();
                    }
                }).Start();
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

        private Post getMostPopularPost()
        {
            Post mostPopularPost = null;

            foreach (Post post in r_MostPopularFeedLogic)
            {
                if (mostPopularPost == null || (post.Comments.Count > mostPopularPost.Comments.Count))
                {
                    mostPopularPost = post;
                }
            }

            return mostPopularPost;
        }

        private void updateMostPopularPost()
        {
            Post mostPopularPost = getMostPopularPost();

            resetMostPopularPost();
            if (mostPopularPost != null)
            {
                listBoxMostPopularPost.Invoke(new Action(() => listBoxMostPopularPost.Items.Add(mostPopularPost)));
                labelMostPopularPostCommentsNumber.Invoke(
                    new Action(() => labelMostPopularPostCommentsNumber.Text = $"{mostPopularPost.Comments.Count} Comment{(mostPopularPost.Comments.Count == 1 ? string.Empty : "s")} on your post"));
                labelMostPopularPostDate.Invoke(new Action(() => labelMostPopularPostDate.Text = $"Published At: {mostPopularPost.CreatedTime}"));
            }
        }

        private void updateMostPopularPhoto()
        {
            Photo mostPopularPhoto = r_MostPopularFeedLogic.FindMostPopularPhoto();

            resetMostPopularPhoto();
            if (mostPopularPhoto != null)
            {
                pictureBoxMostPopularPhoto.Invoke(new Action(() => pictureBoxMostPopularPhoto.Image = new Bitmap(mostPopularPhoto.ImageNormal, pictureBoxMostPopularPhoto.Size)));
                labelMostPopularPhotoCommentsNumber.Invoke(
                    new Action(() => labelMostPopularPhotoCommentsNumber.Text = $"{mostPopularPhoto.Comments.Count} Comment{(mostPopularPhoto.Comments.Count == 1 ? string.Empty : "s")} on your photo"));
                labelMostPopularPhotoDate.Invoke(new Action(() => labelMostPopularPhotoDate.Text = $"Published At: {mostPopularPhoto.CreatedTime}"));
            }
        }

        //---------------------------------------------- Resets -----------------------------------------------//
        private void resetMostPopularPost()
        {
            listBoxMostPopularPost.Invoke(new Action(() => listBoxMostPopularPost.Items.Clear()));
            labelMostPopularPostCommentsNumber.Invoke(new Action(() => labelMostPopularPostCommentsNumber.Text = string.Empty)); 
            labelMostPopularPostDate.Invoke(new Action(() => labelMostPopularPostDate.Text = string.Empty));
        }

        private void resetMostPopularPhoto()
        {
            pictureBoxMostPopularPhoto.Invoke(new Action(() => pictureBoxMostPopularPhoto.Image = null));
            labelMostPopularPhotoCommentsNumber.Invoke(new Action(() => labelMostPopularPhotoCommentsNumber.Text = string.Empty)); 
            labelMostPopularPhotoDate.Invoke(new Action(() => labelMostPopularPhotoDate.Text = string.Empty)); 
        }
    }
}
