using System;

namespace ZooRota.Domain
{
    public interface IPersonRepository
    {
        IPerson GetById(Guid id);
        void Add(IPerson personToAdd);
    }
}
