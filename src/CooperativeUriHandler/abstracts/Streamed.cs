using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CooperativeUriHandler.definitions.interfaces;

namespace CooperativeUriHandler.abstracts
{
    public abstract class Streamed : IStreamed
    {
        private readonly Uri _uri;

        protected Streamed(string uri)
        {
            _ = uri ?? throw new ArgumentNullException(nameof(uri));
            _uri = new Uri(uri);
        }

        protected Streamed(Uri uri)
        {
            _ = uri ?? throw new ArgumentNullException(nameof(uri));
            _uri = uri;
        }

        public StreamWriter GetStreamWriter(string filename = "")
        {
            throw new NotImplementedException();
        }

        public StreamReader GetStreamReader(string filename = "")
        {
            throw new NotImplementedException();
        }

        public BinaryWriter GetBinaryWriter(string filename = "")
        {
            throw new NotImplementedException();
        }

        public BinaryReader GetBinaryReader(string filename = "")
        {
            throw new NotImplementedException();
        }
    }
}
