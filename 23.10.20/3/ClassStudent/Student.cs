using System;
using System.Collections.Generic;
using System.Text;

namespace ClassStudent
{
    //Придумать класс описывающий студента.Предусмотреть в нем след.моменты:
    //фамилия, имя, отчество, группа, возраст, массив(зубчатый) оценок по 
    //программированию, администрированию и дизайну. А так же добавить 
    //методы по работе с перечисленными данными: возможность установки/
    //получения оценки, получение среднего балла по заданному предмету,
    //распечатка данных о студенте.
    class Student
    {
        private string surname;
        private string name;
        private string patronymic;
        private int age;
        private string group;
        private int[][] estimates = new int[3][];
        private double sum;
        private double averageValue;

       public Student(string surname, string name, string patronymic, int age, string group)
       {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.age = age;
            this.group = group;
       }

        public void InitializeEstimates()
        {
            Random random = new Random();
            for(int i = 0; i < estimates.Length; i++)
            {
                estimates[i] = new int[random.Next(2, 10)];//рандомно получаемм кол-во оценок по предмету
            }
        }

        public void EstimateSetting()
        {
            Console.WriteLine("Choose the subject for setting the estimate:");

            Console.WriteLine("1 - programming, 2 - administration, 3 - design:");

            int choise = int.Parse(Console.ReadLine());

            switch(choise)
            {
                case 1:
                    Console.WriteLine("Programming estimate:");
                    for (int i = 0; i < estimates[0].Length; i++)
                    {
                        estimates[0][i] = int.Parse(Console.ReadLine());
                    }
                    break;
                case 2:
                    Console.WriteLine("Administration estimate:");
                    for (int i = 0; i < estimates[1].Length; i++)
                    {
                        estimates[1][i] = int.Parse(Console.ReadLine());
                    }
                    break;
                case 3:
                    Console.WriteLine("Design estimate:");
                    for (int i = 0; i < estimates[2].Length; i++)
                    {
                        estimates[2][i] = int.Parse(Console.ReadLine());
                    }
                    break;
            }
        }
        public void GettingEstimate()
        {
            Console.WriteLine("On what subject do you want to get the estimates?:");

            Console.WriteLine("1 - programming, 2 - administration, 3 - design:");

            int choise = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    Console.WriteLine("Programming estimate:");
                    for (int i = 0; i < estimates[0].Length; i++)
                    {
                        Console.Write(estimates[0][i] + "\t");
                    }
                    break;
                case 2:
                    Console.WriteLine("Administration estimate:");
                    for (int i = 0; i < estimates[1].Length; i++)
                    {
                        Console.Write(estimates[1][i] + "\t");
                    }
                    break;
                case 3:
                    Console.WriteLine("Design estimate:");
                    for (int i = 0; i < estimates[2].Length; i++)
                    {
                        Console.Write(estimates[2][i] + "\t");
                    }
                    break;
            }
            Console.WriteLine();
        }
        
        public void AverageScore()
        {
            Console.WriteLine("On what subject do you want to get the average score?:");

            Console.WriteLine("1 - programming, 2 - administration, 3 - design:");

            int choise = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    Console.Write("Average score in programming: ");
                    for (int i = 0; i < estimates[0].Length; i++)
                    {
                        sum += estimates[0][i];
                    }
                    averageValue = sum / estimates[0].Length;
                    break;
                case 2:
                    Console.Write("Average score in administration: ");
                    for (int i = 0; i < estimates[1].Length; i++)
                    {
                        sum += estimates[1][i];
                    }
                    averageValue = sum / estimates[1].Length;
                    break;
                case 3:
                    Console.Write("Average score in design: ");
                    for (int i = 0; i < estimates[2].Length; i++)
                    {
                        sum += estimates[2][i];
                    }
                    averageValue = sum / estimates[2].Length;
                    break;
            }
            Console.Write(averageValue);
            Console.WriteLine();
        }

        public void GetInfo()
        {
            Console.WriteLine("Surname - " + surname);

            Console.WriteLine("Name - " + name);

            Console.WriteLine("Patronymic - " + patronymic);

            Console.WriteLine("Age - " + age);

            Console.WriteLine("Group - " + group);

            Console.WriteLine("Academic perfomance:");

            Console.WriteLine("Programming:");
            for(int i = 0; i < estimates[0].Length; i++)
            {
                Console.Write(estimates[0][i] + "\t");
            }

            Console.WriteLine();

            Console.WriteLine("Administration:");
            for (int i = 0; i < estimates[1].Length; i++)
            {
                Console.Write(estimates[1][i] + "\t");
            }

            Console.WriteLine();

            Console.WriteLine("Design:");
            for (int i = 0; i < estimates[2].Length; i++)
            {
                Console.Write(estimates[2][i] + "\t");
            }
        }
    }
}
