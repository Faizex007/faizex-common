using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Faizex.Common.Tests
{
  [TestFixture]
  public class AsyncTests
  {
    [Test]
    public void AwaitFalse_ReturnsTrueIfTypeIsExpected()
    {
      var task = Task.CompletedTask.AwaitFalse();
      Assert.IsInstanceOf(typeof(ConfiguredTaskAwaitable), task);
    }

    [Test]
    public void AwaitFalseTResult_ReturnsTrueIfTypeIsExpected()
    {
      var task = Task.FromResult(0).AwaitFalse();
      Assert.IsInstanceOf(typeof(ConfiguredTaskAwaitable<int>), task);
    }

    [Test]
    public void AwaitTrue_ReturnsTrueIfTypeIsExpected()
    {
      var task = Task.CompletedTask.AwaitTrue();
      Assert.IsInstanceOf(typeof(ConfiguredTaskAwaitable), task);
    }

    [Test]
    public void AwaitTrueTResult_ReturnsTrueIfTypeIsExpected()
    {
      var task = Task.FromResult(0).AwaitTrue();
      Assert.IsInstanceOf(typeof(ConfiguredTaskAwaitable<int>), task);
    }
  }
}