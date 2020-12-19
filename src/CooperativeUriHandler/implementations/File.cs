using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CooperativeUriHandler.abstracts;
using CooperativeUriHandler.definitions.interfaces;

namespace CooperativeUriHandler.implementations
{
    public class File: Streamed, IFile
    {
        public File(string uri) : base(uri) => this.Uri = new Uri(uri); //TODO : null checking

        public File(Uri uri) : base(uri) => this.Uri = uri; //TODO : null checking

        public string Name { get; }
        public Uri Uri { get; }
    }
}
