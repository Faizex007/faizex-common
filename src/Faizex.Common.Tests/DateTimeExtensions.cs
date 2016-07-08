using System;
using NUnit.Framework;

namespace Faizex.Common.Tests
{
  [TestFixture]
  public class DateTimeExtensions
  {
    [Test]
    public void CalculateAge_WithMonthBefore()
    {
      var birthDate = new DateTime(1992, 1, 1);
      var refDate = new DateTime(2010, 3, 2);

      Assert.IsTrue(birthDate.CalculateAge(refDate) == 18);
    }

    [Test]
    public void CalculateAge_WithMonthAfter()
    {
      var birthDate = new DateTime(1992, 4, 1);
      var refDate = new DateTime(2010, 3, 2);

      Assert.IsTrue(birthDate.CalculateAge(refDate) == 17);
    }

    [Test]
    public void CalculateAge_WithDayAfter()
    {
      var birthDate = new DateTime(1992, 3, 3);
      var refDate = new DateTime(2010, 3, 2);

      Assert.IsTrue(birthDate.CalculateAge(refDate) == 17);
    }

    [Test]
    public void CalculateAge_WithDayBefore()
    {
      var birthDate = new DateTime(1992, 3, 1);
      var refDate = new DateTime(2010, 3, 2);

      Assert.IsTrue(birthDate.CalculateAge(refDate) == 18);
    }

    [Test]
    public void CalculateAge_WithSameDay()
    {
      var birthDate = new DateTime(1992, 3, 2);
      var refDate = new DateTime(2010, 3, 2);

      Assert.IsTrue(birthDate.CalculateAge(refDate) == 18);
    }
  }
}