using Lightman.Mvc;
using System;
using Xunit;

namespace Lightman.XunitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Jun1ToUnix()
        {
            var jun1 = new DateTime(2022, 6, 1);
            var sec = Util.DotNetDateTimeToUnixEpochSeconds(jun1);
            var result = Util.UnixEpochSecondsToDotNetDateTime(sec);
            Assert.Equal(result, jun1);
        }

        [Fact]
        public void UnixToJun1()
        {
            var jun1 = 1654056000; //from online conversion tool
            var result = Util.UnixEpochSecondsToDotNetDateTime(jun1);
            Assert.Equal(result, new DateTime(2022, 6, 1));
        }
    }
}