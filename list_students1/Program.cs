using System;
using static System.Console;


namespace list_students1
{
    partial class Program
    {
        static void Main()
        {
            Write("\t\t\t\t---------------------СПИСОК УЧЕНИКОВ--------------------\n");
            Write("Введите название школы : ");
            var school = new School();
            school.Name = ReadLine();
            school.PrintSchool();
            var answer = new Answer();
            WriteLine("Для продолжения нажмите любую клвавишу!");
            ReadKey();

            while (true)
            {
                Console.Clear();
                int count = 0;
                Write("Хотите посмотреть меню действий?  Да или Нет : ");
                string answers = ReadLine();
                //answers = answers.ToLower();
                //if (answers
                count++;
                answer.Answers(answers);
            }
            
        }
    }
}
