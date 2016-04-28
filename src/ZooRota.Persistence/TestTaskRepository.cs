using System;
using System.Collections.Generic;
using System.Linq;
using ZooRota.Domain;

namespace ZooRota.Persistence
{
    class TestTaskRepository: ITaskRepository
    {
        private readonly List<ITask> _tasks = new List<ITask>
        {
            new TaskEntity(new Guid(), "Monkeys"),
            new TaskEntity(new Guid(), "Penguins")
        };

        public ITask GetById(Guid id)
        {
            return _tasks.Single(task => task.Id == id);
        }

        public void Add(ITask taskToAdd)
        {
            _tasks.Add(taskToAdd);
        }
    }
}
