﻿using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace FaceBookWinFormsApp.Forms
{
    internal partial class FormAlbums : Form
    {
        private FacebookObjectCollection<Album> m_Albums;

        public FormAlbums(FacebookObjectCollection<Album> i_Albums)
        {
            InitializeComponent();
            m_Albums = i_Albums;
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            foreach (Album album in m_Albums)
            {
                listBoxAlbums.Items.Add(album);
            }
        }

        protected override void OnShown(EventArgs i_E)
        {
            base.OnShown(i_E);
            if (listBoxAlbums.Items.Count == 0)
            {
                MessageBox.Show("No albums to retrieve: (", "No Albums", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            Album album = listBoxAlbums.SelectedItem as Album;

            showSelectedAlbumsPhotos(album);
            showSelectedAlbumsName(album);
        }

        private void showSelectedAlbumsPhotos(Album i_Album)
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

        private void showSelectedAlbumsName(Album i_Album)
        {
            labelSelectedAlbumName.Text = i_Album.Name;
            labelSelectedAlbumName.Visible = true;
        }
    }
}
