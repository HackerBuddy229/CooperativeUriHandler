using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CooperativeUriHandler.definitions.interfaces;

namespace CooperativeUriHandler.implementations
{
    public class Suggestions<T> : ISuggestion<T> where T : INamed, IPositioned
    {
        public string HumanReadableRepresentation => Suggestion.Name;
        public T Suggestion { get; }

        public Suggestions(T suggestion)
        {
            this.Suggestion = suggestion;
        }
    }
}
