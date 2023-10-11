using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Calcu
{
    class Program
    {
        static void UserLogin()
        {
            string username = "admin";
            string password = "password";
            string user = "";
            string pass = "";
            int attempts = 3;

            do
            {
                Console.WriteLine("\n\n     LOGIN\n\n");
                Console.Write("          Enter username: ");
                user = Console.ReadLine();
                Console.Write("\n          Enter password: ");
                pass = Console.ReadLine();
                Console.WriteLine("\n");

                if (user == username && pass == password)
                {
                    Console.WriteLine("     Login successful! Press any key to use the calculator...");
                    Console.ReadKey();
                    Console.Clear();
                    Calculation();
                }
                else
                {
                    Console.WriteLine("     Login failed. Press any key to try again.");
                    Console.WriteLine("\n     Attempts remaining: " + (attempts - 1));
                    Console.WriteLine("\n");
                    attempts--;
                    Console.ReadKey();
                    Console.Clear();

                    if (attempts == 0)
                    {
                        LoginFailed();
                    }
                }
            }
            while (user != username || pass != password);
        }

        static void LoginFailed()
        {
            Console.WriteLine("\n\n     Login failed. You have used all your attempts.\n\n");
            Console.Write("     Do you want to try again? [ Y / N ]: ");
            string opt = Console.ReadLine();

            if (opt == "y" || opt == "Y")
            {
                Console.Clear();
                UserLogin();
            }
            else if (opt == "n" || opt == "N")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\n     Invalid input. Try again");
                Console.ReadKey();
                Console.Clear();
                LoginFailed();
            }
        }

        static void Calculation()
        {
            double num1;
            double num2;
            double result;
            string opt;

            try
            {
                Console.WriteLine("\n\n     CALCULATOR\n\n");
                Console.Write("          Enter first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n          Enter second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n\n     Choose an operation to perform:\n");
                Console.WriteLine("          Press [1] for Addition");
                Console.WriteLine("          Press [2] for Subtraction");
                Console.WriteLine("          Press [3] for Multiplication");
                Console.WriteLine("          Press [4] for Division");
                Console.WriteLine("          Press [5] to perform all operation");
                Console.WriteLine("          Press [6] to exit");
                Console.Write("\n          Select an option: ");
                opt = Console.ReadLine();
                Console.WriteLine("\n");

                if (opt == "1")
                {
                    result = num1 + num2;
                    Console.WriteLine("     Addition:        " + num1 + " + " + num2 + " = " + result);
                    Console.ReadKey();
                    Console.Clear();
                    CalcuMenu();
                }
                else if (opt == "2")
                {
                    result = num1 - num2;
                    Console.WriteLine("     Subtraction:     " + num1 + " - " + num2 + " = " + result);
                    Console.ReadKey();
                    Console.Clear();
                    CalcuMenu();
                }
                else if (opt == "3")
                {
                    result = num1 * num2;
                    Console.WriteLine("     Multiplication:     " + num1 + " x " + num2 + " = " + result);
                    Console.ReadKey();
                    Console.Clear();
                    CalcuMenu();
                }
                else if (opt == "4")
                {
                    result = num1 / num2;
                    if (num2 == 0)
                    {
                        Console.WriteLine("     Division:     Cannot be divided by zero.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("     Division:     " + num1 + " / " + num2 + " = " + result);
                        Console.ReadKey();
                        Console.Clear();
                    }
                    CalcuMenu();
                }
                else if (opt == "5")
                {
                    result = num1 + num2;
                    Console.WriteLine("     Addition:           " + num1 + " + " + num2 + " = " + result);
                    result = num1 - num2;
                    Console.WriteLine("     Subtraction:        " + num1 + " - " + num2 + " = " + result);
                    result = num1 * num2;
                    Console.WriteLine("     Multiplication:     " + num1 + " x " + num2 + " = " + result);
                    result = num1 / num2;
                    if (num2 == 0)
                    {
                        Console.WriteLine("     Division:           Cannot be divided by zero.");
                    }
                    else
                    {
                        Console.WriteLine("     Division:           " + num1 + " / " + num2 + " = " + result);
                    }
                    Console.ReadKey();
                    Console.Clear();
                    CalcuMenu();
                }
                else if (opt == "6")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("     Invalid input! Press any key to try again...");
                    Console.ReadKey();
                    Console.Clear();
                    Calculation();
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("\n\n     An error occured: " + e.Message);
                Console.WriteLine("\n     Press any key to try again...");
                Console.ReadKey();
                Console.Clear();
                Calculation();
            }
        }

        static void CalcuMenu()
        {
            string opt = "";

            Console.WriteLine("\n\n     Choose an acton to perform:");
            Console.WriteLine("\n\n          Press [1] to continue using calculator");
            Console.WriteLine("          Press [2] to logout");
            Console.WriteLine("          Press [3] to exit");
            Console.Write("\n          Select an option: ");
            opt = Console.ReadLine();
            Console.WriteLine("\n");
            Console.Clear();

            if (opt == "1")
            {
                Calculation();
            }
            else if (opt == "2")
            {
                Console.WriteLine("\n\n     Logged out successfully! Press any key to return to login page...");
                Console.ReadKey();
                Console.Clear();
                UserLogin();
            }
            else if (opt == "3")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\n\n     Invalid input! Press any key to try again...");
                Console.ReadKey();
                Console.Clear();
                CalcuMenu();
            }

        }

        static void Main(string[] args)
        {
            UserLogin();
        }
    }
}
