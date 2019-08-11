using System;

namespace Domain.BaseModel
{
    public interface IEntity
    {
        Guid ID { get; set; }
    }
}
