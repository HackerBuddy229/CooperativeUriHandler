﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperativeUriHandler.definitions.interfaces
{
    public interface IHistory<out T>
    {
        public IEnumerable<T> TypeHistory { get; }
    }
}
