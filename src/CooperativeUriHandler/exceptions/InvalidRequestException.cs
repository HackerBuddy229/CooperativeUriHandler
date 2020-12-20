using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperativeUriHandler.exceptions
{
    public class InvalidRequestException : Exception
    {
        public InvalidRequestException(string msg) : base(msg)
        {
        }
    }
}
