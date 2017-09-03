using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Kalkulator
{
  public class Operations
  {
    public static double Add(double firstNum, double secNum)
    {
      return firstNum + secNum;
    }

    public static double Subtract(double firstNum, double secNum)
    {
      return firstNum - secNum;
    }

    public static double Multiply(double firstNum, double secNum)
    {
      return firstNum * secNum;
    }

    public static double Divide(double firstNum, double secNum)
    {
      // Handle divide by zero

      if (secNum == 0)
      {
        Console.WriteLine("\nIkke dele med null vet du!\n");
        return 0;
      }
      else
      {
        return firstNum / secNum;
      }

    }

    public static double Percent(double firstNum, double secNum)
    {
      return (secNum * firstNum) / 100;
    }
  }
}
