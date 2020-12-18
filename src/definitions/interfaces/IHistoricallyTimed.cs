using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperativeUriHandler.definitions.interfaces
{
    public interface IHistoricallyTimed
    {
        IList<ISuggestion<IDirectory>> GetRecentDirectories(int amountToReturn = 10);
        IList<ISuggestion<IFile>> GetRecentFiles(int amountToReturn = 10);

        void AddToRecent(IDirectory directory);
        void AddToRecent(ISuggestion<IDirectory> directory);
        void AddToRecent(IFile file);
        void AddToRecent(ISuggestion<IFile> file);
        void AddToRecent(Uri uri);
    }
}
