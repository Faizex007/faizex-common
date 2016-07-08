using System.Text.RegularExpressions;

namespace Faizex.Common
{
  /// <summary>
  /// A string extensions class.
  /// </summary>
  public static class StringExtensions
  {
    /// <summary>
    /// Adds a space before each title case character in the specified string.
    /// </summary>
    /// <param name="str">The string.</param>
    /// <returns>string</returns>
    public static string AddSpaceToTitleCaseCamel(this string str)
    {
      return str.IsNullOrEmpty() || str.Contains(" ") ? str : Regex.Replace(str, "([a-z](?=[A-Z0-9])|[A-Z](?=[A-Z][a-z]))", "$1 ");
    }

    /// <summary>
    /// Uppercases the first letter of a string.
    /// </summary>
    /// <param name="str">The string.</param>
    /// <returns>string</returns>
    public static string UppercaseFirst(this string str)
    {
      return str.IsNullOrEmpty() ? str : char.ToUpper(str[0]) + str.ToLower().Substring(1);
    }
  }
}
