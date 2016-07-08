using NUnit.Framework;

namespace Faizex.Common.Tests
{
  [TestFixture]
  public class BooleanExtensionsTests
  {
    [Test]
    public void ToYesNo_ReturnsYes()
    {
      Assert.IsTrue(true.ToYesNo() == "Yes");
    }

    [Test]
    public void ToYesNo_ReturnsNo()
    {
      Assert.IsTrue(false.ToYesNo() == "No");
    }

    [Test]
    public void ToInt_Returns1()
    {
      Assert.IsTrue(true.ToInt() == 1);
    }

    [Test]
    public void ToInt_Returns0()
    {
      Assert.IsTrue(false.ToInt() == 0);
    }
  }
}