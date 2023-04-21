using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBook.Logical
{
    internal class Swapping
    {
        public static void Start()
        {
            // Console.WriteLine("Please enter first word:");
            // string name1 = Console.ReadLine();
            // Console.WriteLine("Please enter second word:");
            //string name2 = Console.ReadLine();

            // Console.WriteLine($"Before SWapping first word was \"{name1}\", second word was \"{name2}\"");

            // // Step1: append 2nd string with the 1st string 
            // name1 = name1 + name2;
            // //Step2: store intial string name1 in string name2 
            // name2 = name1.Substring(0, name1.Length - name2.Length);
            // //Step3:  store initial string name2 in string name1 
            // name1 = name1.Substring(name2.Length);

            // Console.WriteLine($"After swapping first word is \"{name1}\", second word is \"{name2}\"");
            // Console.ReadKey();

            Console.WriteLine("Please enter first word:");
            string? name1 = Console.ReadLine();
            Console.WriteLine("Please enter second word:");
            string? name2 = Console.ReadLine();

            Console.WriteLine($"Before swapping first word was \"{name1}\", second word was \"{name2}\"");

            // Step1: append 2nd string with the 1st string 
            name1 += name2;

            // Step2: split the concatenated string into an array of chars and reverse the order
            var reversedChars = name1.ToCharArray().Reverse();

            // Step3: join the reversed chars to form the swapped strings
            name1 = string.Join("", reversedChars.Take(name2.Length).Reverse());
            name2 = string.Join("", reversedChars.Skip(name2.Length).Take(name1.Length).Reverse());

            Console.WriteLine($"After swapping first word is \"{name1}\", second word is \"{name2}\"");
        }
    }
}
