using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI {
    internal class Palindrome {
        public string InputString { get; set; } = "";
        public string StringInReverse { get; set; } = "";

        public Palindrome() {
            GetString();
        }

        public void GetString() {
            Console.Write("Enter a string: ");
            InputString = Console.ReadLine();
            CheckForPalindrome();
        }

        public void CheckForPalindrome() {                  
            if (InputString != null) {
                for(int i = InputString.Length - 1; i >=0; i--) {
                    StringInReverse += InputString[i].ToString();
                }
                if(StringInReverse == InputString) {
                    Console.WriteLine($"MATCH!\n{InputString} and {StringInReverse} ARE a Palindrome!");
                } else {
                    Console.WriteLine($"{InputString} is not a Palindrome. Sorry!");
                }
            }
        }
    }
}
