using Domain.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.BaseModule
{
    public abstract class AggregateRoot : IAggregateRoot
    {
        public abstract Guid ID { get; set; }
    }
}
