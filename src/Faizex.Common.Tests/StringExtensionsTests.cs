using NUnit.Framework;

namespace Faizex.Common.Tests
{
  [TestFixture]
  public class StringExtensionsTests
  {
    [Test]
    public void AddSpaceToTitleCaseCamel_String_ReturnsTrueIfHasSpace()
    {
      const string str = "ThisIsAString";
      Assert.IsTrue(str.AddSpaceToTitleCaseCamel() == "This Is A String");
    }

    [Test]
    public void UppercaseFirst_String_ReturnsTrueIfIsUppercase()
    {
      const string str = "this cat is mine.";
      Assert.IsTrue(str.UppercaseFirst() == "This cat is mine.");
    }
  }
}