using System.Windows.Forms;

namespace Faizex.Common
{
  /// <summary>
  /// The Windows Form helper class.
  /// </summary>
  public static class WinFormsHelper
  {
    /// <summary>
    /// Gets the first data bound item binded to this <see cref="DataGridView"/>.
    /// </summary>
    /// <typeparam name="T">The type to convert to.</typeparam>
    /// <param name="gridView">The data grid view.</param>
    /// <returns>T</returns>
    public static T GetFirstSelectedItem<T>(this DataGridView gridView)
    {
      return (T)gridView.SelectedRows[0].DataBoundItem;
    }

    /// <summary>
    /// Gets the <see cref="System.Data.SqlClient.SortOrder"/> of this <see cref="DataGridView"/> with specified column index.
    /// </summary>
    /// <param name="gridView">The data grid view.</param>
    /// <param name="columnIndex">The column index.</param>
    /// <returns>SortOrder</returns>
    public static SortOrder GetSortOrder(this DataGridView gridView, int columnIndex)
    {
      var column = gridView.Columns[columnIndex];
      if (column.SortMode == DataGridViewColumnSortMode.NotSortable)
        column.SortMode = DataGridViewColumnSortMode.Programmatic;

      var headerCell = column.HeaderCell;
      if (headerCell.SortGlyphDirection == SortOrder.None || headerCell.SortGlyphDirection == SortOrder.Descending)
      {
        headerCell.SortGlyphDirection = SortOrder.Ascending;
        return SortOrder.Ascending;
      }

      headerCell.SortGlyphDirection = SortOrder.Descending;
      return SortOrder.Descending;
    }
  }
}