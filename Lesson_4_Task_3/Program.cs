using MyLibrary;
using System;

namespace Lesson_4_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var building = Creator.CreateBuilding();
            Console.WriteLine(building.UniqueNumber);
        }
    }
}
