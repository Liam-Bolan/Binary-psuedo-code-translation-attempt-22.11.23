using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_psuedo_code_translation_attempt_22._11._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num1 = "";
            string num2 = "";

            do
            {
                Console.Write("Enter 1st 4 bit binary number: ");
                num1 = Console.ReadLine();
            }
            while (num1.Length < 4 & num1.Length > 4);
            
            do
            {
                Console.Write("Enter 2nd 4 bit binary number: ");
                num2 = Console.ReadLine();  
            }
            while (num2.Length < 4 & num2.Length > 4);

            int digit1 = 0;
            int digit2 = 0;
            int carry = 0;
            string answer = "";

            for (int i = 3; i >= 0;i--)
            {
                if (num1[i] == 1)
                {
                    digit1 = 1;
                }
                else
                {
                    digit1 = 0;
                }
                
                int result = digit1 + digit2 + carry;
                if(result > 1)
                {
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
                result = result%2;
                answer = result.ToString() + answer;
            }
            answer = carry.ToString() + answer;
            if (answer[0] == 1)
            {
                Console.WriteLine("OVERFLOW - OVERFLOW BIT IS 1");
            }
            else
            {
                Console.WriteLine($"Result is {answer}");
            }
            Console.ReadKey();

        }
    }
}
