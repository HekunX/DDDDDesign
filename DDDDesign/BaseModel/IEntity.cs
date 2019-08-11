using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.BaseModel
{
    public interface IEntity
    {
        [Key]
        Guid ID { get; set; }
    }
}
