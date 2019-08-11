using System;

namespace Domain.BaseModel
{
    public abstract class AggregateRoot : IAggregateRoot
    {
        public Guid ID { get; set; }
    }
}
