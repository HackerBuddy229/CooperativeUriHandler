using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperativeUriHandler.definitions.interfaces
{
    public interface IStreamed<in T> where T : IPositioned
    {
        StreamWriter GetStreamWriter(T location, string filename = "");
        StreamWriter GetStreamWriter(ISuggestion<T> location, string filename = "");


        StreamReader GetStreamReader(T location, string filename = "");
        StreamReader GetStreamReader(ISuggestion<T> location, string filename = "");

        BinaryWriter GetBinaryWriter(T location, string filename = "");
        BinaryWriter GetBinaryWriter(ISuggestion<T> location, string filename = "");


        BinaryReader GetBinaryReader(T location, string filename = "");
        BinaryReader GetBinaryReader(ISuggestion<T> location, string filename = "");
    }
}
