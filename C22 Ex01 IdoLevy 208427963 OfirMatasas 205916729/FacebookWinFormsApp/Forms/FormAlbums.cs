using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormAlbums : Form
    {
        public FacebookObjectCollection<Album> Albums { get; }

        public FormAlbums(FacebookObjectCollection<Album> i_Album)
        {
            InitializeComponent();
            Albums = i_Album;
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            foreach (Album album in Albums)
            {
                listBoxAlbums.Items.Add(album);
            }
        }
        protected override void OnShown(EventArgs i_E)
        {
            base.OnShown(i_E);
            if (listBoxAlbums.Items.Count == 0)
            {
                MessageBox.Show("No albums to retrieve :(");
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            Album album = listBoxAlbums.SelectedItem as Album;

            ShowSelectedAlbumsPhotos(album);
            ShowSelectedAlbumsName(album);
        }

        private void ShowSelectedAlbumsPhotos(Album i_Album)
        {
            PictureBox pictureBox;
            Size pictureBoxSize = new Size(200, 200);
            Padding pictureBoxPadding = new Padding(10);

            flowLayoutPanelSelectedAlbumPhotos.Controls.Clear();
            foreach (Photo photo in i_Album.Photos)
            {
                pictureBox = new PictureBox()
                {
                    Image = photo.ImageNormal,
                    Padding = pictureBoxPadding,
                    Size = pictureBoxSize,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                flowLayoutPanelSelectedAlbumPhotos.Controls.Add(pictureBox);
            }

            flowLayoutPanelSelectedAlbumPhotos.Show();
        }

        private void ShowSelectedAlbumsName(Album i_Album)
        {
            labelSelectedAlbumName.Text = i_Album.Name;
            labelSelectedAlbumName.Visible = true;
        }
    }
}
