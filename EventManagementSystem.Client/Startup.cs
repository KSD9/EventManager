using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagementSystem.DB;
using EventManagementSystem.Client;

namespace EventManagementSystem.Client
{
    class Startup
    {
        static void Main(string[] args)
        {
            EventManager options = new EventManager();
            Console.WriteLine("Welcome To The Event Management System");
            Console.WriteLine("Please Select an Action:");
            Console.WriteLine("1:Add New Event");
            Console.WriteLine("2:Update Existing Event");
            Console.WriteLine("3:Delete Event");
            Console.WriteLine("4:View All Events");
            Console.WriteLine("5:Exit");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    options.Insert();
                    Main(null);
                    break;
                case 2:
                    options.Select();
                    Console.WriteLine("Please enter the id of the event you wish to update.");
                    int idUpdate = int.Parse(Console.ReadLine());
                    options.Update(idUpdate);
                    Main(null);
                    break;
                case 3:
                    options.Select();
                    Console.WriteLine("Please enter the id of the event you wish to delete.");
                    int idDelete = int.Parse(Console.ReadLine());
                    options.Delete(idDelete);
                    Main(null);
                    break;
                case 4:
                    options.Select();
                    Main(null);
                    break;
                case 5:
                    Console.WriteLine("GoodBye!");
                    break;

                default:
                    Console.WriteLine("Please Select Valid Option !");
                    break;
            }
        }
    }
}


