using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task4
{
    class Task4
    {
        static string Hello (string line, string separator)
        {
            if (!String.IsNullOrWhiteSpace(line))
            {
                string[] token;
                token = line.Split(new string[] {separator}, StringSplitOptions.None);
                if (token.Length == 3)
                {
                    if (String.Compare(token[0], line) != 0)
                    {
                        return string.Format("Hello I’m {0}, I’m a {1}, and my phone number is {2}", token[0], token[1], token[2]);
                    }
                    else
                    {
                        return "Separator must be \",\"";
                    }        
                }
                else
                {
                    return "Line format must be 'NAME,SEX,PHONE'";
                } 
            }
            else
            {
                return "Incorrect line format. String is null, empty, or consists only of white-space characters.";
            }
        }

        static void Main(string[] args)
        {
            string res = Hello("Ana Kaneva,female,0885323554", ",");
            Console.WriteLine(res);
        }
    }
}
