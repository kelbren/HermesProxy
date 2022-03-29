﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HermesProxy.World.Objects
{
    public enum BattleGroundStatus : uint
    {
        None        = 0,    // first status, should mean bg is not instance
        WaitQueue   = 1,    // means bg is empty and waiting for queue
        WaitJoin    = 2,    // this means, that BG has already started and it is waiting for more players
        InProgress  = 3,    // means bg is running
        WaitLeave   = 4     // means some faction has won BG and it is ending
    };
}
