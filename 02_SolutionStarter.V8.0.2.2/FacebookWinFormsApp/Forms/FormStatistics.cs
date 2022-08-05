using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormStatistics : Form
    {
        public StatisticsLogic StatisticsLogic { get; }

        public FormStatistics(User i_LoggedInUser)
        {
            InitializeComponent();
            StatisticsLogic = new StatisticsLogic(i_LoggedInUser);
            //fetchStatistics();
        }

        private void fetchStatistics()
        {
            try
            {
                GetAlbumsAndPhotosDataInChosenMonth();
                GetNumberOfPostsInChosenMonth();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show($"Invalid date !{Environment.NewLine}Please choose a valid Month", "Invalid Date",
                    MessageBoxButtons.OK);
            }
        }

        private void GetAlbumsAndPhotosDataInChosenMonth()
        {
            int numberOfLikesOnPhotos, numberOfNewAlbums, numberOfNewPhotos;

            StatisticsLogic.AnalyzeDataOnAlbumsAndPhotosInChosenMonth(dateTimePickerChoosedMonth.Value,
                out numberOfLikesOnPhotos, out numberOfNewAlbums, out numberOfNewPhotos);
            labelNumberOfLikesOnPhotos.Text = $"{numberOfLikesOnPhotos} {(numberOfLikesOnPhotos == 1 ? " Like" : " Likes")}{ Environment.NewLine}On Photos";
            labelNumberOfNewAlbums.Text = $"{numberOfNewAlbums} New{ Environment.NewLine}{(numberOfNewAlbums == 1 ? "Album" : "Albums")}";
            labelNumberOfNewPhotos.Text = $"{numberOfNewPhotos} New{Environment.NewLine}{(numberOfNewPhotos == 1 ? "Photo" : "Photos")}";
        }

        private void GetNumberOfPostsInChosenMonth()
        {
            int numberOfPosts = StatisticsLogic.CalculateNumberOfPostsInChosenMonth(dateTimePickerChoosedMonth.Value);
            labelNumberOfPosts.Text = $"{numberOfPosts} {(numberOfPosts == 1 ? " Post" : " Posts")}{ Environment.NewLine}Published";
        }

        private void buttonShowStatistics_Click(object sender, EventArgs i_E)
        {
            panelSummary.Visible = true;
            labelMonthSummary.Visible = true;
            fetchStatistics();
        }
    }
}
