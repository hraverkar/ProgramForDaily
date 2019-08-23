using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp72
{
  internal abstract class  BaseSalaryCalculator
  {
    protected DeveloperReport DeveloperReport { get; }

    protected BaseSalaryCalculator(DeveloperReport developerReport)
    {
      DeveloperReport = developerReport;
    }

    public abstract double CalculateSalary();
  }

  internal class SeniorDeveloperSalaryCalculator : BaseSalaryCalculator
  {
    public SeniorDeveloperSalaryCalculator(DeveloperReport report) : base(report)
    {

    }

    public override double CalculateSalary()
    {
     return DeveloperReport.HourlyRate * DeveloperReport.WorkHour * 1.2;
    }
  }

  internal class JuniorDeveloperSalaryCalculator : BaseSalaryCalculator
  {
    public JuniorDeveloperSalaryCalculator(DeveloperReport developerReport):base(developerReport)
    {
      
    }
    public override double CalculateSalary()
    {
      return DeveloperReport.HourlyRate * DeveloperReport.WorkHour;
    }
  }

  internal class AssociateSalaryCalculator : BaseSalaryCalculator
  {
    public AssociateSalaryCalculator(DeveloperReport developerReport):base(developerReport)
    {
    }
    public override double CalculateSalary()
    {
      return DeveloperReport.HourlyRate * DeveloperReport.WorkHour * 1.5;
    }
  }
}
