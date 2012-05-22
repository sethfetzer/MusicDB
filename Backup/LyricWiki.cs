using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Windows.Forms;

using MusicExplorer.LyricWikiWs;

namespace MusicExplorer
{
  /// <summary>
  /// This class uses SOAP to access the LyricWiki.org web service.
  /// </summary>
  public class LyricWiki
  {
    static LyricWikiWs.LyricWiki lyricWikiWebService = new LyricWikiWs.LyricWiki();
    
    public static string GetLyrics(string artistName, string songTitle)
    {
      try
      {
        LyricsResult result = lyricWikiWebService.getSong(artistName, songTitle);
        return result.lyrics;
      }
      catch (WebException wex)
      {
        MessageBox.Show(string.Format("A communication error occurred ({0}). The LyricWiki server might be down.", wex.Status), "Couldn't retrieve lyrics for track");
        return "<lyrics couldn't be retrieved, due to an error>";
      }
      catch (Exception ex)
      {
        MessageBox.Show(string.Format("An error occurred ({0}). The error may have been caused by bad data from the LyricWiki server.", ex.Message), "Couldn't retrieve lyrics for track");
        return "<lyrics couldn't be retrieved, due to an error>";
      }
    }
  }
}
