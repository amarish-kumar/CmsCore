﻿using CmsCore.Model.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CmsCore.Model.EntityBuilders
{
    public class FormBuilder
    {
        public FormBuilder(EntityTypeBuilder<Form> entityBuilder)
        {
            entityBuilder.HasKey(a => a.Id);
        }
    }
}
