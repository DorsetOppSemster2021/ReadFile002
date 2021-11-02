using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFile002
{
    public class FileDemo
    {

        public static void ReadDemo(string file = "jamaica.txt")
        {
            string path = "c:/users/outsi/downloads";



            string fileToRead = $"{path}/{file}";

            Console.WriteLine($"Reading File: {fileToRead}");

            try
            {
                using (StreamReader sr = new StreamReader(fileToRead))
                {

                    Console.WriteLine($"Starting to read {fileToRead}");

                    string line;

                    while ((line = sr.ReadLine()) is not null)
                    {

                        Console.WriteLine(line);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"The {fileToRead} file could not be read:");
                Console.WriteLine(e.Message);
            }

        }


        public static void WriteDemo(string file, string[] heroes)
        {

            string path = "c:/users/outsi/downloads";
           
            string fileToWrite = $"{path}/{file}";
       
            try
            {
                using (StreamWriter sw = new StreamWriter(fileToWrite))
                {
                    foreach (string hero in heroes)
                    {

                        sw.WriteLine(hero);
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"The {fileToWrite} file could not be written");
                Console.WriteLine(e.Message);

            }




        }


    }
}
