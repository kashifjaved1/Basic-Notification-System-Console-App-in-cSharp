using System;
using System.Text;

namespace NotificationSystem
{
    interface INotification
    {
        void message();
    }

    class Inquiry : INotification
    {
        public void message()
        {
            Console.WriteLine("Inquiry is done by user.");
        }
    }

    class Order : INotification
    {
        public void message()
        {
            Console.WriteLine("Order is placed by user.");
        }
    }

    class Sales : INotification
    {
        public void message()
        {
            Console.WriteLine("Sales is going awesome this year.");
        }
    }

    class Invoice : INotification
    {
        public void message()
        {
            Console.WriteLine("Invoice is generated.");
        }
    }

    class Shippment : INotification
    {
        public void message()
        {
            Console.WriteLine("Shippment is on the way.");
        }
    }

    class Program
    {
        private static Random random = new Random();

        static void menu()
        {
            Console.WriteLine("");
            Console.WriteLine("--------------------------- Menue -------------------------");
            Console.WriteLine("");
            Console.WriteLine("1. Inquire");
            Console.WriteLine("2. Order");
            Console.WriteLine("3. Sales");
            Console.WriteLine("4. Invoice");
            Console.WriteLine("5. Shippment");
            Console.WriteLine("6. Exit");
        }

        static int isValidChoice(int choice)
        {
            if (choice > 0 && choice < 7)
            {
                return choice;
            }
            else
            {
                return -1;
            }
        }

        static int userInput()
        {
            int input;
            Console.Write("Enter your Choice: ");

            try
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                throw new Exception("Illegal action.");
            }

            return input;
        }

        static void Main(string[] args)
        {
            Inquiry inq = new Inquiry();
            Invoice inv = new Invoice();
            Shippment ship = new Shippment();
            Sales sales = new Sales();
            Order order = new Order();

            int choice;
            
            do
            {
                menu();
                choice = userInput();
                isValidChoice(choice);

                if (choice == 1)
                {
                    Console.WriteLine("\nQueryId: {0}", random.Next());
                    inq.message();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\nQueryId: {0}", random.Next());
                    order.message();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("\nQueryId: {0}", random.Next());
                    sales.message();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("\nQueryId: {0}", random.Next());
                    inv.message();
                }
                else if (choice == 5)
                {
                    Console.WriteLine("\nQueryId: {0}", random.Next());
                    ship.message();
                }
                else if (choice == 6)
                {
                    choice = -1;
                    Console.WriteLine("");
                    Console.WriteLine("--------------------------- Exiting -------------------------");
                    Console.WriteLine("");
                }
                
            } while (isValidChoice(choice) != -1);
        }
    }
}