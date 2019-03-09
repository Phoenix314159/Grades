using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75f);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine("this is the average grade: " + stats.AverageGrade);
            Console.WriteLine("this is the lowest grade: " + stats.LowestGrade);
            Console.WriteLine("this is the highest grade: " + stats.HighestGrade);

        }
    }
}
