using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace FaceBookWinFormsApp.Forms
{
    internal partial class FormStatistics : Form
    {
        private StatisticsLogic m_StatisticsLogic;

        public FormStatistics(User i_LoggedInUser)
        {
            InitializeComponent();
            m_StatisticsLogic = new StatisticsLogic(i_LoggedInUser);
        }

        private void fetchStatistics()
        {
            DateTime dateTimeChosen = new DateTime(dateTimePickerChoosedDate.Value.Year,
                dateTimePickerChoosedDate.Value.Month, DateTime.Today.Day);

            if (dateTimeChosen > DateTime.Today)
            {
                MessageBox.Show($"You can't choose a day from the future !{Environment.NewLine}Please choose a valid date",
                    "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            m_StatisticsLogic.AnalyzeDataOnAlbumsAndPhotosInChosenDate(dateTimePickerChoosedDate.Value,
                out numberOfLikesOnPhotos, out numberOfNewAlbums, out numberOfNewPhotos);
            labelNumberOfLikesOnPhotos.Text = $"{numberOfLikesOnPhotos} {(numberOfLikesOnPhotos == 1 ? " Like" : " Likes")}{ Environment.NewLine}On Photos";
            labelNumberOfNewAlbums.Text = $"{numberOfNewAlbums} New{ Environment.NewLine}{(numberOfNewAlbums == 1 ? "Album" : "Albums")}";
            labelNumberOfNewPhotos.Text = $"{numberOfNewPhotos} New{Environment.NewLine}{(numberOfNewPhotos == 1 ? "Photo" : "Photos")}";
        }

        private void getNumberOfPostsInChosenDate()
        {
            int numberOfPosts = m_StatisticsLogic.CalculateNumberOfPostsInChosenDate(dateTimePickerChoosedDate.Value);
            labelNumberOfPosts.Text = $"{numberOfPosts} {(numberOfPosts == 1 ? " Post" : " Posts")}{ Environment.NewLine}Published";
        }

        private void buttonShowStatistics_Click(object sender, EventArgs i_E)
        {
            fetchStatistics();
            panelSummary.Visible = true;
            labelMonthSummary.Visible = true;
        }
    }
}
