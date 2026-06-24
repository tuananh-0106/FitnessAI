using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Infrastructure.Persistence
{
    public class ApplicationDbContext
        : DbContext, IUserDbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users => Set<User>();

        public DbSet<WorkoutPlan> WorkoutPlans => Set<WorkoutPlan>();

        public DbSet<MealPlan> MealPlans => Set<MealPlan>();

        public DbSet<Progress> Progresses => Set<Progress>();

        public DbSet<Subscription> Subscriptions => Set<Subscription>();

        public DbSet<Food> Foods => Set<Food>();

        public DbSet<AIRecommendation> AIRecommendations
            => Set<AIRecommendation>();

        public DbSet<WaterTracking> WaterTrackings
            => Set<WaterTracking>();

        public DbSet<SleepTracking> SleepTrackings
            => Set<SleepTracking>();

        public DbSet<HealthAnalysisEntity> HealthAnalysisEntity
            => Set<HealthAnalysisEntity>();

        public DbSet<Notification> Notifications
            => Set<Notification>();

        public DbSet<Payment> Payments
            => Set<Payment>();

        public DbSet<Admin> Admins
            => Set<Admin>();

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(ApplicationDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}