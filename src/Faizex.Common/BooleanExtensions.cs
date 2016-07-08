namespace Faizex.Common
{
  /// <summary>
  /// A boolean helper extension class.
  /// </summary>
  public static class BooleanExtensions
  {
    /// <summary>
    /// Converts the value of this instance to its equivalent string representation i.e. "Yes" or "No".
    /// </summary>
    /// <param name="boolean">The boolean.</param>
    /// <returns>string</returns>
    public static string ToYesNo(this bool boolean)
    {
      return boolean ? "Yes" : "No";
    }

    /// <summary>
    /// Converts the value of this instance to its equivalent integer representation i.e. "1" or "0".
    /// </summary>
    /// <param name="boolean">The boolean.</param>
    /// <returns>int</returns>
    public static int ToInt(this bool boolean)
    {
      return boolean ? 1 : 0;
    }
  }
}