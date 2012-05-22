using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace MusicExplorer
{
  public partial class AlbumDetails : UserControl
  {
    Album album;
    Bitmap notAvailable;

    public AlbumDetails()
    {
      InitializeComponent();

      columnHeaderTrackTitle.Width = -2;  // autosize last column

      notAvailable = Properties.Resources.NotAvailable;
      pictureBoxAlbumCover.Image = notAvailable;
    }

    public void ShowInfo(Album theAlbum)
    {
      album = theAlbum;

      ShowDetails();
      ShowCoverArt();
      ShowTracks();

      textBoxLyrics.Text = string.Empty;
    }

    void ShowDetails()
    {
      labelTitle.Text = album.Title;
      labelArtist.Text = album.Artist;
      labelLabel.Text = album.Label;
      labelDate.Text = album.Date.ToString("d");
      labelDiscs.Text = album.Discs.ToString();
      labelGenre.Text = album.Genre;
    }

    void ShowCoverArt()
    {
      if (album.ImageUrl == null)
      {
        pictureBoxAlbumCover.Image = notAvailable;
        return;
      }

      WebClient client = new WebClient();
      client.Headers["User-Agent"] = "Mozilla/4.0";

      byte[] bytes = client.DownloadData(album.ImageUrl.ToString());
      MemoryStream stream = new MemoryStream(bytes);
      pictureBoxAlbumCover.Image = System.Drawing.Image.FromStream(stream);
    }

    public void ShowTracks()
    {
      listViewTracks.Items.Clear();
      int i = 1;
      foreach (Track track in album.Tracks)
      {
        ListViewItem lvi = listViewTracks.Items.Add(i.ToString());
        string duration = string.Empty;
        if (track.duration != TimeSpan.Zero)
          duration = string.Format("{0}:{1:00}", track.duration.Minutes, track.duration.Seconds);
        lvi.SubItems.Add(duration);
        lvi.SubItems.Add(track.Title);
        i++;
      }
      columnHeaderTrackTitle.Width = -2;  // autosize last column
    }

    private void listViewTracks_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (listViewTracks.SelectedItems == null) return;
      if (listViewTracks.SelectedItems.Count == 0) return;

      string songTitle = listViewTracks.SelectedItems[0].SubItems[2].Text;
      Cursor = Cursors.WaitCursor;
      string lyrics = LyricWiki.GetLyrics(album.Artist, songTitle);
      textBoxLyrics.Text = lyrics.Replace("\n", "\r\n"); // so textbox splits text across lines
      Cursor = Cursors.Default;
    }
  }
}
