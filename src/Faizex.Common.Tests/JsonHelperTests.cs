using NUnit.Framework;

namespace Faizex.Common.Tests
{
  [TestFixture]
  public class JsonHelperTests
  {
    [Test]
    public void FromJson()
    {
      var json = Variable.TestClass.ToJson();
      var obj = json.FromJson<TestClass>();
      Assert.IsTrue(Variable.TestClass.GetType() == obj.GetType());
    }

    [Test]
    public void ToJson()
    {
      var testClass = Variable.TestClass.ToJson();
      Assert.IsTrue(testClass.IsJson());
    }
  }
}