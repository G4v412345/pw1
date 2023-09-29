using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; 

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool again_1 = true;
            Console.WriteLine("1."); 
            while(again_1)
            {
                Console.Write("Login: ");
                string Login = Console.ReadLine();
                if(Login == "end")
                {
                    again_1 = false; 
                }
                else
                {
                    string pat = "[a-zA-Z][0-9]{1,9}";
                    string patfirststring = "[a-zA-Z]";
                    if (Regex.IsMatch(Login, pat) && Regex.IsMatch(Login[0].ToString(), patfirststring))
                    {
                        Console.Write("Логiн коректний\n");
                    }
                    else
                    {
                        Console.Write("Логiн не коректний\n");
                    }
                } 
            }
            bool again_2 = true;
            Console.WriteLine("2. (Забороненi слова: дляприкладу_1, дляприкладу_2)"); 
            while(again_2)
            {
                Console.Write("Напишiть текст:");
                string text = Console.ReadLine();
                if(text == "end")
                {
                    again_2 = false; 
                }
                else
                {
                    string[] banString = { "дляприкладу_1", "дляприкладу_2" };
                    string patterban = string.Join("|", banString.Select(Regex.Escape));
                    text = Regex.Replace(text, patterban, "банслово");
                    Console.WriteLine("Вiдредагований текст: " + text);  
                }

            }
        }
    }
}
