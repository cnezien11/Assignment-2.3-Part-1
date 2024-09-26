using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Assignment_2._3_Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = (@"C:\Files\Nezien.txt");
            string name = "Belebie";
            int age = 25;
            string address = "55 Main st, Columbus, Georgia";

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Name: " + name);
                writer.WriteLine("Age: " + age);
                writer.WriteLine("Address: " + address);

            }

            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string details = reader.ReadToEnd();
                    Console.WriteLine("\nDetails read from files");
                    Console.WriteLine(details);
                }
            }
            else 
            {
                Console.WriteLine("405 File not found.");

            }
            Console.ReadLine();
        }
    }

}   
