using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperativeUriHandler.definitions.interfaces
{
    public interface IStreamed
    {
        public StreamWriter GetStreamWriter(string filename = "");

        public StreamReader GetStreamReader(string filename = "");

        public BinaryWriter GetBinaryWriter(string filename = "");

        public BinaryReader GetBinaryReader(string filename = "");

    }
}
