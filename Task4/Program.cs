using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--TASK1--");
            int a = 3;
            int b = 6;
            if ((a+b)%2==0) {
                Console.WriteLine("Cem cut ededdir");
            }
            else {
                Console.WriteLine("Cem tek ededdir");
            }



            Console.WriteLine("--TASK2--");
            int[] firstArray= { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] % 2 == 0)
                {
                    Console.WriteLine(firstArray[i]);
                }
            }



            Console.WriteLine("--TASK3--");
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] % 2 != 0)
                {
                    Console.WriteLine(firstArray[i]);
                }
            }



            Console.WriteLine("--TASK4--");
            string c = Console.ReadLine();
            int d = Convert.ToInt32(c);
            int summ = 0;
            if (d>=1000 && d < 10000)
            {
                while (d > 0) // d = 2345 234 23 2
                {
                    summ += d % 10; // 5+4  9+3  12+2  14
                    d /= 10;
                }
                Console.WriteLine(summ);

            }
            else
            {
                Console.WriteLine("eded 4 reqemli deyil");
            }



            Console.WriteLine("--TASK5--");
            Student st1= new Student();
            st1.name = "Gunay";
            st1.surname = "Xalilova";
            st1.age = 19;
            st1.speciality = "Proqrammer";
            st1.groupNo = "P419";

            Student st2 = new Student();
            st2.name = "Raul";
            st2.surname = "Alishov";
            st2.age = 19;
            st2.speciality = "Proqrammer";
            st2.groupNo = "P182R";

            Student[] students = { st1, st2 };
            for(int i = 0; i < students.Length; i++)
            {
                Console.Write(students[i].name +
                    " " + students[i].surname +
                    " " + students[i].age + 
                    " " + students[i].speciality +
                    " " + students[i].groupNo +"\n");
            } 
        }
    }
    class Student
    {
        public string name;
        public string surname;
        public int age;
        public string speciality;
        public string groupNo;
    }
}