﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModBus.Net.FBox
{
    public class FBoxSignalRProtocalLinker : FBoxProtocalLinker
    {
        public FBoxSignalRProtocalLinker(string machineId, string localSequence, SignalRSigninMsg msg) : base(machineId, localSequence, msg)
        {
        }
    }
}
