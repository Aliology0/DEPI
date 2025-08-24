using System;

namespace Part_02.Interfaces
{
    public interface IShapeSeries
    {
        int CurrentShapeArea { get; set; }
        void GetNextArea();
        void ResetSeries();
    }

    public class SquareSeries : IShapeSeries
    {
        private int side = 0;

        public int CurrentShapeArea { get; set; }

        public void GetNextArea()
        {
            side++;
            CurrentShapeArea = side * side;
        }

        public void ResetSeries()
        {
            side = 0;
            CurrentShapeArea = 0;
        }
    }
    public class CircleSeries : IShapeSeries
    {
        private double radius = 0;

        public int CurrentShapeArea { get; set; }

        public void GetNextArea()
        {
            radius++;
            CurrentShapeArea = (int)(Math.PI * radius * radius);
        }

        public void ResetSeries()
        {
            radius = 0;
            CurrentShapeArea = 0;
        }
    }
}