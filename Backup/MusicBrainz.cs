using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Xml;
using System.Xml.XPath;
using System.Windows.Forms;
using System.Web;

namespace MusicExplorer
{
  /// <summary>
  /// This class handles all RESTful access to the MusicBrainz web service.
  /// </summary>
  public class MusicBrainz
  {
    // find the artist ID of a given artist.
    public static string FindArtistId(string name)
    {
      try
      {
        string uri = string.Format("http://musicbrainz.org/ws/1/artist/?query={0}&type=xml", name);
        XPathDocument doc = new XPathDocument(uri);
        XPathNavigator nav = doc.CreateNavigator();
        XmlNamespaceManager nsmgr = new XmlNamespaceManager(nav.NameTable);
        nsmgr.AddNamespace("mb", "http://musicbrainz.org/ns/mmd-1.0#");
        string xpath = string.Format("//mb:artist[mb:name=\"{0}\"]", name);   // The artist name is case-sensitive!
        XPathNodeIterator ni = nav.Select(xpath, nsmgr);
        if (!ni.MoveNext()) return null;
        XPathNavigator current = ni.Current;
        return current.GetAttribute("id", nsmgr.DefaultNamespace);
      }
      catch (WebException wex)
      {
        MessageBox.Show(string.Format("A communication error occurred ({0}). The MusicBrainz server might be down.", wex.Status), "Couldn't resolve artist name");
        return null;
      }
      catch (Exception ex)
      {
        MessageBox.Show(string.Format("An error occurred ({0}). The error may have been caused by bad data from the MusicBrainz server.", ex.Message), "Couldn't resolve artist name");
        return null;
      }
    }

    // get all the albums for a given artist (e.g. The Beatles)
    public static List<Album> FindAlbums(string artistId, string artistName)
    {
      try
      {
        return DoFindAlbums(artistId, artistName);
      }
      catch (WebException wex)
      {
        MessageBox.Show(string.Format("A communication error occurred ({0}). The MusicBrainz server might be down.", wex.Status), "Couldn't retrieve albums for artist");
        return null;
      }
      catch (Exception ex)
      {
        MessageBox.Show(string.Format("An error occurred ({0}). The error may have been caused by bad data from the MusicBrainz server.", ex.Message), "Couldn't retrieve albums for artist");
        return null;
      }
    }

    public static List<Album> DoFindAlbums(string artistId, string artistName)
    {
      string uri = string.Format("http://musicbrainz.org/ws/1/artist/{0}?type=xml&inc=sa-Official+release-events", artistId);
      XPathDocument doc = new XPathDocument(uri);
      XPathNavigator nav = doc.CreateNavigator();
      XmlNamespaceManager nsmgr = new XmlNamespaceManager(nav.NameTable);
      string ns = "http://musicbrainz.org/ns/mmd-1.0#";
      nsmgr.AddNamespace("mb", ns);
      XPathNodeIterator ni = nav.Select("//mb:release", nsmgr);
      List<Album> albums = new List<Album>();
      while (ni.MoveNext())
      {
        XPathNavigator current = ni.Current;
        Album album = new Album();
        album.Artist = artistName;
        album.Id = current.GetAttribute("id", string.Empty);
        current.MoveToChild("title", ns);
        album.Title = HttpUtility.HtmlDecode(current.InnerXml);

        current.MoveToParent();
        if (current.MoveToChild("asin", ns))
          album.Asin = current.InnerXml;

        current.MoveToParent();
        if (current.MoveToChild("release-event-list", ns))
        {
          current.MoveToChild("event", ns);
          string s = current.GetAttribute("date", string.Empty); // month and day may be missing
          album.Date = GetDate(s);
        }
        current.MoveToChild("title", ns);
        albums.Add(album);
      }
      return albums;
    }

    // return a DateTime from a string of the form yyyy-MM-dd, yyyy-MM or yyyy
    static DateTime GetDate(string s)
    {
      if (string.IsNullOrEmpty(s)) return DateTime.MinValue;
      string[] words = s.Split("-".ToCharArray());
      if (words.Length == 3) return DateTime.ParseExact(s, "yyyy-MM-dd", null);
      if (words.Length == 2) return DateTime.ParseExact(s, "yyyy-MM", null);
      if (words.Length == 1) return DateTime.ParseExact(s, "yyyy", null);
      return DateTime.MinValue;
    }

    // get all the tracks for a given album
    public static List<Track> FindTracks(string albumId)
    {
      try
      {
        return DoFindTracks(albumId);
      }
      catch (WebException wex)
      {
        MessageBox.Show(string.Format("A communication error occurred ({0}). The MusicBrainz server might be down.", wex.Status), "Couldn't retrieve tracks for album");
        return new List<Track>();
      }
      catch (Exception ex)
      {
        MessageBox.Show(string.Format("An error occurred ({0}). The error may have been caused by bad data from the MusicBrainz server.", ex.Message), "Couldn't retrieve tracks for album");
        return new List<Track>();
      }
    }

    public static List<Track> DoFindTracks(string albumId)
    {
      string uri = string.Format("http://musicbrainz.org/ws/1/release/{0}?type=xml&inc=tracks", albumId);
      XPathDocument doc = new XPathDocument(uri);
      XPathNavigator nav = doc.CreateNavigator();
      XmlNamespaceManager nsmgr = new XmlNamespaceManager(nav.NameTable);
      string ns = "http://musicbrainz.org/ns/mmd-1.0#";
      nsmgr.AddNamespace("mb", ns);
      XPathNodeIterator ni = nav.Select("//mb:track", nsmgr);
      List<Track> tracks = new List<Track>();
      while (ni.MoveNext())
      {
        XPathNavigator current = ni.Current;
        Track track = new Track();
        track.Id = current.GetAttribute("id", string.Empty);
        current.MoveToChild("title", ns);
        track.Title = HttpUtility.HtmlDecode(current.InnerXml);
        if (current.MoveToNext("duration", ns))
        {
          string duration = current.InnerXml;
          track.duration = TimeSpan.FromMilliseconds(double.Parse(duration));
        }
        tracks.Add(track);
      }
      return tracks;
    }
  }
}
