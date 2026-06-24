using FitnessAI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessAI.Infrastructure.Persistence.Configurations
{
    public class HealthAnalysisConfiguration : IEntityTypeConfiguration<HealthAnalysisEntity>
    {
        public void Configure(EntityTypeBuilder<HealthAnalysisEntity> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}