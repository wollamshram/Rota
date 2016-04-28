using System;
using System.Collections.Generic;
using System.Linq;
using ZooRota.Domain;

namespace ZooRota.Persistence
{
    class TestPersonRepository: IPersonRepository
    {
        private readonly List<IPerson> _persons = new List<IPerson>
        {
            new PersonEntity(new Guid(), "Fiona"),
            new PersonEntity(new Guid(), "Becky")
        };

        public IPerson GetById(Guid id)
        {
            return _persons.Single(person => person.Id == id);
        }

        public void Add(IPerson personToAdd)
        {
            _persons.Add(personToAdd);
        }
    }
}
