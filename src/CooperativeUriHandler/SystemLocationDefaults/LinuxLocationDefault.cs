using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CooperativeUriHandler.definitions.interfaces;

namespace CooperativeUriHandler.SystemLocationDefaults
{
    public class LinuxLocationDefault : ISystemDefault
    {

        public LinuxLocationDefault(string userIdentifier)
        {
            
        }

        private void SetHomeDependencies(string userIdentifier)
        {
            var homeUriBuilder = new UriBuilder(_partialHomeUri);
            homeUriBuilder.Path += $"{userIdentifier}/";
            if (!Directory.Exists(homeUriBuilder.Uri.AbsolutePath))
                return;
            HomeUri = homeUriBuilder.Uri;

            var downloadsUriBuilder = new UriBuilder(HomeUri);
            downloadsUriBuilder.Path += "Downloads/";
            if (!Directory.Exists(downloadsUriBuilder.Uri.AbsolutePath))
                return;
            DownloadsUri = downloadsUriBuilder.Uri;
        }

        public Uri SystemRootUri { get; } = new Uri("file:///");

        private readonly Uri _partialHomeUri = new Uri("file:///home/");
        public Uri HomeUri { get; private set; }
        public Uri DownloadsUri { get; private set; }
    }
}
