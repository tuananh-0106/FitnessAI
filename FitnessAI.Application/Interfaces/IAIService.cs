namespace FitnessAI.Application.Services
{
    public class AIService
    {
        public string SuggestDiet(double bmi, string MucTieu)
        {
            if (MucTieu == "CanNang Loss")
            {
                return "Eat low carb + cardio";
            }

            if (MucTieu == "Muscle Gain")
            {
                return "High protein + gym";
            }

            return "Balanced diet";
        }
    }
}