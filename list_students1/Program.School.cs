using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace list_students1
{
    partial class Program
    {
        public class School
        {
            public string Name;
            public List<Student> Students;

            public School()
            {
                Students = new List<Student>();
            }

            public void PrintStudents()
            {
                if (Students.Count == 0)
                {
                    WriteLine("Список учеников пока пуст");
                }
                else
                    WriteLine("{0, -10}|| {1,-10}|| {2,-10}||", "Фамилия", "Имя", "Возраст");
                {
                    foreach (var sdt in Students)
                    {
                        WriteLine("{0, -10}|| {1,-10}|| {2, -10}||", sdt.LastName, sdt.FirstName, sdt.Age);
                    }
                }
            }

            public void PrintSchool()
            {
                WriteLine($"Список школы {Name} успешно активирован!!!");
            }
            public void AddNewStudent()
            {
                Write("Введите фамилию студента : ");
                string lastName = ReadLine();
                char[] c = lastName.ToCharArray();
                c[0] = char.ToUpper(c[0]);
                lastName = string.Empty;
                foreach( var tmp in c)
                {
                    lastName += tmp;
                } 
                Write("введите имя студента : ");
                string firstName = ReadLine();
                c = firstName.ToCharArray();
                c[0] = char.ToUpper(c[0]);
                firstName = string.Empty;
                foreach(var tmp in c)
                {
                    firstName += tmp;
                }
                int age;
                while (true)
                {
                    Write("Введите возраст ученика : ");
                    try
                    {
                        age = int.Parse(ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        WriteLine("Не верно введен возраст");
                    }
                }
                var student = new Student(lastName, firstName, age);
                Students.Add(student);
                Write($"Ученик {student.LastName} {student.FirstName} {student.Age} лет успешно добавлен в список!!!");
            }

            public void DeleteFindStudent(bool flag) //method of double purpose. For seaching or delete dates.
            {
                string variant = flag == true ? "Введите данные ученика которого необходимо удалить : " : "Введите данные ученика, которого необходимо найти : ";
                Write(variant);
                
                string[] dateStudent = ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                string str = null;
                foreach(var s1 in dateStudent)
                {
                    str += s1;
                }
                str = str.ToLower();
                int count = 0; 
                for(int i = 0; i < Students.Count; i++)
                {
                    string[] s = { Students[i].LastName, Students[i].FirstName, Students[i].Age.ToString() };
                    string str1 = null;
                    foreach(var s2 in s)
                    {
                        str1 += s2;
                    }
                    str1 = str1.ToLower();
                    if (str1.Contains(str))
                    {
                        count++;
                        if (flag == true)
                        {
                            Write($"Удалить ученика {Students[i].LastName} {Students[i].FirstName} {Students[i].Age} из списка? Да или Нет :");
                            string answer = ReadLine();
                            answer = answer.ToLower();
                            if (answer == "да")
                            {
                                WriteLine($"Ученик {Students[i].LastName} {Students[i].FirstName} {Students[i].Age} успешно удален из списка");
                                Students.RemoveAt(i);
                            }
                        }
                        else if (flag == false)
                        {
                            WriteLine("{0, -10}|| {1,-10}|| {2, -10}||", Students[i].LastName, Students[i].FirstName, Students[i].Age);
                        }
                    }
                    else if (count == 0)
                    { WriteLine("В списке учеников данного ученика нет!"); break; }
                }
            }
        }
    }
}
