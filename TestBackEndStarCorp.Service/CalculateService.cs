using TestBackEndStarCorp.Service.Calculate;

namespace TestBackEndStarCorp.Service
{
    public class CalculateService
    {
        public string  ChallengeCanculates(int number)
        {
            var result = "";
            var Tres = MultiploDeTres.CalcularMultiploDeTres(number);
            var Cinco = MultiploDeCinco.CalcularMultiploDeCinco(number);
            
            if (Tres && Cinco)
            {
                result = "StarCorpianos";
            }
            else if (Tres)
            {
                result = "StarCorp";
            }
            else if (Cinco)
            {
                result = "IT";
            }
            else
            {
                result = "Type Indefined";
            }

            return result;
        }
    }
}
