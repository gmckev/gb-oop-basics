﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_Task_1
{
    internal class Buildings
    {
        static void Main(string[] args)
        {
            Building building = new Building();
            Building building2 = new Building(5, 5, 20, 2);

            Console.WriteLine(building2.CalculateFlatsOnFloor());
            Console.ReadKey();
        }

        public class Building
        {
            private static int _id;
            private int _uniqueNumber;
            private float _height;
            private int _floors;
            private int _flats;
            private int _entrances;

            public int UniqueNumber { get => _uniqueNumber; }
            public float Height { get => _height; set => _height = value; }
            public int Floors { get => _floors; set => _floors = value; }
            public int Flats { get => _flats; set => _flats = value; }
            public int Entrances { get => _entrances; set => _entrances = value; }

            public Building()
            {
                _height = 2;
                _floors = 2;
                _flats = 3;
                _entrances = 2;
                IncreaseId();
            }

            public Building(float height, int floors, int flats, int entrances)
            {
                _height = height;
                _floors = floors;
                _flats = flats;
                _entrances = entrances;
                IncreaseId();
            }

            public int GetUniqueNumber()
            {
                return _uniqueNumber;
            }

            private void IncreaseId()
            {
                _id++;
                _uniqueNumber = _id;
            }

            public float CalculateBuildingHeight()
            {
                return _height / _floors;
            }

            public int CalculateFlatsInEntrance()
            {
                return _flats / _entrances;
            }

            public int CalculateFlatsOnFloor()
            {
                return CalculateFlatsInEntrance() / _floors;
            }
        }
    }
}
