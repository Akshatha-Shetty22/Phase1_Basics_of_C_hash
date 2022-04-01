using System;
using System.IO;
namespace RetrieveStudentDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();
            path += @"\studentDetails.txt";
            bool f = true;
            while (f)
            {   //Asking the user to enter student id
                Console.WriteLine("Enter the Student's Id:");
                string id = Console.ReadLine();
                string[] lines = File.ReadAllLines(path);
                int i = 1;
                //Retreiving student details and displaying it on the screen
                foreach (string s in lines)
                {
                    string[] parts = s.Split(',');
                    if (parts[0] == id)
                    {
                        Console.WriteLine("Student Details:");
                        Console.WriteLine($"Student Id:{ parts[0]}");
                        Console.WriteLine($"Student Name:{parts[1]}");
                        Console.WriteLine($"Student Class:{parts[2]}");
                        Console.WriteLine($"Student Section:{parts[3]}");
                        Console.WriteLine("\n");
                        i = 0;
                        break;
                    }
                // Console.WriteLine(s);
                }
                if(i==1)
                {
                    Console.WriteLine("Student Details not found");
                }
                //Asking the user if he wants to continue
                Console.WriteLine("Do you want to continue?(yes/no)");
                string str = Console.ReadLine();
                str = str.ToLower();
                if (str == "yes")
                {
                    f = true;
                }
                else
                {
                    f = false;
                }

            }

        }
    }
}
