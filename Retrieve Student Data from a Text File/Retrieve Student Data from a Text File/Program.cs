using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Retrieve_Student_Data_from_a_Text_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                string filePath = "D:\\.net projects\\Practice Project-2/sample.txt";

                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);

                Console.WriteLine("Rainbow School Students Data:");

                 foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
