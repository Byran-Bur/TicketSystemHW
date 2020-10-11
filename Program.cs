using System;
using System.IO;

namespace TicketSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "ticket.txt";
            string choice;
            do
            {
                
                Console.WriteLine("1) Read data from file.");
                Console.WriteLine("2) Create file from data.");
                Console.WriteLine("Enter any other key to exit.");
                
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    
                    if (File.Exists(file))
                    {
                        
                        int gradePoints = 0;
                        int count = 0;
                        
                        StreamReader sr = new StreamReader(file);
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            
                            string[] arr = line.Split('|');
                            
                            Console.WriteLine("Name: {0}, Priority: {1}", arr[0], arr[1]);
                            
                            gradePoints += arr[1] == "A" ? 4 : arr[1] == "B" ? 3 : arr[1] == "C" ? 2 : arr[1] == "D" ? 1 : 0;
                            count += 1;
                        }
                        sr.Close();
                        
                        
                        Console.WriteLine("Ticket: {0:n2}", GPA);
                    }
                    else
                    {
                        Console.WriteLine("File does not exist");
                    }
                }
                else if (choice == "2")
                {
                    
                    StreamWriter sw = new StreamWriter(file);
                    for (int i = 0; i < 7; i++)
                    {
                        
                        Console.WriteLine("Enter a Priority (Y/N)?");
                        
                        string resp = Console.ReadLine().ToUpper();
                        
                        if (resp != "Y") { break; }
                       
                        Console.WriteLine("Enter the customer name.");
                    
                        string name = Console.ReadLine();
                     
                        Console.WriteLine("Enter the problem.");
                   
                        string grade = Console.ReadLine().ToUpper();
                        sw.WriteLine("{0}|{1}", name, grade);
                    }
                    sw.Close();
                }
            } while (choice == "1" || choice == "2");
        }
    }
}