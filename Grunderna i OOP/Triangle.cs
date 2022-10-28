using System;
using System.Collections.Generic;
using System.Text;

namespace CircleArea
{
    internal class Triangle
    {
        int _Base;
        int _Height;

        int _A;
        int _B;


        public Triangle(int Base, int height, int a, int b) //constructor
        {
            _Base = Base;
            _Height = height;
            _A=a;
            _B=b;

        }
        public int getArea() //Method to get area
        {
            return (_Base * _Height) /2;

        }
        public int Omkrets() //Method to ger circumference
        {
            return _A + _B + _Base;
        }
    }
}
