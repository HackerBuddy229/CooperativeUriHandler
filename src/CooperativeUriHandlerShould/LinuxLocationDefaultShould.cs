using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CooperativeUriHandler.SystemLocationDefaults;
using Xunit;

namespace CooperativeUriHandlerShould
{
    public class LinuxLocationDefaultShould
    {
        [Fact]
        public void ConstructorShould()
        {
            var testDeaDefault = new LinuxLocationDefault("hackerbuddy");

            Assert.Equal("/", testDeaDefault.SystemRootUri.AbsolutePath); //root
            Assert.Equal("/home/hackerbuddy/", testDeaDefault.HomeUri.AbsolutePath); //home
            Assert.Equal("/home/hackerbuddy/Downloads/", testDeaDefault.DownloadsUri.AbsolutePath); //downloads
        }
    }
}
