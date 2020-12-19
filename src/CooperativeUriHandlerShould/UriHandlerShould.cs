using System;
using Xunit;
using CooperativeUriHandler;
using CooperativeUriHandler.definitions.interfaces;
using CooperativeUriHandler.implementations;

namespace CooperativeUriHandlerShould
{
    public class UriHandlerShould
    {
        [Fact]
        public void GetRecentDirectoriesShould()
        {
            Func<IUriHandler> newHandler = () => new UriHandler(); 
            var uriHandler = newHandler.Invoke();

            //test more than 20
            for (var index = 0; index < 25; index++)
                uriHandler.AddToRecent(new Directory("C:\\test"));

            Assert.Equal(20, uriHandler.GetRecentDirectories(21).Count);
            //test less than 1
            uriHandler = newHandler.Invoke();

            for (var index = 0; index < 25; index++)
                uriHandler.AddToRecent(new Directory(new Uri("C:\\test")));
            
            Assert.Equal(1, uriHandler.GetRecentDirectories(-12).Count);
        }

        [Fact]
        public void GetRecentFilesShould()
        {
            Func<IUriHandler> newHandler = () => new UriHandler();
            var uriHandler = newHandler.Invoke();

            //test more than 20
            for (var index = 0; index < 25; index++)
                uriHandler.AddToRecent(new File("C:\\test"));

            Assert.Equal(20, uriHandler.GetRecentFiles(21).Count);
            //test less than 1
            uriHandler = newHandler.Invoke();

            for (var index = 0; index < 25; index++)
                uriHandler.AddToRecent(new File(new Uri("C:\\test")));

            Assert.Equal(1, uriHandler.GetRecentFiles(-12).Count);
        }
    }
}
