﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Entities.Models;

namespace Data.Mappings
{
    class ComponentOrderPriorityMap : EntityTypeConfiguration<ComponentOrderPriority>
    {
        public ComponentOrderPriorityMap()
        {
            this.HasKey(i => i.Id);

            this.Property(i => i.Order).IsRequired();
            this.Property(i => i.Value).IsRequired();

            this.Ignore(c => c.State);
        }
    }
}