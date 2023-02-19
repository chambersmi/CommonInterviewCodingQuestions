using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI {
    internal class PrimeNumber {

        public static bool IsPrime(int num) {
            for(int i=2; i < num; i++) {
                if(num %i == 0) {
                    return false;
                }                 
            }
            return true;
        }

        public static void CheckIfPrime() {
            Console.Write("\nEnter a number to see if it is prime: ");
            int num = int.Parse(Console.ReadLine());
            if(IsPrime(num)) {
                Console.WriteLine($"{num} is a prime number!");
            } else {
                Console.WriteLine($"{num} is NOT a prime number.");
            }
        }
    }
}
