using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CooperativeUriHandler.definitions.interfaces;

namespace CooperativeUriHandler.SystemLocationDefaults
{
    public class WindowsLocationDefault: ISystemDefault
    {
        public WindowsLocationDefault(string userIdentifier)
        {
            var homeUriBuilder = new UriBuilder(_partialHomeUri);
            homeUriBuilder.Path += $"{userIdentifier}/";
            HomeUri = homeUriBuilder.Uri;

            var downloadsUriBuilder = new UriBuilder(HomeUri);
            downloadsUriBuilder.Path += "Downloads/";
            DownloadsUri = downloadsUriBuilder.Uri;
        }

        public Uri SystemRootUri { get; } = new Uri("file://C:/");

        private readonly Uri _partialHomeUri = new Uri("file://C:/Users/");
        public Uri HomeUri { get; }
        public Uri DownloadsUri { get; }
    }
}
