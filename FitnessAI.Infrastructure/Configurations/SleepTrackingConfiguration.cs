using FitnessAI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessAI.Infrastructure.Persistence.Configurations
{
    public class SleepTrackingConfiguration : IEntityTypeConfiguration<SleepTracking>
    {
        public void Configure(EntityTypeBuilder<SleepTracking> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}