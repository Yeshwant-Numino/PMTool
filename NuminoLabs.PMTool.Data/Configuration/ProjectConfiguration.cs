using NuminoLabs.PMTool.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NuminoLabs.PMTool.Data.Configuration
{
    public class ProjectConfiguration 
    {
        public ProjectConfiguration(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.ProjectName).IsRequired().HasMaxLength(200);                 
        }
    }
}
