using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI {
    internal class Substring {
        public string Text { get; set; } = "\nLorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.";
        public Substring() {
            Console.WriteLine(Text);
            Console.WriteLine("\nEnter a number for substring: ");
            int substringCount = int.Parse(Console.ReadLine());
            GetSubstring(substringCount);
        }

        public void GetSubstring(int count) {
            string subString = Text.Substring(0, count);
            Console.Write($"Substring is: {subString}");
        }
    }
}
