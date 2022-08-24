using BasicFacebookFeatures;
using FacebookWinFormsLogic;
using System;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Forms
{
    internal partial class FormStatistics : Form
    {
        private readonly StatisticsLogic r_StatisticsLogic;

        public FormStatistics()
        {
            InitializeComponent();
            r_StatisticsLogic = new StatisticsLogic();
        }

        private void fetchStatistics()
        {
            DateTime dateTimeFromPicker = dateTimePickerChosenDate.Value;
            DateTime chosenDate = new DateTime(dateTimeFromPicker.Year, dateTimeFromPicker.Month, DateTime.Today.Day);

            if (chosenDate > DateTime.Today)
            {
                MessageDisplayer.InvalidTimePeriod("future");
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                getAlbumsAndPhotosDataInChosenDate(chosenDate);
                getNumberOfPostsInChosenDate(chosenDate);
                Cursor.Current = Cursors.Default;
            }
        }

        private void getAlbumsAndPhotosDataInChosenDate(DateTime i_ChosenDate)
        {
            int numberOfLikesOnPhotos, numberOfNewAlbums, numberOfNewPhotos;

            r_StatisticsLogic.AnalyzeDataOnAlbumsAndPhotosInChosenDate(
                i_ChosenDate,
                out numberOfLikesOnPhotos,
                out numberOfNewAlbums,
                out numberOfNewPhotos);
            labelNumberOfLikesOnPhotos.Text = $"{numberOfLikesOnPhotos} Like{(numberOfLikesOnPhotos == 1 ? string.Empty : "s")}{Environment.NewLine}on photos";
            labelNumberOfNewAlbums.Text = $"{numberOfNewAlbums} new{Environment.NewLine}album{(numberOfNewAlbums == 1 ? string.Empty : "s")}";
            labelNumberOfNewPhotos.Text = $"{numberOfNewPhotos} new{Environment.NewLine}photo{(numberOfNewPhotos == 1 ? string.Empty : "s")}";
        }

        private void getNumberOfPostsInChosenDate(DateTime i_ChosenDate)
        {
            int numberOfPosts = r_StatisticsLogic.GetTheNumberOfPostsCreatedOnChosenDate(i_ChosenDate);
            labelNumberOfPosts.Text = $"{numberOfPosts} post{(numberOfPosts == 1 ? string.Empty : "s")}{Environment.NewLine}published";
        }

        private void buttonShowStatistics_Click(object i_Sender, EventArgs i_E)
        {
            fetchStatistics();
            panelSummary.Visible = true;
            labelMonthSummary.Visible = true;
        }
    }
}
