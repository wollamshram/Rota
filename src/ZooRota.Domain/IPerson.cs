using System;

namespace ZooRota.Domain
{
    public interface IPerson
    {
        Guid Id { get; }
        string Name { get; set; }
    }
}
