using System;
using static System.Console;
namespace list_students1
{
    partial class Program
    {
        public class Answer
        {
            public void Answers(string answers)
            {
                var school = new School();
                answers = answers.ToLower();
                if (answers == "да")
                {
                    
                    while (true)
                    {
                        Console.Clear();
                        WriteLine("Выбирите пункт меню для дальнейших дейстивий : ");
                        Write("1 - смотреть список учеников\n2 - добавить учеников в список\n3 - удалить учеников из списка\n4 - найти ученика из списка\n5 -Выход из меню\n");
                       
                        int choose_variant;
                        while (true)
                        {
                            Write("Введите указатель действия, которое необходимо совершить : ");
                            try
                            {
                                choose_variant = int.Parse(ReadLine());
                                break;
                            }
                            catch (Exception)
                            {
                                WriteLine("Такой команды не существует попробуйте снова!");
                                
                            }
                        }
                        switch (choose_variant)
                        {
                            case 1:
                                school.PrintStudents();
                                WriteLine("Для очистки результата действий нажмите любую клавишу!");
                                ReadKey();
                                break;
                            case 2:
                                school.AddNewStudent();
                                WriteLine();
                                WriteLine("Для очистки результата действий нажмите любую клавишу!");
                                ReadKey();
                                break;
                            case 3:
                                bool flag = true;
                                school.DeleteFindStudent(flag);
                                WriteLine();
                                WriteLine("Для очистки результата действий нажмите любую клавишу!");
                                ReadKey();
                                break;
                            case 4:
                                flag = false;
                                school.DeleteFindStudent(flag);
                                WriteLine("Для очистки результата действий нажмите любую клавишу!");
                                ReadKey();
                                break;
                            case 5:
                                return;
       
                        }
                    }

                }
                else if(answers == "нет")
                {
                    Console.Clear();
                    Program.Main();
                }


            }
        }
    }
}
