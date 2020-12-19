using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperativeUriHandler.definitions.interfaces
{
    public interface IHistoricallyTimed
    {
        public IHistory<IDirectory> DirectoryHistory { get; }
        public IHistory<IFile> FileHistory { get; }

        public IList<ISuggestion<IDirectory>> GetRecentDirectories(int amountToReturn = 10);
        public IList<ISuggestion<IFile>> GetRecentFiles(int amountToReturn = 10);

        public void AddToRecent(IDirectory directory);
        public void AddToRecent(ISuggestion<IDirectory> directory);
        public void AddToRecent(IFile file);
        public void AddToRecent(ISuggestion<IFile> file);
        public void AddToRecent(Uri uri);
    }
}
