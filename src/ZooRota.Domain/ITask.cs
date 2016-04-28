using System;

namespace ZooRota.Domain
{
    public interface ITask
    {
        Guid Id { get; }
        string Name { get; set; }
    }
}
