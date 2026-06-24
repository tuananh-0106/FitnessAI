using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;

namespace FitnessAI.Application.Features.WaterTrackings.Commands.CreateWaterTracking
{
    public class CreateWaterTrackingHandler
        : IRequestHandler<CreateWaterTrackingCommand, int>
    {
        private readonly IUserDbContext _context;

        public CreateWaterTrackingHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(
            CreateWaterTrackingCommand request,
            CancellationToken cancellationToken)
        {
            var waterTracking = new WaterTracking
            {
                UserId = request.UserId,
                LuongNuocML = request.LuongNuocML,
                ThoiGianUong = DateTime.Now
            };

            _context.WaterTrackings.Add(waterTracking);

            await _context.SaveChangesAsync(cancellationToken);

            return waterTracking.Id;
        }
    }
}