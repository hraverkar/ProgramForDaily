using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp72
{
  class SalaryCalculator
  {
    private readonly IList<BaseSalaryCalculator> _developerCalculation;

    public SalaryCalculator(IList<BaseSalaryCalculator> developerCalculation)
    {
      _developerCalculation = developerCalculation;
    }

    public double CalculateTotalSalary()
    {
      double totalsalary = 0;
      foreach (var devCalc in _developerCalculation)
      {
        totalsalary = totalsalary + devCalc.CalculateSalary();
      }

      return totalsalary;
    }

  }
}
