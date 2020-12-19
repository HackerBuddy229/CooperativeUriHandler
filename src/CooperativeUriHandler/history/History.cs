using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CooperativeUriHandler.definitions.interfaces;

namespace CooperativeUriHandler.history
{
    public class History<T> : IHistory<T>
    {
        public History(IEnumerable<T> typeHistory)
        {
            TypeHistory = typeHistory;
        }

        public IEnumerable<T> TypeHistory { get; }
    }
}
