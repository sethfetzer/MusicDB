using System;
using System.Collections.Generic;

namespace MusicExplorer
{
  public class Album
  {
    public string Id;    // MusicBrainz ID
    public string Asin;  // Amazon Standard Identification Number
    public string Title;
    public DateTime Date;
    public string ImageUrl;
    public string Label;  // e.g. Sony, Warner
    public int Discs;
    public string Genre;
    public string Artist;
    public List<Track> Tracks = new List<Track>();
  }

  public class Track
  {
    public string Id;     // MusicBrainz ID
    public TimeSpan duration;
    public string Title;
  }

}
