using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      //Calculate total cost of selected buildings surface area
      CalculateTotalCost();
      
    }

    //Calculate the area of a rectangle
    static double Rect(double length, double width){
      return length * width;
    }

    //Calculate the area of a circle
    static double Circle(double Radius){
      return Math.PI * (Math.Pow(Radius,2));
    }
    //Calculate the area of a triangle
    static double Triangle(double Bottom, double Height){
      return 0.5 * Bottom * Height;
    }

    /* Prompts user for building selection for existing building project estimates*/
    static void CalculateTotalCost(){
      string Choices = $"1. Teotihuacan{Environment.NewLine}2. Taj Mahal{Environment.NewLine}3. Mecca ";
      Console.WriteLine("Which Project do you need estimations for? Please type in the associated number (1,2,3)");

      Console.WriteLine(Choices);
      string Project = Console.ReadLine();
      double TotalArea;
      double TotalCost;

      switch(Project){
         //Teotihuacan
        case "1":
        Console.WriteLine("\nTeotihuacan estimation details");
        TotalArea = Math.Round(Rect(2500, 1500) + (Circle(375)/2) + Triangle(750, 500),2);
        break;

        
        //Taj Mahal 
        case "2":
        Console.Write("\nTaj Mahal  estimation details");
        TotalArea = Math.Round(Rect(90.5, 90.5) - 2 * Rect(24, 24),2);
        break;

        //Mecca 
        case "3":
        Console.WriteLine("\nMecca estimation details");
        TotalArea = Math.Round(Rect(180, 106) + Rect(200, 264) + Triangle(264, 84),2);
        break;

        default:
        TotalArea = 0;
        break;
      }
      string FloorPlan = TotalArea.ToString("N0");
      Console.WriteLine($"Floorplan Area: {FloorPlan} SQM");
      TotalCost = Math.Round((TotalArea * 8.60), 2);
      string Money = TotalCost.ToString("N0");
      Console.WriteLine($"Current Project estimate: ${Money} dollars\n");
    }
  }
}
