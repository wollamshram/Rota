using System;
using ZooRota.Domain;

namespace ZooRota.Persistence
{
    class TaskEntity: ITask
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }

        public TaskEntity(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
