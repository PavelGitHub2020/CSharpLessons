using System;

namespace ClassStudent
{
    //Придумать класс описывающий студента.Предусмотреть в нем след.моменты:
    //фамилия, имя, отчество, группа, возраст, массив(зубчатый) оценок по 
    //программированию, администрированию и дизайну. А так же добавить 
    //методы по работе с перечисленными данными: возможность установки/
    //получения оценки, получение среднего балла по заданному предмету,
    //распечатка данных о студенте.
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Kozlov", "Pavel", "Vladimirovich", 27, "P22019");
            student.InitializeEstimates();
            for(int i = 0; i < 3; i++)
            {
                student.EstimateSetting();
            }
            student.GettingEstimate();
            student.AverageScore();
            student.GetInfo();
        }
    }
}
