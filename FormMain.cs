using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MusicExplorer
{
  public partial class FormMain : Form
  {
    AlbumComparer sorter = new AlbumComparer();
    AlbumDetails albumDetails;
    Dictionary<string, Album> albumIds = new Dictionary<string, Album>();
    FormAmazonCredentials formAmazonCredentials = new FormAmazonCredentials();

    public FormMain()
    {
      InitializeComponent();

      albumDetails = new AlbumDetails();
      albumDetails.Dock = DockStyle.Fill;
      panelRight.Controls.Add(albumDetails);

      columnHeaderTitle.Width = -2;  // autosize last column
      listViewAlbums.ListViewItemSorter = sorter;

      textBoxArtist.Text = Properties.Settings.Default.Artist;
      if (textBoxArtist.Text == string.Empty)
        textBoxArtist.Text = "The Beatles";
    }

    public string StatusMessage
    {
      get { return labelStatusBar.Text; }
      set { labelStatusBar.Text = value; labelStatusBar.Update();  }
    }
	
    private void buttonSearch_Click(object sender, EventArgs e)
    {
      listViewAlbums.Items.Clear();
      albumIds.Clear();

      Cursor = Cursors.WaitCursor;
      StatusMessage = "Searching...";
      string artistId = MusicBrainz.FindArtistId(textBoxArtist.Text);
      if (artistId == null) 
      {
        Cursor = Cursors.Default;
        StatusMessage = "Artist not found. Keep in mind that artist names are case-sensitive.";
        return;
      }

      Properties.Settings.Default.Artist = textBoxArtist.Text;
      Properties.Settings.Default.Save();

      StatusMessage = "Retrieving albums...";
      List<Album> albums = MusicBrainz.FindAlbums(artistId, textBoxArtist.Text);
      Cursor = Cursors.Default;

      if (albums == null) return;  // an error occurred while retrieving list

      if (albums.Count == 0)
      {
        Cursor = Cursors.Default;
        StatusMessage = "No albums found";
        return;
      }
      StatusMessage = string.Format("Albums found: {0}", albums.Count);

      foreach (Album album in albums)
      {
        if (album.Asin == null) continue;  // skip albums with no ASIN
        if (albumIds.ContainsKey(album.Id)) continue;  // to skip duplicates
        albumIds.Add(album.Id, album);
        string year = album.Date == DateTime.MinValue ? string.Empty : album.Date.Year.ToString();
        ListViewItem lvi = listViewAlbums.Items.Add(year);
        lvi.SubItems.Add(album.Title);
        lvi.Tag = album;
      }

      columnHeaderTitle.Width = -2;  // autosize last column
    }
    
    private void listViewAlbums_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (listViewAlbums.SelectedItems == null) return;
      if (listViewAlbums.SelectedItems.Count == 0) return;

      Album album = listViewAlbums.SelectedItems[0].Tag as Album;

      Cursor = Cursors.WaitCursor;
      StatusMessage = "Retrieving info...";
      Amazon.GetAlbumDetails(album);
      album.Tracks = MusicBrainz.FindTracks(album.Id);
      StatusMessage = string.Empty;
      Cursor = Cursors.Default;

      albumDetails.ShowInfo(album);
    }

    private void listViewAlbums_ColumnClick(object sender, ColumnClickEventArgs e)
    {
      // update the listview sorting criteria
      if (e.Column == sorter.ColumnIndex)
        sorter.AscendingOrder = !sorter.AscendingOrder; // reverse sort order
      else
      {
        // Set the column number that is to be sorted; default to ascending.
        sorter.ColumnIndex = e.Column;
        sorter.AscendingOrder = true;
      }

      // resort the list with the new criteria
      listViewAlbums.Sort();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FormAbout formAbout = new FormAbout();
      formAbout.ShowDialog();
    }

    private void amazonCredentialsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      DialogResult result = formAmazonCredentials.ShowDialog();
      if (result != DialogResult.OK) return;
      Properties.Settings.Default.AmazonAwsAccountNumber = formAmazonCredentials.AccountNumber;
      Properties.Settings.Default.AmazonAwsAccessKeyId = formAmazonCredentials.AccessKeyId;
      Properties.Settings.Default.Save();
    }
  }
}