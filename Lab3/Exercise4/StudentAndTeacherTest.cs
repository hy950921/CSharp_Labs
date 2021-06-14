using System;

namespace Exercise4
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.Write("Person: ");
            person.Greeting();
            Console.WriteLine("");

            Person student = new Student();
            Console.Write("Student: ");
            student.SetAge(21);
            //student.GoToClasses();
            student.Greeting();
            Student _student = (Student)student;
            _student.ShowAge();
            Console.WriteLine("");

            Person teacher = new Teacher();
            Console.Write("Teacher: ");
            teacher.SetAge(30);
            teacher.Greeting();
            Teacher _teacher = (Teacher)teacher;
            _teacher.SetSubject("computer science");
            _teacher.Explain();

            Console.ReadKey();
        }
    }
}
