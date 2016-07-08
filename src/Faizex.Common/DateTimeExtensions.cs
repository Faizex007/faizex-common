using System;

namespace Faizex.Common
{
  /// <summary>
  /// 
  /// </summary>
  public static class DateTimeExtensions
  {
    /// <summary>
    /// Calculates the age from a specific date.
    /// </summary>
    /// <param name="dateTime">The date time.</param>
    /// <returns>int</returns>
    public static int CalculateAge(this DateTime dateTime)
    {
      return CalculateAge(dateTime, DateTime.Now.Date);
    }

    /// <summary>
    /// Calculates the age from a specific date with a specified reference date.
    /// </summary>
    /// <param name="dateTime">The date time.</param>
    /// <param name="referenceDate">The referenced date time.</param>
    /// <returns>int</returns>
    public static int CalculateAge(this DateTime dateTime, DateTime referenceDate)
    {
      var years = referenceDate.Year - dateTime.Year;
      if (referenceDate.Month < dateTime.Month || (referenceDate.Month == dateTime.Month && referenceDate.Day < dateTime.Day))
        years--;
      return years;
    }
  }
}