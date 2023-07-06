using PartsInvoiceTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PartsInvoiceTracker.UserInterface
{
    internal class UserInterface
    {
        public static void MainMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Type 1 to add invoice.");
            Console.WriteLine("type 2 to view invoice database.");
            string? UserInput = Console.ReadLine();

            switch (UserInput)
            {
                case "1":
                    AddingInvoice();
                    break;
                case "2":
                    ViewingInvoice();
                    break;
                default:
                    MainMenu();
                    break;
            }
        }


        public static void AddingInvoice()
        {
            Console.WriteLine("Please fill out the following fields with invoice information");
            Console.WriteLine("Type Invoice number below");
            int InvoiceId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type in Employee number below");
            int EmployeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type in customer name below");
            string? CustomerName = Console.ReadLine();
            Console.WriteLine("Type Customer Phone number below");
            string? CustomerPhoneNumber = Console.ReadLine();
            Console.WriteLine("Type in a description of the part");
            string? PartDesc = Console.ReadLine();
            Console.WriteLine("Has the part been prepaid for?");
            bool Prepaid = Convert.ToBoolean(Console.ReadLine());
        }



        public static void ViewingInvoice()
        {
            Console.WriteLine("you are in the view invoice method");
        }
    }
}
