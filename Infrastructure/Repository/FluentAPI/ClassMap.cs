﻿using Domain.Model;
using Infrastructure.DataBaseContext.EFContext;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.FluentAPI
{
    public class ClassMap:EntityTypeConfiguration<Class>
    {
        public ClassMap()
        {
            HasMany(x => x.Students).WithRequired(x => x.Class).HasForeignKey(x => x.ClassGUID).WillCascadeOnDelete();
            ToTable("Class");
        }
    }
}
