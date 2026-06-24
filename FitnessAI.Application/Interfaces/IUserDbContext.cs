using FitnessAI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Common.Interfaces
{
    public interface IUserDbContext
    {
        DbSet<User> Users { get; }

        DbSet<WorkoutPlan> WorkoutPlans { get; }

        DbSet<MealPlan> MealPlans { get; }

        DbSet<Progress> Progresses { get; }

        DbSet<Subscription> Subscriptions { get; }

        DbSet<Food> Foods { get; }

        DbSet<AIRecommendation> AIRecommendations { get; }

        DbSet<WaterTracking> WaterTrackings { get; }

        DbSet<SleepTracking> SleepTrackings { get; }

        DbSet<HealthAnalysisEntity> HealthAnalysisEntity { get; }

        DbSet<Notification> Notifications { get; }

        DbSet<Payment> Payments { get; }

        DbSet<Admin> Admins { get; }

        Task<int> SaveChangesAsync(
            CancellationToken cancellationToken);
    }
}