using System;
using System.Collections.Generic;
using System.Text;

namespace Dizajn_LV_6
{
    interface IApstractProductIterator
    {
        Product First();
        Product Next();
        bool IsDone { get; }
        Product Current { get; }
    }
}
