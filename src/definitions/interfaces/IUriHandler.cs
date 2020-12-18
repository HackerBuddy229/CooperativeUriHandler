using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CooperativeUriHandler.definitions.enums;

namespace CooperativeUriHandler.definitions.interfaces
{
    public interface IUriHandler
    {
        IList<ISuggestion<IDirectory>> GetRecentDirectories(int amountToReturn = 10);
        IList<ISuggestion<IFile>> GetRecentFiles(int amountToReturn = 10);


        IDirectory GetDefaultDirectory(DefaultLocation defaultLocation);


        StreamWriter GetStreamWriter(IDirectory directory, string filename = "");
        StreamWriter GetStreamWriter(ISuggestion<IDirectory> directory, string filename = "");
        StreamWriter GetStreamWriter(IFile file);
        StreamWriter GetStreamWriter(ISuggestion<IFile> file);

        StreamReader GetStreamReader(IDirectory directory, string filename = "");
        StreamReader GetStreamReader(ISuggestion<IDirectory> directory, string filename = "");
        StreamReader GetStreamReader(IFile file);
        StreamReader GetStreamReader(ISuggestion<IFile> file);

        BinaryWriter GetBinaryWriter(IDirectory directory, string filename = "");
        BinaryWriter GetBinaryWriter(ISuggestion<IDirectory> directory, string filename = "");
        BinaryWriter GetBinaryWriter(IFile file);
        BinaryWriter GetBinaryWriter(ISuggestion<IFile> file);

        BinaryReader GetBinaryReader(IDirectory directory, string filename = "");
        BinaryReader GetBinaryReader(ISuggestion<IDirectory> directory, string filename = "");
        BinaryReader GetBinaryReader(IFile file);
        BinaryReader GetBinaryReader(ISuggestion<IFile> file);

        void AddToRecent(IDirectory directory);
        void AddToRecent(ISuggestion<IDirectory> directory);
        void AddToRecent(IFile file);
        void AddToRecent(ISuggestion<IFile> file);
        void AddToRecent(Uri uri);
    }
}
