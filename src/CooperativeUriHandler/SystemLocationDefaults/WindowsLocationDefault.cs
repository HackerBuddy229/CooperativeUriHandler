using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CooperativeUriHandler.definitions.interfaces;
using CooperativeUriHandler.implementations;
using Directory = System.IO.Directory;

namespace CooperativeUriHandler.SystemLocationDefaults
{
    public class WindowsLocationDefault: ISystemDefault
    {
        public WindowsLocationDefault(string userIdentifier)
        {
            SetHomeDependencies(userIdentifier);
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

        public Uri SystemRootUri { get; } = new Uri("file://C:/");

        private readonly Uri _partialHomeUri = new Uri("file://C:/Users/");
        public Uri HomeUri { get; private set; } = null;
        public Uri DownloadsUri { get; private set; } = null;
    }
}
