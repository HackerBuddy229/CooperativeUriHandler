using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperativeUriHandler.definitions.interfaces
{
    public interface ISuggestion<out T> : IReadable where T : INamed, IPositioned
    {
        public T Suggestion { get; }
    }
}
