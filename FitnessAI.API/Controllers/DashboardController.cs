using FitnessAI.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetDashboard()
        {
            var totalUsers = await _context.Users.CountAsync();

            var totalWorkoutPlans =
                await _context.WorkoutPlans.CountAsync();

            var totalMealPlans =
                await _context.MealPlans.CountAsync();

            var totalProgress =
                await _context.Progresses.CountAsync();

            var result = new
            {
                TotalUsers = totalUsers,
                TotalWorkoutPlans = totalWorkoutPlans,
                TotalMealPlans = totalMealPlans,
                TotalProgress = totalProgress
            };

            return Ok(result);
        }
    }
}