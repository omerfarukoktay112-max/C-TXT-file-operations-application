using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TXT_file_operations_application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "userText.txt";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("File Operations Application");
                Console.WriteLine("---------------------------");
                Console.WriteLine("1. Write to File");
                Console.WriteLine("2. Read from File");
                Console.WriteLine("3. Count Words in File");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option (1-4): ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                if (choice == "1")
                {
                    Console.Write("Enter text to write to file: ");
                    string userText = Console.ReadLine();

                    File.WriteAllText(filePath, userText);
                    Console.WriteLine("Text written to file successfully!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (choice == "2")
                {
                    if (File.Exists(filePath))
                    {
                        string content = File.ReadAllText(filePath);
                        Console.WriteLine("File Content:");
                        Console.WriteLine("--------------------");
                        Console.WriteLine(content);
                    }
                    else
                    {
                        Console.WriteLine("File does not exist. Please write something first.");
                    }
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
                else if (choice == "3")
                {
                    if (File.Exists(filePath))
                    {
                        string content = File.ReadAllText(filePath);
                        string[] words = content.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                        Console.WriteLine("Word count in file: " + words.Length);
                    }
                    else
                    {
                        Console.WriteLine("File does not exist. Please write something first.");
                    }
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option! Please try again.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }
    }
}