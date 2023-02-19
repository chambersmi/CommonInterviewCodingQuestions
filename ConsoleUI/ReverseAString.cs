using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI {
    internal class ReverseAString {
        public string InputString { get; set; } = "";
        public string StringInReverse { get; set; } = "";
        public int LengthOfString { get; set; } = 0;

        public ReverseAString() {
            GetString();
        }

        public void GetString() {
            Console.Write("Enter a string: ");
            InputString = Console.ReadLine();
            ReverseString(InputString);
        }

        public void ReverseString(string stringToReverse) {
            LengthOfString = stringToReverse.Length - 1;
            while(LengthOfString >= 0) {
                StringInReverse = StringInReverse + InputString[LengthOfString];
                LengthOfString--;
            }
            DisplayReverseString(StringInReverse);
        }

        public void DisplayReverseString(string stringInReverse) {
            Console.WriteLine($"Reverse word is: {StringInReverse}");
        }


    }
}
