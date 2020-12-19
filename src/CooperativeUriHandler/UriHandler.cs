using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CooperativeUriHandler.definitions.enums;
using CooperativeUriHandler.definitions.interfaces;
using CooperativeUriHandler.history;
using CooperativeUriHandler.implementations;

namespace CooperativeUriHandler
{
    public class UriHandler : IUriHandler
    {
        public IHistory<IDirectory> DirectoryHistory { get; private set; } = new History<IDirectory>(new List<IDirectory>());
        public IHistory<IFile> FileHistory { get; private set; } = new History<IFile>(new List<IFile>());

        public IList<ISuggestion<IDirectory>> GetRecentDirectories(int amountToReturn = 10)
        {
            var output = DirectoryHistory.TypeHistory
                .Take(amountToReturn)
                .Select(directory => new Suggestions<IDirectory>(directory))
                .Cast<ISuggestion<IDirectory>>()
                .ToList();

            return output;
        }

        public IList<ISuggestion<IFile>> GetRecentFiles(int amountToReturn = 10)
        {
            var output = FileHistory.TypeHistory
                .Take(amountToReturn)
                .Select(file => new Suggestions<IFile>(file))
                .Cast<ISuggestion<IFile>>()
                .ToList();

            return output;
        }

        public void AddToRecent(IDirectory directory)
        {
            throw new NotImplementedException();
        }

        public void AddToRecent(ISuggestion<IDirectory> directory)
        {
            throw new NotImplementedException();
        }

        public void AddToRecent(IFile file)
        {
            throw new NotImplementedException();
        }

        public void AddToRecent(ISuggestion<IFile> file)
        {
            throw new NotImplementedException();
        }

        public void AddToRecent(Uri uri)
        {
            throw new NotImplementedException();
        }

        public IDirectory GetDefaultDirectory(DefaultLocation defaultLocation)
        {
            throw new NotImplementedException();
        }
    }
}
