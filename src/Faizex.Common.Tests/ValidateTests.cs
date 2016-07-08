using System.Collections.Generic;
using NUnit.Framework;

namespace Faizex.Common.Tests
{
  [TestFixture]
  public class ValidateTests
  {
    #region Lists

    [Test]
    public void IsNullOrEmpty_List_ReturnsTrueIfNullOrEmpty()
    {
      List<string> nullList = null;

      Assert.IsTrue(nullList.IsNullOrEmpty());
      Assert.IsTrue(new List<string>().IsNullOrEmpty());
    }

    #endregion

    #region Numbers

    [Test]
    public void IsNegative_Number_ReturnsTrueIfNegative()
    {
      const decimal dec = (decimal)-1.1;
      const double dbl = -1.1;
      const float flt = (float)-1.1;
      const int integer = -1;
      const long lng = (long)-1.1;

      Assert.IsTrue(dec.IsNegative());
      Assert.IsTrue(dbl.IsNegative());
      Assert.IsTrue(flt.IsNegative());
      Assert.IsTrue(integer.IsNegative());
      Assert.IsTrue(lng.IsNegative());
    }

    [Test]
    public void IsPositive_Number_ReturnTrueIfPositive()
    {
      const decimal dec = (decimal)1.1;
      const double dbl = 1.1;
      const float flt = (float)1.1;
      const int integer = 1;
      const long lng = (long)1.1;

      Assert.IsTrue(dec.IsPositive());
      Assert.IsTrue(dbl.IsPositive());
      Assert.IsTrue(flt.IsPositive());
      Assert.IsTrue(integer.IsPositive());
      Assert.IsTrue(lng.IsPositive());
    }

    [Test]
    public void IsValueBetween_Number_ReturnsTrueIfBetween()
    {
      const decimal dec = (decimal)5.1;
      const double dbl = 5.1;
      const float flt = (float)5.1;
      const int integer = 5;
      const long lng = (long)5.1;

      Assert.IsTrue(dec.IsValueBetween(0, 10));
      Assert.IsTrue((-dec).IsValueBetween(-100, 0));
      Assert.IsTrue(dbl.IsValueBetween(0, 10));
      Assert.IsTrue((-dbl).IsValueBetween(-100, 0));
      Assert.IsTrue(flt.IsValueBetween(0, 10));
      Assert.IsTrue((-flt).IsValueBetween(-100, 0));
      Assert.IsTrue(integer.IsValueBetween(0, 10));
      Assert.IsTrue((-integer).IsValueBetween(-100, 0));
      Assert.IsTrue(lng.IsValueBetween(0, 10));
      Assert.IsTrue((-lng).IsValueBetween(-100, 0));
    }

    [Test]
    public void IsValueBetween_Number_ReturnsFalseIfNotBetween()
    {
      const decimal dec = (decimal)5.1;
      const double dbl = 5.1;
      const float flt = (float)5.1;
      const int integer = 5;
      const long lng = (long)5.1;

      Assert.IsFalse(dec.IsValueBetween(10, 20));
      Assert.IsFalse((-dec).IsValueBetween(0, 10));
      Assert.IsFalse(dbl.IsValueBetween(10, 20));
      Assert.IsFalse((-dbl).IsValueBetween(0, 10));
      Assert.IsFalse(flt.IsValueBetween(10, 20));
      Assert.IsFalse((-flt).IsValueBetween(0, 10));
      Assert.IsFalse(integer.IsValueBetween(10, 20));
      Assert.IsFalse((-integer).IsValueBetween(0, 10));
      Assert.IsFalse(lng.IsValueBetween(10, 20));
      Assert.IsFalse((-lng).IsValueBetween(0, 10));
    }

    #endregion

    #region Objects

    [Test]
    public void IsNull_Object_ReturnsTrueIfNull()
    {
      object obj = null;
      Assert.IsTrue(obj.IsNull());
    }

    #endregion

    #region Strings

    [Test]
    public void IsNullOrEmpty_String_ReturnsTrueIfNullOrEmpty()
    {
      string nullString = null;

      Assert.IsTrue(nullString.IsNullOrEmpty());
      Assert.IsTrue("".IsNullOrEmpty());
      Assert.IsTrue("   ".IsNullOrEmpty());
    }

    [Test]
    public void IsNumeric_String_ReturnsTrueIfIsNumeric()
    {
      const string str1 = "123";
      const string str2 = "123,123";
      const string str3 = "123.123";
      const string str4 = "123,123.123";

      Assert.IsTrue(str1.IsNumeric());
      Assert.IsTrue(str2.IsNumeric());
      Assert.IsTrue(str3.IsNumeric());
      Assert.IsTrue(str4.IsNumeric());
    }

    #endregion
  }
}
