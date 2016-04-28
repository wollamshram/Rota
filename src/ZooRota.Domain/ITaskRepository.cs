using System;

namespace ZooRota.Domain
{
    public interface ITaskRepository
    {
        ITask GetById(Guid id);
        void Add(ITask taskToAdd);
    }
}
