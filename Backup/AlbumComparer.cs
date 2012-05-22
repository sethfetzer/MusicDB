using System;
using System.Collections;
using System.Windows.Forms;

namespace MusicExplorer
{
  class AlbumComparer : IComparer
  {
    int columnIndex;
    public int ColumnIndex
    {
      get { return columnIndex; }
      set { columnIndex = value; }
    }

    private bool ascendingOrder;
    public bool AscendingOrder
    {
      get { return ascendingOrder; }
      set { ascendingOrder = value; }
    }

    private CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

    public int Compare(object x, object y)
    {
      ListViewItem listviewX = (ListViewItem)x;
      ListViewItem listviewY = (ListViewItem)y;

      int compareResult = comparer.Compare(listviewX.SubItems[columnIndex].Text, listviewY.SubItems[columnIndex].Text);

      if (ascendingOrder)
        return compareResult;
      else
        return (-compareResult);
    }
  }
}
