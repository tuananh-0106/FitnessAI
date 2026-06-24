using FitnessAI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessAI.Infrastructure.Persistence.Configurations
{
    public class AIRecommendationConfiguration : IEntityTypeConfiguration<AIRecommendation>
    {
        public void Configure(EntityTypeBuilder<AIRecommendation> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ThucDonDeXuat)
                   .HasMaxLength(2000);
        }
    }
}