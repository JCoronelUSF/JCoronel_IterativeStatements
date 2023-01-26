using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace JCoronel_IterativeStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an intenger between 1 and 100: ");
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if (input > 0 && input <= 100)
                {
                    Console.WriteLine("Specify the series of intenger numbers (even or odd): ");
                    string strEven = "even";
                    string strOdd = "odd";
                    string series = Console.ReadLine();

                    if (series == strEven)
                    {
                        Console.WriteLine("You have selected the " +  series + " series. The numbers between 0 and " + input + " are: ");
                        for (int i = 1; i <= input; i++)
                        {
                            if (i % 2 == 0)
                            {
                                int even = i;
                                Console.WriteLine(even);
                            }
                        }
                    }
                    else if (series == strOdd)
                    {
                        Console.WriteLine("You have selected the " +  series + " series. The numbers between 0 and " + input + " are: ");
                        for (int i = 1; i <= input; i++)
                        {
                            if (i % 2 != 0)
                            {
                                int odd = i;
                                Console.WriteLine(odd);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid series. (even/odd)");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 100");
                }                   
            }
            catch
            {
                Console.WriteLine("Please enter a valid input");
            }
        }
    }
}