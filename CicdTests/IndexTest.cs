using CicdApp.Pages;
using System;
using Xunit;

namespace CicdTests
{
    public class IndexTest
    {
        [Fact]
        public void AddNormalTest()
        {
            var classToTest = new IndexModel();

            var actualValue = classToTest.Add(4, 5);
            var expectedValue = 9;

            Assert.Equal(expectedValue, actualValue);

        }
    }
}
