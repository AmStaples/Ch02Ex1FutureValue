﻿using System.ComponentModel.DataAnnotations;


namespace FutureValue.Models
{
    public class FutureValueModel
    {
        [Required(ErrorMessage = "Please enter a monthly investment.")]
        [Range(1, 500, ErrorMessage = "Monthly Investment amount must be between 1 and 500.")]
        public decimal? MonthlyInvestment { get; set; }
        [Required(ErrorMessage ="Please enter a yearly intrest rate.")]
        [Range(0.1, 10.0, ErrorMessage = "Yearly interest rate must be between 0.1 and 10.0")]
        public decimal? YearlyIntrestRate { get; set; }
        [Required(ErrorMessage = "Please enter a number of years.")]
        [Range(1,50, ErrorMessage = "Number of years must be between 1 and 50.")]
        public int? Years { get; set; }
        public decimal? CalculateFutureValues()
        {
            int? months = Years * 12;
            decimal? monthlyIntrestRate = YearlyIntrestRate / 12 / 100;
            decimal? futureValue = 0;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment) * (1 + monthlyIntrestRate);
            }
            return futureValue;
        }
    }
}
