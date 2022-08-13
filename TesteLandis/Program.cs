using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TesteLandis
{
    class Program
    {
        static private Display _display;

        static void Main(string[] args)
        {
            _display = new Display();
            ShowOptions();
        }
        static private void ShowOptions()
        {
            Console.Clear();
            Console.WriteLine("Choose the option:");
            Console.WriteLine("1) Insert endpoint");
            Console.WriteLine("2) Edit endpoint");
            Console.WriteLine("3) Delete endpoint");
            Console.WriteLine("4) List all endpoints");
            Console.WriteLine("5) Find an endpoints");
            Console.WriteLine("6) Exit");
            var option = Console.ReadLine();
            CheckOptions(option);
        }

        static private void CheckOptions(string option)
        { 
            switch (option)
            {
                case "1" :
                    _display.InsertValues();
                    ShowOptions();
                    break;
                case "2":
                    _display.EditValues();
                    ShowOptions();
                    break;
                case "3":
                    _display.DeleteValues();
                    ShowOptions();
                    break;
                case "4":
                    _display.ShowAllEndpoints();
                    ShowOptions();
                    break;
                case "5":
                    _display.FindEndpoint();
                    ShowOptions();
                    break;
                case "6":
                    Console.WriteLine("Confirm? Type y/n!");
                    if (Console.ReadLine() != "y")
                       ShowOptions();
                    break;
                default:
                    Console.WriteLine("Invalid option! Type Enter!");
                    Console.ReadLine();
                    ShowOptions();
                    break;
            }
            
        }


    }
}
