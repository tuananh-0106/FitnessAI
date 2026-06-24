using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.Progress.Commands.UpdateProgress
{
    public class UpdateProgressCommandHandler
        : IRequestHandler<UpdateProgressCommand, bool>
    {
        private readonly IUserDbContext _context;

        public UpdateProgressCommandHandler(
            IUserDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(
            UpdateProgressCommand request,
            CancellationToken cancellationToken)
        {
            var progress = await _context.Progresses
                .FirstOrDefaultAsync(
                    x => x.Id == request.Id,
                    cancellationToken);

            if (progress == null)
            {
                return false;
            }

            progress.CanNang = request.CanNang;
            progress.ChieuCao = request.ChieuCao;
            progress.MoCoThe = request.MoCoThe;
            progress.KhoiLuongCo = request.KhoiLuongCo;
            progress.CaloriesDotChay = (int)request.CaloriesDotChay;
            progress.GhiChu = request.GhiChu;
            progress.UserId = request.UserId;

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}