using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* The Universities of Technology software department has approached your
programming company and requested that you develop a mark calculating program.*/
namespace labTestProgram
{
    internal class Program
    {
        //Global variables
        static string name, studentNumber, result;
        static int mark1, mark2, mark3, mark4, menuNo;
        static double finalMarkResult;
        static void Main()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("      MARK CHECK SYSTEM - MAIN MENU");
            Console.WriteLine();
            Console.WriteLine("1. Enter Student Details + Marks");
            Console.WriteLine("2. Mark Report + Indicating pass or distinction");
            Console.WriteLine("3. Exit Program");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Please enter menu number 1, 2 or 3...");
            menuNo = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            //Switch statement for different menus
            switch(menuNo)
            {
                case 1:
                    EnterData();
                    break;
                case 2:
                    MarksReport();
                    break;
                case 3:
                    ExitProgram();
                    break;
                default:
                    Console.WriteLine("You've entered the incorrect number, exit the program with a key press");
                    break;
            }
        }

        static void EnterData()
        {
            //Start menu and user enquiry 
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("      MARK CHECK SYSTEM - Student Details and Marks");
            Console.WriteLine();
            Console.WriteLine("Marks weight is T1 = 20%, T2 = 20%, T3 = 20%, T4 = 40%");
            Console.WriteLine();
            Console.WriteLine("Please enter the Student Name:");
            name = Console.ReadLine(); //User input
            Console.WriteLine();
            Console.WriteLine("Please enter the Student Number:");
            studentNumber = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("The program will now accept 4 marks");
            Console.WriteLine("Please enter a value between 0 and 100 for each mark");
            Console.WriteLine();
            Console.WriteLine("Please enter Mark 1:");
            mark1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please enter Mark 2:");
            mark2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please enter Mark 3:");
            mark3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please enter Mark 4:");
            mark4 = Convert.ToInt16(Console.ReadLine());
            Calculate();
            Console.WriteLine();
            Console.WriteLine("All marks have been captured!");
            Console.WriteLine();
            Console.WriteLine("Press any key to return to Main Menu");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
        static void Calculate()
        {
            finalMarkResult = (mark1/5) + (mark2/5) + (mark3/5) + (mark4/2.5);
            //If statement to check students results if they failed or not
            if(finalMarkResult < 50)
            {
                result = "failed";
            }
            else if(finalMarkResult >= 50)
            {
                result = "passed";
            }
        }
        static void MarksReport()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("         MARK CHECK SYSTEM - Marks Report");
            Console.WriteLine();
            Console.WriteLine("Student Name:    {0}", name);
            Console.WriteLine("Student Number:  {0}", studentNumber);
            Console.WriteLine();
            Console.WriteLine("Mark 1 Result:       {0}%", mark1);
            Console.WriteLine("Mark 2 Result:       {0}%", mark2);
            Console.WriteLine("Mark 3 Result:       {0}%", mark3);
            Console.WriteLine("Mark 4 Result:       {0}%", mark4);
            Console.WriteLine();
            Console.WriteLine("FINAL MARK RESULT:   {0}%", finalMarkResult);
            Console.WriteLine();
            Console.WriteLine("The Student has {0} the subject", result);
            Console.WriteLine();
            Console.WriteLine("Press any key to return to Main Menu");
            Console.ReadKey();
            Console.Clear();
            Main();
        }

        static void ExitProgram()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("         MARK CHECK SYSTEM - EXIT PROGRAM");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program.");
            Console.ReadKey();
        }
    }
}
