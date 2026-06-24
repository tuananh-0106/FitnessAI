using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;

namespace FitnessAI.Application.Features.Subscriptions.Commands.CreateSubscription
{
    public class CreateSubscriptionCommandHandler
        : IRequestHandler<CreateSubscriptionCommand, int>
    {
        private readonly IUserDbContext _context;

        public CreateSubscriptionCommandHandler(
            IUserDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(
            CreateSubscriptionCommand request,
            CancellationToken cancellationToken)
        {
            var subscription = new Subscription
            {
                TenGoi = request.TenGoi,
                GiaTien = request.GiaTien,
                ThoiHanNgay = request.ThoiHanNgay,
                NgayBatDau = request.NgayBatDau,
                NgayKetThuc = request.NgayKetThuc,
                TrangThai = request.TrangThai,
                UserId = request.UserId
            };

            _context.Subscriptions.Add(subscription);

            await _context.SaveChangesAsync(cancellationToken);

            return subscription.Id;
        }
    }
}