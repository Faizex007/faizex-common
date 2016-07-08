using System.Collections.Generic;
using System.Linq;

namespace Faizex.Common
{
  /// <summary>
  /// A class for validation.
  /// </summary>
  public static class ValidateHelper
  {
    #region Lists

    /// <summary>
    /// Checks if an <see cref="IEnumerable{T}"/> is null or empty.
    /// </summary>
    /// <typeparam name="T">The generic type.</typeparam>
    /// <param name="list">The list to check.</param>
    /// <returns>bool</returns>
    public static bool IsNullOrEmpty<T>(this IEnumerable<T> list)
    {
      return list == null || !list.Any();
    }

    #endregion
    
    #region Numbers

    /// <summary>
    /// Checks if a number is negative.
    /// </summary>
    /// <param name="number">The number to check.</param>
    /// <returns>bool</returns>
    public static bool IsNegative(this decimal number)
    {
      return number < 0;
    }

    /// <summary>
    /// Checks if a number is negative.
    /// </summary>
    /// <param name="number">The number to check.</param>
    /// <returns>bool</returns>
    public static bool IsNegative(this double number)
    {
      return number < 0;
    }

    /// <summary>
    /// Checks if a number is negative.
    /// </summary>
    /// <param name="number">The number to check.</param>
    /// <returns>bool</returns>
    public static bool IsNegative(this float number)
    {
      return number < 0;
    }

    /// <summary>
    /// Checks if a number is negative.
    /// </summary>
    /// <param name="number">The number to check.</param>
    /// <returns>bool</returns>
    public static bool IsNegative(this int number)
    {
      return number < 0;
    }

    /// <summary>
    /// Checks if a number is negative.
    /// </summary>
    /// <param name="number">The number to check.</param>
    /// <returns>bool</returns>
    public static bool IsNegative(this long number)
    {
      return number < 0;
    }

    /// <summary>
    /// Checks if a number is positive.
    /// </summary>
    /// <param name="number">The number to check.</param>
    /// <returns>bool</returns>
    public static bool IsPositive(this decimal number)
    {
      return number >= 0;
    }

    /// <summary>
    /// Checks if a number is positive.
    /// </summary>
    /// <param name="number">The number to check.</param>
    /// <returns>bool</returns>
    public static bool IsPositive(this double number)
    {
      return number >= 0;
    }

    /// <summary>
    /// Checks if a number is positive.
    /// </summary>
    /// <param name="number">The number to check.</param>
    /// <returns>bool</returns>
    public static bool IsPositive(this float number)
    {
      return number >= 0;
    }

    /// <summary>
    /// Checks if a number is positive.
    /// </summary>
    /// <param name="number">The number to check.</param>
    /// <returns>bool</returns>
    public static bool IsPositive(this int number)
    {
      return number >= 0;
    }

    /// <summary>
    /// Checks if a number is positive.
    /// </summary>
    /// <param name="number">The number to check.</param>
    /// <returns>bool</returns>
    public static bool IsPositive(this long number)
    {
      return number >= 0;
    }

    /// <summary>
    /// Checks if a number is in between two values.
    /// </summary>
    /// <param name="number">The number to check.</param>
    /// <param name="lowerBound">The lower bound.</param>
    /// <param name="upperBound">The upper bound.</param>
    /// <returns>bool</returns>
    public static bool IsValueBetween(this decimal number, decimal lowerBound, decimal upperBound)
    {
      return number >= lowerBound && number <= upperBound;
    }

    /// <summary>
    /// Checks if a number is in between two values.
    /// </summary>
    /// <param name="number">The number to check.</param>
    /// <param name="lowerBound">The lower bound.</param>
    /// <param name="upperBound">The upper bound.</param>
    /// <returns>bool</returns>
    public static bool IsValueBetween(this double number, double lowerBound, double upperBound)
    {
      return number >= lowerBound && number <= upperBound;
    }

    /// <summary>
    /// Checks if a number is in between two values.
    /// </summary>
    /// <param name="number">The number to check.</param>
    /// <param name="lowerBound">The lower bound.</param>
    /// <param name="upperBound">The upper bound.</param>
    /// <returns>bool</returns>
    public static bool IsValueBetween(this float number, float lowerBound, float upperBound)
    {
      return number >= lowerBound && number <= upperBound;
    }

    /// <summary>
    /// Checks if a number is in between two values.
    /// </summary>
    /// <param name="number">The number to check.</param>
    /// <param name="lowerBound">The lower bound.</param>
    /// <param name="upperBound">The upper bound.</param>
    /// <returns>bool</returns>
    public static bool IsValueBetween(this int number, int lowerBound, int upperBound)
    {
      return number >= lowerBound && number <= upperBound;
    }

    /// <summary>
    /// Checks if a number is in between two values.
    /// </summary>
    /// <param name="number">The number to check.</param>
    /// <param name="lowerBound">The lower bound.</param>
    /// <param name="upperBound">The upper bound.</param>
    /// <returns>bool</returns>
    public static bool IsValueBetween(this long number, long lowerBound, long upperBound)
    {
      return number >= lowerBound && number <= upperBound;
    }

    #endregion

    #region Objects

    /// <summary>
    /// Checks if an object is null.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns>bool</returns>
    public static bool IsNull(this object obj)
    {
      return obj == null;
    }

    #endregion

    #region Strings

    /// <summary>
    /// Checks if a string is null, empty, or consists only of white space characters.
    /// </summary>
    /// <param name="str">The string to check.</param>
    /// <returns>bool</returns>
    public static bool IsNullOrEmpty(this string str)
    {
      return string.IsNullOrWhiteSpace(str);
    }

    /// <summary>
    /// Checks if a string is a numeric value.
    /// </summary>
    /// <param name="str">The string to check.</param>
    /// <returns>bool</returns>
    public static bool IsNumeric(this string str)
    {
      if (str.Contains("."))
        str = str.Replace(".", "");
      if (str.Contains(","))
        str = str.Replace(",", "");

      double number;
      return double.TryParse(str, out number);
    }

    #endregion
  }
}