namespace SolucaoSemInterface.Services
{
    class BrasilTaxService : ITaxService
    {
        public double Tax(double quantia)
        {
            if(quantia <= 100)
            {
                return quantia * 0.2;
            }
            else
            {
                return quantia * 0.15;

            }
        }
    }
}
