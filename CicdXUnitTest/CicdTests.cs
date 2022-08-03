using CicdApp.Pages;
using Xunit;

namespace CicdXUnitTest
{
    public class CicdTests
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
