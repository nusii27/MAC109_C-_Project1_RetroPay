using System;

class Program {
  public static void Main (string[] args) {
    
    Console.WriteLine("Congratulations! You won an annual increase in pay as much as 7.6%. There is more! This pay raise is RETROACTIVE! (This increase will be applied to your past six months’ pay.)");
    Console.WriteLine("Now please tell me your last year’s annual salary: ");

    double oldSalary = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Based on your last years's annual salary of $"+oldSalary+",");  

    double retroPay = (oldSalary/2)*.076;
    double newAnnualSalary = oldSalary+retroPay*2;
    double newMonthlySalary = newAnnualSalary/12;

    Console.WriteLine("Your last 6 months retroactive pay is $"+retroPay);
    Console.WriteLine("Your new annual salary will be $"+newAnnualSalary);
    Console.WriteLine("And your monthly salary will be $"+newMonthlySalary);
    
  }
}