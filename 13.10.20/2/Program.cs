using System;

namespace LessonTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Satellite q = new Satellite("Apolon", 900.5, true, true, "Goodbay");

            q.ControlMenu();//меню, по которому управляем спутником
        }
    }
}
