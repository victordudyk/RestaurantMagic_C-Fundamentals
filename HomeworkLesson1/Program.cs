using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeworkLesson1
{
    class Program
    {

        static void Main(string[] args)
        {

            Lessons Lesson = new Lessons();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-----------------This is homework #1");
            Console.ResetColor();
            Lesson.Lessons1();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-----------------This is homework #2-3");
            Console.ResetColor();
            Lesson.Lessons3();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-----------------This is homework #4");
            Console.ResetColor();
            Lesson.Lesson4();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-----------------This is homework #5");
            Console.ResetColor();
            Lesson.Lesson5();

        }
      
    }
 
   
}
