namespace TestBackEndStarCorp.Service.Calculate
{
    public static class MultiploDeTres
    {
        public static bool CalcularMultiploDeTres(int pNumber)
        {
            var retorno = false;
            if (pNumber % 3 == 0)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
