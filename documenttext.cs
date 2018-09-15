using System;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Document");
                Console.WriteLine();
                string line;
                Console.WriteLine("Enter name of document:");
                line = Console.ReadLine();
                string content;
                Console.WriteLine("Enter content of the document:");
                content = Console.ReadLine();
                string file;
                file = line + ".txt";
                string directory;
                directory = Environment.CurrentDirectory + "/" + file;
                Console.WriteLine(file + " was successfully saved. The document contains " + content.Length + " characters");
            }
                    catch (Exception e)
            {
                Console.WriteLine(e);

            }
        }


        }

    
        }

