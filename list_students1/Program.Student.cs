namespace list_students1
{
    partial class Program
    {
        public class Student
        {
            public string LastName;
            public string FirstName;
            public int Age;

            public Student(string lastName, string firstName, int age)
            {
                LastName = lastName;
                FirstName = firstName;
                Age = age;
            }
        }

    }
}
