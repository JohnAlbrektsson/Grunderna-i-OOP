using System;
using System.Collections.Generic;
using System.Text;

namespace CircleArea
{
    internal class Circle
    {
        float _pi = 3.141f;
        int _Radius;

        public Circle(int radius) //Constructor 
        {

            _Radius=radius;
        }

        public float getArea() //Method to get area
        {
            return _Radius * _Radius * _pi;

        }
        public float Omkrets() //Method to get circumference
        {
            return (_Radius + _Radius) * _pi;
        }
    }
}
