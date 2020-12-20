using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperativeUriHandler.exceptions
{
    public class RuntimeNotSupportedException : Exception
    {
        public RuntimeNotSupportedException(string osDescription): base(osDescription) { }
    }
}
