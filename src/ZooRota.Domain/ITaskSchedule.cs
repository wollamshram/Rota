using System.Collections.Generic;

namespace ZooRota.Domain
{
    public interface ITaskSchedule
    {
        ITask Task { get; }
        Dictionary<string, List<IPerson> > Shifts { get; }
    }
}
