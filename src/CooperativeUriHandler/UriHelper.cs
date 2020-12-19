using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CooperativeUriHandler.definitions.enums;
using CooperativeUriHandler.implementations;
using Directory = System.IO.Directory;
using File = System.IO.File;

namespace CooperativeUriHandler
{
    public static class UriHelper
    {
        public static PositionType GetPositionType(Uri uri)
        {
            if (File.Exists(uri.AbsolutePath))
                return PositionType.File;
            if (Directory.Exists(uri.AbsolutePath))
                return PositionType.Directory;

            return !Path.HasExtension(uri.AbsolutePath) ? PositionType.Directory : PositionType.File;
        }
    }
}
