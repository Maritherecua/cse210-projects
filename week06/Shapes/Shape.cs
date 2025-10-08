using System;

namespace Shapes
{
    public abstract class Shape
    {
        public string _color;

        public Shape(string color)
        {
            _color = color;
            GetColor();
        }
        public void SetColor(string color)
        {
            _color = color;
        }

        public string GetColor()
        {
            return _color;
        }

        public abstract double GetArea();
    }
}