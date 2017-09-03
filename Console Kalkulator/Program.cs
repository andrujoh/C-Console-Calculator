using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Kalkulator
{
  class Program
  {
    // Local variables
    static double firstNum;
    static double secNum;
    static double result;
    static void Main(string[] args)
    {
      Console.WriteLine("Konsoll Kalkulator");

      // Loop until user quits
      while (true)
      {
        Console.WriteLine("Velg først regnemetode. Etterpå velger du tallene du vil regne med.");
        Console.WriteLine("Menyvalg");
        Console.WriteLine("\n1: Addere\n2: Subtrahere\n3: Multiplisere\n4: Dividere\n5: Prosent\n6: Avslutt");
        var menuInput = Console.ReadLine();

        // Quit
        if (menuInput == "6")
        {
          Console.WriteLine("Ha det bra!");
          break;
        }

        // Handle Operations to show result based on menu choice
        try
        {
          int menuVal = int.Parse(menuInput);
          switch (menuVal)
          {
            case 1:
              GetNumbers();
              result = Operations.Add(firstNum, secNum);
              break;
            case 2:
              GetNumbers();
              result = Operations.Subtract(firstNum, secNum);
              break;
            case 3:
              GetNumbers();
              result = Operations.Multiply(firstNum, secNum);
              break;
            case 4:
              GetNumbers();
              result = Operations.Divide(firstNum, secNum);
              break;
            case 5:
              GetNumbers();
              result = Operations.Percent(firstNum, secNum);
              break;
            default:
              Console.WriteLine("\nVelg et tall mellom 1 og 6\n");
              continue;
          }

          // Show calculation result
          Console.WriteLine($"\n********** Resultatet er {result} **********\n");
        }

        // Handles users being derpy
        catch (FormatException)
        {
          Console.WriteLine("\nVelg en av regnemetodene i menyen.\n");
        }
      }
    }

    // Get the numbers to calculate
    static private void GetNumbers()
    {
      // Loop until both inputs are valid
      while (true)
      {
        try
        {
          Console.Write("Skriv inn det første tallet: ");
          firstNum = double.Parse(Console.ReadLine());
          Console.Write("Skriv inn det andre tallet: ");
          secNum = double.Parse(Console.ReadLine());
          break;
        }

        // Derpy user protection 
        catch (FormatException)
        {
          Console.WriteLine("Skriv inn et gyldig tall");
          continue;
        }
      }
    }
  }
}
