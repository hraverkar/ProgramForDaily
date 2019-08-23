using System;
using System.Collections.Generic;

namespace ConsoleApp72
{
  internal class Program
  {
    private static void Main()
    {
      var devCalculations = new List<BaseSalaryCalculator>
      {
        new SeniorDeveloperSalaryCalculator(new DeveloperReport
          {Id = 1, Name = "Harshal", Level = "Senior Developer", HourlyRate = 60, WorkHour = 50}),
        new JuniorDeveloperSalaryCalculator(new DeveloperReport
          {Id = 1, Name = "Harish", Level = "Junior Developer", HourlyRate = 60, WorkHour = 50}),
        new AssociateSalaryCalculator(new DeveloperReport
          {Id = 1, Name = "Harsh", Level = "Associate Developer", HourlyRate = 60, WorkHour = 50}),
        new SeniorDeveloperSalaryCalculator(new DeveloperReport
          {Id = 1, Name = "Harshit", Level = "Senior Developer", HourlyRate = 60, WorkHour = 50}),
      };

      var calculate = new SalaryCalculator(devCalculations);
      Console.WriteLine("All developer salary sum is "+ calculate.CalculateTotalSalary() + " Rs. ");
    }
  }
}
