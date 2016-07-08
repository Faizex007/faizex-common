using System.Collections.Generic;
using NUnit.Framework;

namespace Faizex.Common.Tests
{
  [TestFixture]
  public class DictionaryHelperTests
  {
    [Test]
    public void Merge()
    {
      var dict1 = new Dictionary<string, string>();
      var dict2 = new Dictionary<string, string>();

      dict1.Add("Key01", "Value1");
      dict1.Add("Key04", "Value4");
      dict1.Add("Key03", "Value3");
      dict1.Add("Key02", "Value2");

      dict2.Add("Key01", "Value1");
      dict2.Add("Key04", "Value4");
      dict2.Add("Key05", "Value5");
      dict2.Add("Key06", "Value6");

      var newDict = dict1.Merge(dict2);
      Assert.IsTrue(newDict.ContainsKey("Key05") && newDict.ContainsKey("Key06"));
    }

    [Test]
    public void ToDictionary()
    {
      var dict = Variable.TestClass.ToDictionary();
      Assert.IsTrue(new Dictionary<string, object>().GetType() == dict.GetType());
    }
  }
}