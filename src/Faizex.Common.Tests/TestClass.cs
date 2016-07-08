using System;
using System.Collections.Generic;

namespace Faizex.Common.Tests
{
  public class TestClass
  {
    public TestClass()
    {
      TestId = "123";
      TestName = "Test";
      TestValue = "Value";
      TestInteger = 1;
      TestEnum = TestEnum.Test3;
      TestList = new List<string>();
      Created = DateTime.Now;
    }

    public string TestId { get; set; }
    public string TestName { get; set; }
    public string TestValue { get; set; }
    public int TestInteger { get; set; }
    public TestEnum TestEnum { get; set; }
    public IEnumerable<string> TestList { get; set; }
    public DateTime Created { get; set; }
  }

  public enum TestEnum
  {
    Test1, Test2, Test3, Test4, Test5
  }
}