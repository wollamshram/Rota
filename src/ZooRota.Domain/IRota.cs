using System;
using System.Collections.Generic;

namespace ZooRota.Domain
{
    public interface IRota
    {
        TimeSpan[] Timings { get; }
        List<ITask> Tasks { get; }
        List<IShift> Shifts { get; } 
    }
}
