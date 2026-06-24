using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Application.DTOs.Auth;
using FitnessAI.Application.Features.Auth.Commands.Login;
using FitnessAI.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.Auth.Commands.Login
{
    public class LoginCommandHandler
    : IRequestHandler<LoginCommand, LoginResponse>
    {
        private readonly IJwtService _jwtService;
        private readonly IUserDbContext _context;


    public LoginCommandHandler(
        IJwtService jwtService,
        IUserDbContext context)
        {
            _jwtService = jwtService;
            _context = context;
        }

        public async Task<LoginResponse> Handle(
            LoginCommand request,
            CancellationToken cancellationToken)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(
                    x => x.Email == request.Email,
                    cancellationToken);

            if (user == null)
            {
                throw new Exception("Tài khoản không tồn tại");
            }

            if(request.Password != user.PasswordHash)
{
                throw new Exception("Sai mật khẩu");
            }

            var token = _jwtService.GenerateJwtToken(
                user.Email,
                user.Role);

            return new LoginResponse
            {
                Message = "Đăng nhập thành công",
                Email = user.Email,
                Role = user.Role,
                Token = token
            };
        }
    }


}
