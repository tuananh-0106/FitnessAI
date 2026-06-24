using FitnessAI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessAI.Infrastructure.Persistence.Configurations
{
    public class WaterTrackingConfiguration : IEntityTypeConfiguration<WaterTracking>
    {
        public void Configure(EntityTypeBuilder<WaterTracking> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}