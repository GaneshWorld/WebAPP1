using Xunit;

namespace webtest
{
    public class Webtest
    {
        [Fact]
        public void demotest()
        {
            int i = 1;
            bool result = false;
            if (i == 1) result = true;
            Assert.True(result, "value should be equal to 1");
        }
    }
}