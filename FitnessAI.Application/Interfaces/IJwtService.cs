namespace FitnessAI.Application.Interfaces
{
    public interface IJwtService
    {
        string GenerateJwtToken(string email, string role);
    }
}