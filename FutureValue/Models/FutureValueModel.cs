namespace FutureValue.Models
{
    public class FutureValueModel
    {
        public decimal MonthlyInvestment { get; set; }
        public decimal YearlyIntrestRate { get; set; }
        public int Years { get; set; }
        public decimal CalculateFutureValues()
        {
            int months = Years * 12;
            decimal monthlyIntrestRate = YearlyIntrestRate / 12 / 100;
            decimal futureValue = 0;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment) * (1 + monthlyIntrestRate);
            }
            return futureValue;
        }
    }
}
