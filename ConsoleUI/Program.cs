using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace ConsoleUI {
    internal class Program {

        static void Main(string[] args) {
            int choice = 0;

            do {
                Console.WriteLine("\nEnter an option:");
                Console.WriteLine("0) Exit");
                Console.WriteLine("1) Reverse a string");
                Console.WriteLine("2) Check for palindrome");
                Console.WriteLine("3) Substring");
                Console.WriteLine("4) Check for Prime Number");
                Console.WriteLine("-----------------------");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());
                // Leaving in bug that crashes if nothing is entered
                GetChoice(choice);
            } while (choice != 0);
        }

        public static void GetChoice(int num) {
            switch (num) {
                case 0:
                    Console.WriteLine("Quitting...");
                    break;
                case 1:
                    ReverseAString ras = new ReverseAString();
                    break;
                case 2:
                    Palindrome p = new Palindrome();
                    break;
                case 3:
                    Substring s = new Substring();
                    break;
                case 4:
                    PrimeNumber.CheckIfPrime();
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
