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
            if (!String.IsNullOrWhiteSpace(line))
            {
                string[] token;
                token = line.Split(separator.ToCharArray(), StringSplitOptions.None);
                if (token.Length == 3)
                {
                    if (String.Compare(";", separator) == 0)
                    {
                        return string.Format("Hello I am {0}, I am a {1}, and my phone number is {2}", token[0], token[1], token[2]);
                    }
                    else
                    {
                        throw new System.ArgumentException("Separator must be \";\"");
                    }
                }
                else
                {
                    throw new System.ArgumentException("Line format must be 'NAME;SEX;PHONE'");
                }
            }
            else
            {
                throw new System.ArgumentException("Line cannot be null, empty, or white-space");
            }
        }
     
        static void Read(string inputFile, string outputFile)
        {
            try
            {
                StreamReader reader = new StreamReader(inputFile);
                StreamWriter writer = new StreamWriter(outputFile);

                using (writer)
                {
                    using (reader)
                    {
                        string line = "";
                        while ((line = reader.ReadLine()) != null)
                        {
                            writer.WriteLine(Hello(line, ";"));    
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Please, frst create the file {0}", inputFile);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        static void Main(string[] args)
        {
            Read("in.csv", "out.csv");
        }
    }
}
