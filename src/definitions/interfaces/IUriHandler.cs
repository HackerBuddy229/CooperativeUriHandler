using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CooperativeUriHandler.definitions.enums;

namespace CooperativeUriHandler.definitions.interfaces
{
    public interface IUriHandler : IHistoricallyTimed
    {
        IDirectory GetDefaultDirectory(DefaultLocation defaultLocation);
    }
}
