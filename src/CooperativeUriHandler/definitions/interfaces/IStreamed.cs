using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperativeUriHandler.definitions.interfaces
{
    public interface IStreamed<in T> where T : IPositioned, INamed
    {
        public StreamWriter GetStreamWriter(T location, string filename = "");
        public StreamWriter GetStreamWriter(ISuggestion<T> location, string filename = "");


        public StreamReader GetStreamReader(T location, string filename = "");
        public StreamReader GetStreamReader(ISuggestion<T> location, string filename = "");

        public BinaryWriter GetBinaryWriter(T location, string filename = "");
        public BinaryWriter GetBinaryWriter(ISuggestion<T> location, string filename = "");


        public BinaryReader GetBinaryReader(T location, string filename = "");
        public BinaryReader GetBinaryReader(ISuggestion<T> location, string filename = "");
    }
}
