using MediatR;

namespace FitnessAI.Application.Features.Subscriptions.Commands.CreateSubscription
{
    public class CreateSubscriptionCommand : IRequest<int>
    {
        public string TenGoi { get; set; } = string.Empty;

        public decimal GiaTien { get; set; }

        public int ThoiHanNgay { get; set; }

        public DateTime NgayBatDau { get; set; }

        public DateTime NgayKetThuc { get; set; }

        public bool TrangThai { get; set; }

        public int UserId { get; set; }
    }
}