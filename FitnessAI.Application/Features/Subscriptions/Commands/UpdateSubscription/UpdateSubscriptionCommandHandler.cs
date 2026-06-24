using FitnessAI.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.Subscriptions.Commands.UpdateSubscription
{
    public class UpdateSubscriptionCommandHandler
        : IRequestHandler<UpdateSubscriptionCommand, bool>
    {
        private readonly IUserDbContext _context;

        public UpdateSubscriptionCommandHandler(
            IUserDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(
            UpdateSubscriptionCommand request,
            CancellationToken cancellationToken)
        {
            var subscription = await _context.Subscriptions
                .FirstOrDefaultAsync(
                    x => x.Id == request.Id,
                    cancellationToken);

            if (subscription == null)
            {
                return false;
            }

            subscription.TenGoi = request.TenGoi;
            subscription.GiaTien = request.GiaTien;
            subscription.ThoiHanNgay = request.ThoiHanNgay;
            subscription.NgayBatDau = request.NgayBatDau;
            subscription.NgayKetThuc = request.NgayKetThuc;
            subscription.TrangThai = request.TrangThai;
            subscription.UserId = request.UserId;

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}