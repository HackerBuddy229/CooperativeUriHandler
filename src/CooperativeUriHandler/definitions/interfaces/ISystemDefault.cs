﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperativeUriHandler.definitions.interfaces
{
    public interface ISystemDefault
    {
        public Uri SystemRootUri { get; }
        public Uri HomeUri { get; }
        public Uri DownloadsUri { get; }
    }
}
