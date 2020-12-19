using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CooperativeUriHandler.definitions.interfaces;

namespace CooperativeUriHandler.implementations
{
    public class Directory : IDirectory
    {
        public string Name { get; }
        public Uri Uri { get; }
        public StreamWriter GetStreamWriter(IDirectory location, string filename = "")
        {
            throw new NotImplementedException();
        }

        public StreamWriter GetStreamWriter(ISuggestion<IDirectory> location, string filename = "")
        {
            throw new NotImplementedException();
        }

        public StreamReader GetStreamReader(IDirectory location, string filename = "")
        {
            throw new NotImplementedException();
        }

        public StreamReader GetStreamReader(ISuggestion<IDirectory> location, string filename = "")
        {
            throw new NotImplementedException();
        }

        public BinaryWriter GetBinaryWriter(IDirectory location, string filename = "")
        {
            throw new NotImplementedException();
        }

        public BinaryWriter GetBinaryWriter(ISuggestion<IDirectory> location, string filename = "")
        {
            throw new NotImplementedException();
        }

        public BinaryReader GetBinaryReader(IDirectory location, string filename = "")
        {
            throw new NotImplementedException();
        }

        public BinaryReader GetBinaryReader(ISuggestion<IDirectory> location, string filename = "")
        {
            throw new NotImplementedException();
        }
    }
}
