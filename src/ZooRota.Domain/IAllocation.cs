using System;
using System.Collections.Generic;

namespace ZooRota.Domain
{
    public interface IShift
    {
        TimeSpan Timing { get; }
        Guid TaskId { get; }
        List<Guid> AllocatedPersons { get; }
    }
}
