using System;
using System.Windows.Forms;
using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;

namespace FaceBookWinFormsApp.Forms
{
    internal partial class FormStatistics : Form
    {
        private readonly StatisticsLogic r_StatisticsLogic;

        public FormStatistics(User i_LoggedInUser)
        {
            InitializeComponent();
            r_StatisticsLogic = new StatisticsLogic(i_LoggedInUser);
        }

        private void fetchStatistics()
        {
            DateTime dateTimeChosen = new DateTime(dateTimePickerChoosedDate.Value.Year, dateTimePickerChoosedDate.Value.Month, DateTime.Today.Day);

            if (dateTimeChosen > DateTime.Today)
            {
                MessageBox.Show(
                    $"You can't choose a day from the future !{Environment.NewLine}Please choose a valid date",
                    "Invalid Date",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                getAlbumsAndPhotosDataInChosenDate();
                getNumberOfPostsInChosenDate();
            }
        }

        private void getAlbumsAndPhotosDataInChosenDate()
        {
            int numberOfLikesOnPhotos, numberOfNewAlbums, numberOfNewPhotos;

            r_StatisticsLogic.AnalyzeDataOnAlbumsAndPhotosInChosenDate(dateTimePickerChoosedDate.Value, out numberOfLikesOnPhotos, out numberOfNewAlbums, out numberOfNewPhotos);
            labelNumberOfLikesOnPhotos.Text = $"{numberOfLikesOnPhotos} Like{(numberOfLikesOnPhotos == 1 ? "" : "s")}{ Environment.NewLine}On Photos";
            labelNumberOfNewAlbums.Text = $"{numberOfNewAlbums} New{ Environment.NewLine}Album{(numberOfNewAlbums == 1 ? "" : "s")}";
            labelNumberOfNewPhotos.Text = $"{numberOfNewPhotos} New{Environment.NewLine}photo{(numberOfNewPhotos == 1 ? "" : "s")}";
        }

        private void getNumberOfPostsInChosenDate()
        {
            int numberOfPosts = r_StatisticsLogic.CalculateNumberOfPostsInChosenDate(dateTimePickerChoosedDate.Value);
            labelNumberOfPosts.Text = $"{numberOfPosts} post{(numberOfPosts == 1 ? "" : "s")}{ Environment.NewLine}Published";
        }

        private void buttonShowStatistics_Click(object sender, EventArgs i_E)
        {
            fetchStatistics();
            panelSummary.Visible = true;
            labelMonthSummary.Visible = true;
        }
    }
}
