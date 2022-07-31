using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormAlbums : Form
    {

        private User User { get; }
        public FormAlbums(User i_User)
        {
            User = i_User;
            InitializeComponent();
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            foreach (Album album in User.Albums)
            {
                listBoxAlbums.Items.Add(album);
            }

            listBoxAlbums.Show();
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            Album album = listBoxAlbums.SelectedItem as Album;
            PictureBox pictureBox;
            Size pictureBoxSize = new Size(200, 200);
            Padding pictureBoxPadding = new Padding(10);

            if(listBoxAlbums.SelectedItems.Count == 1)
            {
                flowLayoutPanelSelectedAlbumPhotos.Controls.Clear();
                foreach(Photo photo in album.Photos)
                {
                    pictureBox = new PictureBox() { 
                        Image = photo.ImageNormal, 
                        Padding = pictureBoxPadding, 
                        Size = pictureBoxSize, 
                        SizeMode = PictureBoxSizeMode.StretchImage};
                    flowLayoutPanelSelectedAlbumPhotos.Controls.Add(pictureBox);
                }

                flowLayoutPanelSelectedAlbumPhotos.Show();
            }
        }
    }
}
