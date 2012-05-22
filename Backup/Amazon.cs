using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Net;

using MusicExplorer.AmazonAws;

namespace MusicExplorer
{
  /// <summary>
  /// This class uses SOAP to access the Amazon Associates Web Services (formerly called ECS 4.0).
  /// </summary>
  public class Amazon
  {
    static AWSECommerceService amazonWebService = new AWSECommerceService();
    static bool errorMessageShown;

    static bool AreCredentialsMissing
    {
      get
      {
        string s = Properties.Settings.Default.AmazonAwsAccountNumber;
        if (string.IsNullOrEmpty(s)) return true;
        if (s.Contains("<get value from Amazon>")) return true;

        s = Properties.Settings.Default.AmazonAwsAccessKeyId;
        if (string.IsNullOrEmpty(s)) return true;
        if (s.Contains("<get value from Amazon>")) return true;

        return false;
      }
    }

    public static void GetAlbumDetails(Album album)
    {
      try
      {
        DoGetAlbumDetails(album);
      }
      catch (WebException wex)
      {
        MessageBox.Show(string.Format("A communication error occurred ({0}). The Amazon server might be down.", wex.Status), "Couldn't retrieve album details");
      }
      catch (Exception ex)
      {
        MessageBox.Show(string.Format("An error occurred ({0}). The error may have been caused by bad data from the Amazon server.", ex.Message), "Couldn't retrieve album details");
      }
    }

    public static void DoGetAlbumDetails(Album album)
    {
      if (AreCredentialsMissing)
      {
        if (errorMessageShown) return;
        errorMessageShown = true;  // so we don't show the message again
        MessageBox.Show("To retrieve album details, Music Explorer requires access to the Amazon Associates Web Service. " +
                        "This service is free, but requires you to register for an associates account. " +
                        "See http://aws.amazon.com/associates for details. Once you have an account, enter " +
                        "your Account Number and Access Key ID in the Options->Amazon Credentials dialog box.",
                        "Not all album details available");
        return;
      }

      ItemLookup search = new ItemLookup();
      search.AssociateTag = Properties.Settings.Default.AmazonAwsAccountNumber;
      search.AWSAccessKeyId = Properties.Settings.Default.AmazonAwsAccessKeyId;

      ItemLookupRequest request = new ItemLookupRequest();
      request.ItemId = new string[] { album.Asin };
      request.IdType = ItemLookupRequestIdType.ASIN;
      request.ResponseGroup = new string[] { "Images", "ItemAttributes", "BrowseNodes" };
      search.Request = new ItemLookupRequest[] { request };

      ItemLookupResponse response = amazonWebService.ItemLookup(search);

      AmazonAws.Items items = response.Items[0];
      if (items.Item == null) return;
      if (items.Item.Length == 0) return;
      AmazonAws.Item item = items.Item[0];
      if (item == null) return;

      if (item.MediumImage == null)
        album.ImageUrl = null;
      else
        album.ImageUrl = item.MediumImage.URL;

      if (item.ItemAttributes != null)
        album.Label = item.ItemAttributes.Label;

      if (item.ItemAttributes.NumberOfDiscs != null)
        album.Discs = int.Parse(item.ItemAttributes.NumberOfDiscs);

      album.Genre = GetGenre(item);
    }
    static string GetGenre(AmazonAws.Item item)
    {
      if (item.BrowseNodes == null) return null;

      string genre = string.Empty;
      foreach (BrowseNode node in item.BrowseNodes.BrowseNode)
      {
        if (node.Name.ToLower() == "general")
          if (node.Ancestors != null)
            return node.Ancestors[0].Name;
      }
      return "<unspecified>";
    }

  }
}
