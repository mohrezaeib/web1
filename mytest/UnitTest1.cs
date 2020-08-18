using System;
using Xunit;
using web3.Controllers;

namespace mytest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var d = new Demo();
            Assert.Equal("demo name ", d.Name);
        }
    }
}
