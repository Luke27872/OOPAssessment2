using System;

namespace OOP_Assessment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //reads the text files
            string file_A = System.IO.File.ReadAllText("/Users/luke27872/Documents/UNI WORK/Object-Oriented Programming/Assessment 2/OOP_Assessment2/File_A.txt");
            string file_B = System.IO.File.ReadAllText("/Users/luke27872/Documents/UNI WORK/Object-Oriented Programming/Assessment 2/OOP_Assessment2/File_B.txt");

            int file_A_L = file_A.Length;
            int file_B_L = file_B.Length;
            int line_same = 0;

            Console.WriteLine("Press any key to see if files match:");
            Console.ReadLine();
            if (file_A_L == file_B_L)
            {
                for (int i = 0; i < file_A_L; i++) //Checks the lines one at a time
                {
                    if (file_A[i] == file_B[i])
                    {
                        line_same++; //Checks if all lines are the same
                    }
                }
                if (line_same == file_A_L) //If lines match outputs to user
                {
                    Console.WriteLine("The files match");
                }
                else
                {
                    Console.WriteLine("[The files do not match");
                }
            }
            else //If length does not match outputs to user
            {
                Console.WriteLine("The files do not match");
            }
        }
    }
}
