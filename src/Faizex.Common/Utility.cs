using System;
using System.Text.RegularExpressions;
using Humanizer;

namespace Faizex.Common
{
  /// <summary>
  /// Utility helper class.
  /// </summary>
  public static class Utility
  {
    /// <summary>
    /// Checks if this string is the same as the specified query string.
    /// </summary>
    public static bool IsLike(this string str, string query, RegexOptions options = RegexOptions.IgnoreCase)
    {
      var pattern = @"\b\w*" + query + @"\w*\b";
      return Regex.IsMatch(str, pattern, options);
    }

    /// <summary>
    /// Turns a string into an existing enum member.
    /// </summary>
    /// <typeparam name="TEnum">The generic enum type.</typeparam>
    /// <param name="str">The string.</param>
    /// <returns>TEnum</returns>
    public static TEnum ToEnum<TEnum>(this string str) where TEnum : struct, IComparable, IFormattable
    {
      return str.DehumanizeTo<TEnum>();
    }

    /// <summary>
    /// Turns an enum member to a title case string.
    /// </summary>
    /// <param name="obj">The enum object.</param>
    /// <returns>string</returns>
    public static string ToTitleCase(this Enum obj)
    {
      return obj.Humanize().Transform(To.TitleCase);
    }
  }
}