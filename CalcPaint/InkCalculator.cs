using System;

namespace InkCalculator
{
   class Calculator
    {
       private double wall_area;
       private double ceiling_area;

        public double CalculateWallArea(double height, double width, double depth)
        {
            wall_area = 2 * (width + depth) * height;
            return wall_area;
        }

        public double CalculateCeilingArea(double width, double depth)
        {
            ceiling_area = width * depth;
            return ceiling_area;
        }
        public double CalculateRequiredLiteracy()
        {
            return (wall_area + ceiling_area) / 10;
        }
    }
}




