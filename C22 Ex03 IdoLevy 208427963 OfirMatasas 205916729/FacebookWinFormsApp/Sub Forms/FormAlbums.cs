using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures;
using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp.Forms
{
    internal partial class FormAlbums : Form
    {
        //---------------------------------------------- Members ----------------------------------------------//
        private FacebookObjectCollection<Album> m_Albums;

        //-------------------------------------------- Constructor --------------------------------------------//
        public FormAlbums()
        {
            InitializeComponent();
        }

        //--------------------------------------------- On Shown ----------------------------------------------//
        protected override void OnShown(EventArgs i_E)
        {
            new Thread(fetchAlbumsAndNotifyTheUserIfThereAreNoAlbumsToRecieve).Start();
            base.OnShown(i_E);
        }

        private void fetchAlbumsAndNotifyTheUserIfThereAreNoAlbumsToRecieve()
        {
            Cursor.Current = Cursors.WaitCursor;
            fetchAlbums();
            nofityTheUserIfThereAreNoAlbumsToReceive();
            Cursor.Current = Cursors.Default;
        }

        private void fetchAlbums()
        {
            m_Albums = FacebookAccountManager.Instance.Albums;
            listBoxAlbums.Invoke(new Action(() => albumBindingSource.DataSource = m_Albums));
        }

        private void nofityTheUserIfThereAreNoAlbumsToReceive()
        {
            if (m_Albums.Count == 0)
            {
                MessageDisplayer.NoItemsAppearOnForm("albums");
            }
        }

        //---------------------------------------------- Methods ----------------------------------------------//
        private void listBoxAlbums_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            Album album = listBoxAlbums.SelectedItem as Album;
            if (album != null)
            {
                showSelectedAlbumsPhotos(album);
                showSelectedAlbumsName(album);
            }
        }

        private void showSelectedAlbumsPhotos(Album i_Album)
        {
            LazyPictureBox pictureBox;
            Size pictureBoxSize = new Size(200, 200);
            Padding pictureBoxPadding = new Padding(10);

            flowLayoutPanelSelectedAlbumPhotos.Controls.Clear();
            if(i_Album.Count == 0)
            {
                MessageDisplayer.NoItemsAppearOnForm("photos");
            }
            else
            {
                foreach (Photo photo in i_Album.Photos)
                {
                    pictureBox = new LazyPictureBox
                    {
                        Padding = pictureBoxPadding,
                        Size = pictureBoxSize,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    pictureBox.Load(photo.PictureNormalURL);
                    flowLayoutPanelSelectedAlbumPhotos.Controls.Add(pictureBox);
                }

                flowLayoutPanelSelectedAlbumPhotos.Show();
            }
        }

        private void showSelectedAlbumsName(Album i_Album)
        {
            labelSelectedAlbumName.Text = i_Album.Name;
            labelSelectedAlbumName.Visible = true;
        }
    }
}
