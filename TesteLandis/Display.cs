using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteLandis.Models;

namespace TesteLandis
{
    internal class Display
    {


        private MeterModel meter;
        public Endpoint endpoint = new Endpoint();

        public void InsertValues()
        {
            meter = new MeterModel();
            Console.WriteLine("Enter Endpoint Serial Number:");
            meter.SerialNumber = Console.ReadLine();
            Console.WriteLine("Enter Meter Model Id:");
            meter.Id = (MeterModel.Model) Enum.Parse(typeof(MeterModel.Model),Console.ReadLine());
            Console.WriteLine("Enter Meter Number:");
            meter.Number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Firmware Version:");
            meter.FirmwareVersion = Console.ReadLine();
            Console.WriteLine("Enter Switch State:");
            meter.SwitchState = (MeterModel.State)Enum.Parse(typeof(MeterModel.Model), Console.ReadLine());
         
            try
            {
                endpoint.Insert(meter);
                Console.WriteLine("Meter included!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Meter not included! Error: {e.Message}");
            }

            Console.ReadLine();
        }

        public void EditValues()
        {
            meter = new MeterModel();
            Console.WriteLine("Enter Endpoint Serial Number:");
            meter.SerialNumber = Console.ReadLine();
            Console.WriteLine("Enter Switch State:");
            meter.SwitchState = (MeterModel.State)Enum.Parse(typeof(MeterModel.Model), Console.ReadLine());
            try
            {
                endpoint.Edit(meter);
                Console.WriteLine("Meter edited!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Meter not edited! Error: {e.Message}");
            }
            Console.ReadLine();
        }

        public void DeleteValues()
        {
            meter = new MeterModel();
            Console.WriteLine("Enter Endpoint Serial Number:");
            meter.SerialNumber = Console.ReadLine();
            try
            {
                endpoint.Delete(meter);
                Console.WriteLine("Meter deleted!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Meter not deleted! Error: {e.Message}");
            }
            Console.ReadLine();
        }


        public void ShowAllEndpoints()
        {
            foreach (MeterModel meter in endpoint.ListAll())
            {
                PrintEndpoint(meter);
            }

            Console.WriteLine("All register were displayed!");
            Console.ReadLine();
        }

        public void FindEndpoint()
        {
            meter = new MeterModel();
            Console.WriteLine("Enter Endpoint Serial Number:");
            meter.SerialNumber = Console.ReadLine();
            try
            {
                PrintEndpoint((MeterModel)endpoint.Find(meter));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Meter not printed! Error: {e.Message}");
            }

            Console.ReadLine();
        }

        private void PrintEndpoint(MeterModel meter)
        {
            Console.WriteLine($"Endpoint Serial Number: {meter.SerialNumber}");
            Console.WriteLine($"Meter Model Id: {meter.Id}");
            Console.WriteLine($"Meter Number: {meter.Number}");
            Console.WriteLine($"Firmware Version: {meter.FirmwareVersion}");
            Console.WriteLine($"Switch State: {meter.SwitchState}");
            Console.WriteLine($"--------------------");

        }


    }

}
