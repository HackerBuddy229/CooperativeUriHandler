using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CooperativeUriHandler.SystemLocationDefaults;
using Xunit;

namespace CooperativeUriHandlerShould
{
    public class WindowsLocationDefaultShould
    {
        [Fact]
        public void ConstructorShould()
        {
            var WindowsDefault = new WindowsLocationDefault("hackerbuddy");

            Assert.Equal("C:/", WindowsDefault.SystemRootUri.AbsolutePath);//root
            Assert.Equal("C:/Users/hackerbuddy/", WindowsDefault.HomeUri.AbsolutePath);//home
            Assert.Equal("C:/Users/hackerbuddy/Downloads/", WindowsDefault.DownloadsUri.AbsolutePath);//Downloads
        }
    }
}
