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

        [Fact]
        public void AddDirectoryToRecentShould()
        {
            Func<UriHandler> newUriHandler = () => new UriHandler();
            
            IDirectory directory = null;
            Assert.ThrowsAny<ArgumentNullException>(() => newUriHandler.Invoke().AddToRecent(directory));

            var handler = newUriHandler.Invoke();
            handler.AddToRecent(new Directory(new Uri("file:///test/")));
            Assert.Equal(1, handler.GetRecentDirectories().Count);

            ISuggestion<IDirectory> suggestion = null;
            Assert.ThrowsAny<ArgumentNullException>(() => newUriHandler.Invoke().AddToRecent(suggestion));

            suggestion = new Suggestions<IDirectory>(null);
            Assert.ThrowsAny<ArgumentNullException>(() => newUriHandler.Invoke().AddToRecent(suggestion));

            suggestion = new Suggestions<IDirectory>(new Directory(new Uri("file:///test/")));
            handler = newUriHandler.Invoke();
            handler.AddToRecent(suggestion);
            Assert.Equal(1, handler.GetRecentDirectories().Count);
        }

        [Fact]
        public void AddFileToRecentShould()
        {
            Func<UriHandler> newUriHandler = () => new UriHandler();

            IFile file = null;
            Assert.ThrowsAny<ArgumentNullException>(() => newUriHandler.Invoke().AddToRecent(file));

            var handler = newUriHandler.Invoke();
            handler.AddToRecent(new File(new Uri("file:///test.txt")));
            Assert.Equal(1, handler.GetRecentFiles().Count);

            ISuggestion<IFile> suggestion = null;
            Assert.ThrowsAny<ArgumentNullException>(() => newUriHandler.Invoke().AddToRecent(suggestion));

            suggestion = new Suggestions<IFile>(null);
            Assert.ThrowsAny<ArgumentNullException>(() => newUriHandler.Invoke().AddToRecent(suggestion));

            suggestion = new Suggestions<IFile>(new File(new Uri("file:///test.txt")));
            handler = newUriHandler.Invoke();
            handler.AddToRecent(suggestion);
            Assert.Equal(1, handler.GetRecentFiles().Count);
        }

        [Fact]
        public void AddUnknownToRecentShould()
        {

        }
    }
}
