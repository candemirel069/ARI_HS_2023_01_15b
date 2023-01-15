using System;

namespace App1
{
    class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        private Student(Guid id)
        {
            Id = id;
        }

        private static Student _Instance;

        public static Student GetInstance()
        {
            if (_Instance == null)
                _Instance = new Student(Guid.NewGuid());

            return _Instance;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = Student.GetInstance();
            Student student2 = Student.GetInstance();
            Console.WriteLine(student1.Id);
            Console.WriteLine(student2.Id);

        }
    }
}
