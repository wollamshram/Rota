using System;
using ZooRota.Domain;

namespace ZooRota.Persistence
{
    class PersonEntity: IPerson
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }

        public PersonEntity(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
