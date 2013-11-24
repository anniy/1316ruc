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
            string result = "Hello I’m %name%, I’m a %sex%, and my phone number is %phone%";
            
            string[] token;
            int startIndex = 0;
            int endIndex = 0;
            int i = 0;
            string tmp = "";
            
            token = line.Split(new string[] {separator}, StringSplitOptions.None);
            if (String.Compare(token[0], line) != 0)
            {
                while ((startIndex != -1) && (i < token.Length))
                {
                    startIndex = result.IndexOf('%');
                    endIndex = result.IndexOf('%', startIndex + 1);
                    if (endIndex == -1)
                    {
                        break;
                    }
                    tmp = result.Substring(startIndex, endIndex - startIndex + 1);
                    result = result.Replace(tmp, token[i]);
                    i++;
                }
                return result;
            }
            else
            {
                return "ERROR";
            }
        }

        static void Main(string[] args)
        {
            string res = Hello("Ana Kaneva,female,0885323554", ",");
            Console.WriteLine(res);
        }
    }
}
