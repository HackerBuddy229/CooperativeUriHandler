using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CooperativeUriHandler.definitions.interfaces;

namespace CooperativeUriHandler.implementations
{
    public class File: IFile
    {
        public string Name { get; }
        public Uri Uri { get; }
        public StreamWriter GetStreamWriter(IFile location, string filename = "")
        {
            throw new NotImplementedException();
        }

        public StreamWriter GetStreamWriter(ISuggestion<IFile> location, string filename = "")
        {
            throw new NotImplementedException();
        }

        public StreamReader GetStreamReader(IFile location, string filename = "")
        {
            throw new NotImplementedException();
        }

        public StreamReader GetStreamReader(ISuggestion<IFile> location, string filename = "")
        {
            throw new NotImplementedException();
        }

        public BinaryWriter GetBinaryWriter(IFile location, string filename = "")
        {
            throw new NotImplementedException();
        }

        public BinaryWriter GetBinaryWriter(ISuggestion<IFile> location, string filename = "")
        {
            throw new NotImplementedException();
        }

        public BinaryReader GetBinaryReader(IFile location, string filename = "")
        {
            throw new NotImplementedException();
        }

        public BinaryReader GetBinaryReader(ISuggestion<IFile> location, string filename = "")
        {
            throw new NotImplementedException();
        }
    }
}
