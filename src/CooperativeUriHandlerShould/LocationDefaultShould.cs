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
    public class LocationDefaultShould
    {
        [Fact]
        public void ConstructorShould()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                var linuxDefault = new LinuxLocationDefault(Environment.UserName);

                Assert.Equal("/", linuxDefault.SystemRootUri.AbsolutePath); //root
                Assert.Equal($"/home/{Environment.UserName}/", linuxDefault.HomeUri.AbsolutePath); //home
                Assert.Equal($"/home/{Environment.UserName}/Downloads/", linuxDefault.DownloadsUri.AbsolutePath); //downloads
            } else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                var windowsDefault = new WindowsLocationDefault(Environment.UserName);

                Assert.Equal("C:/", windowsDefault.SystemRootUri.AbsolutePath);//root
                Assert.Equal($"C:/Users/{Environment.UserName}/", windowsDefault.HomeUri.AbsolutePath);//home
                Assert.Equal($"C:/Users/{Environment.UserName}/Downloads/", windowsDefault.DownloadsUri.AbsolutePath);//Downloads
            }
        }
    }
}
