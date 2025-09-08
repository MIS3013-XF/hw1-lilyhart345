// HW1b Grade

// Your Name:
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialize variables
            string firstName = "";
            string lastName = "";
            int studentIdNumber = 0;
            double homeworkGrade = 0;
            double participationGrade = 0;
            double quizGrade = 0;
            double midTermGrade = 0;
            double finalsGrade = 0; 
            double finalAverage = 0; 
            double percentage = .20;

            
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();
            Console.WriteLine("What is your student ID?");
            studentIdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("What is you overall percentage grade for homework?");
            homeworkGrade = double.Parse(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for participation?");
            participationGrade = double.Parse(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for quizzes?");
            quizGrade = double.Parse(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for your midterm?");
            midTermGrade = double.Parse(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for your final?");
            finalsGrade = double.Parse(Console.ReadLine());

            //calculate final grade
            finalAverage = (homeworkGrade + participationGrade + quizGrade + midTermGrade + finalsGrade) / 5.0;

            //display the final grade
            Console.WriteLine(firstName + "" + lastName + "(" + studentIdNumber + "),Your final average grade is " + finalAverage);
        }
    }
}
