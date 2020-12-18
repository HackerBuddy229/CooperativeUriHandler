using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperativeUriHandler.definitions.interfaces
{
    public interface IUriHandler
    {
        IList<ISuggestion<IDirectory>> GetRecentDirectories();
        IList<ISuggestion<IFile>> GetRecentFiles();

        IList<ISuggestion<IDirectory>> GetSuggestedDirectories();
        IList<ISuggestion<IFile>> GetSuggestedFiles();

        IDirectory GetDefaultDirectory();


         StreamWriter GetStreamWriter();
         StreamReader GetStreamReader();

         BinaryWriter GetBinaryWriter();
         BinaryReader GetBinaryReader();

         void AddToRecent();
    }
}
