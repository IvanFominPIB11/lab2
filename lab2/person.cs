using System;
using System.Collections.Generic;
namespace Labor2
{
    class Program
    {
        enum Education
        {
            Specialist,
            Bachelor,
            SecondEducational
        }
        public void Main()
        {
            Person a1 = new Person();
            a1.Name = "Иван";
            a1.Secondname = "Фомин";
            a1.Birthday = DateTime.Parse("01.07.1999");
            Exam b1 = new Exam();
            b1.dicipline = "Программирование";
            b1.score = 4;
            b1.ExamDate = DateTime.Parse("03.10.2022.15:40");
            Student c1 = new Student();
            c1.Info = a1;
            c1.Form = Education.Specialist;
            c1.Group = 11;
            Console.WriteLine(a1.ToFullString());
            Console.WriteLine(b1.ToFullString());
            Console.WriteLine(c1.ToFullString());

        }
    }
}
