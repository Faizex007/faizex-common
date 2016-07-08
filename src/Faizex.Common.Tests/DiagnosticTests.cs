using System;
using NUnit.Framework;

namespace Faizex.Common.Tests
{
  [TestFixture]
  public class DiagnosticTests
  {
    [Test]
    public void ThrowIfNull()
    {
      Assert.Catch<ArgumentNullException>(() =>
      {
        Diagnostic.ThrowIfNull(Variable.NullObject);
      });
    }

    [Test]
    public void ThrowIfNullOrEmpty()
    {
      Assert.Catch<ArgumentNullException>(() =>
      {
        Diagnostic.ThrowIfNullOrEmpty(Variable.NullString);
      });

      Assert.Catch<ArgumentNullException>(() =>
      {
        Diagnostic.ThrowIfNullOrEmpty(Variable.EmptyString);
      });

      Assert.Catch<ArgumentNullException>(() =>
      {
        Diagnostic.ThrowIfNullOrEmpty(Variable.WhiteSpaceString);
      });
    }
  }
}