using System;
using System.Collections.Generic;
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
            var homeUriBuilder = new UriBuilder(_partialHomeUri); //TODO: check if existing
            homeUriBuilder.Path += $"{userIdentifier}/";
            HomeUri = homeUriBuilder.Uri;

            var downloadsUriBuilder = new UriBuilder(HomeUri); //TODO: check if existing
            downloadsUriBuilder.Path += "Downloads/";
            DownloadsUri = downloadsUriBuilder.Uri;
        }

        public Uri SystemRootUri { get; } = new Uri("file:///");

        private readonly Uri _partialHomeUri = new Uri("file:///home/");
        public Uri HomeUri { get; }
        public Uri DownloadsUri { get; }
    }
}
