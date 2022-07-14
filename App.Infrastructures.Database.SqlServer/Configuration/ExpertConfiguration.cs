using App.Domain.Core.ExpertAgg.Entities;
using App.Domain.Core.SuggestionAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructures.Database.SqlServer.Configuration
{
    public class ExpertConfiguration : IEntityTypeConfiguration<Expert>
    {
        public void Configure(EntityTypeBuilder<Expert> builder)
        {
            builder
                .HasMany<Suggestion>(x => x.Suggestions)
                .WithOne(x => x.Expert)
                .HasForeignKey(x => x.ExpertId);

            builder
                .HasMany<ExpertSkill>(x => x.ExpertSkills)
                .WithOne(x => x.Expert)
                .HasForeignKey(x => x.ExpertId);

        }

        
    }
}
