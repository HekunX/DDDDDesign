﻿using Domain.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.BaseModule
{
    public abstract class AggregateRoot : IAggregateRoot
    {
        [Key]
        public Guid ID { get; set; } = Guid.NewGuid();
    }
}
