using System.Collections.Generic;

namespace Faizex.Common.Tests
{
  public static class Variable
  {
    public static readonly object NullObject = null;

    public static readonly string NullString = null;
    public static readonly string EmptyString = "";
    public static readonly string WhiteSpaceString = "   ";

    public static IEnumerable<string> NullStringList = null;
    public static IEnumerable<string> EmptyStringList = new List<string>();

    public static TestClass TestClass = new TestClass();
    public static IEnumerable<TestClass> NullObjectList = null;
    public static IEnumerable<TestClass> EmptyObjectList = new List<TestClass>();
  }
}