using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace task5
{
    class Task5
    {
        static string Hello(string line, string separator)
        {
            string result = "Hello I am %name%, I am a %sex%, and my phone number is %phone%.";

            string[] token;
            int startIndex = 0;
            int endIndex = 0;
            int i = 0;
            string tmp = "";

            token = line.Split(separator.ToCharArray(), StringSplitOptions.None);
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

        static void Write(string[] str, string fileName)
        {
            try
            {
                StreamWriter st = new StreamWriter(fileName);
                using (st)
                {
                    foreach (var item in str)
                    {
                        st.WriteLine(item);    
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("FileNotFound");
            }
            catch (IOException)
            {
                Console.WriteLine("IOException");
            }
        }

     

        static void Read(out string[] str, string fileName)
        {
            string[] line = new string[1000];
            int index = 0;

            try
            {
                StreamReader st = new StreamReader(fileName);
                using (st)
                {
                    while ((line[index] = st.ReadLine()) != null)
                    {
                        index++;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            str = new string[index];

            for (int i = 0; i < index; i++)
            {
                str[i] = Hello(line[i], ";");
            }
        }

        static void Main(string[] args)
        {
            string[] result;
            Read(out result, "in.csv");
            Write(result, "out.csv");
        }
    }
}
