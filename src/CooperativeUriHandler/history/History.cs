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
        public History(IList<T> typeHistory)
        {
            TypeHistory = typeHistory;
        }

        public IList<T> TypeHistory { get; }
    }
}
