namespace TestBackEndStarCorp.Service.Calculate
{
    public static class MultiploDeCinco
    {
        public static bool CalcularMultiploDeCinco(int pNumber)
        {
            var retorno = false;
            if (pNumber % 5 == 0)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
