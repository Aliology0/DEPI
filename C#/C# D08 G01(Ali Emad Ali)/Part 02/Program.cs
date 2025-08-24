using System;
using Part_02.Interfaces;

namespace Part_02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Create a Shape Series
            // Console.WriteLine("=== Square Series ===");
            // PrintTenShapes(new SquareSeries());

            // Console.WriteLine("\n=== Circle Series ===");
            // PrintTenShapes(new CircleSeries());
            #endregion

            #region Implement Sorting for Shapes

            // Shape square = new Shape("Square", 25.0);
            // Shape circle = new Shape("Circle", 78.5);
            // Shape rectangle = new Shape("Rectangle", 40.0);
            // Shape triangle = new Shape("Triangle", 15.0);
            // Shape ellipse = new Shape("Ellipse", 60.0);

            // Shape[] shapes = { square, circle, rectangle, triangle, ellipse };

            // Console.WriteLine("Before Sorting:");
            // foreach (var shape in shapes)
            // {
            //     Console.WriteLine(shape);
            // }

            // Array.Sort(shapes); // (Uses CompareTo)

            // Console.WriteLine("\nAfter Sorting (Ascending by Area):");
            // foreach (var shape in shapes)
            // {
            //     Console.WriteLine(shape);
            // }
            #endregion

            #region Extend the Shape Hierarchy
            // GeometricShape[] shapes = new GeometricShape[]
            // {
            // new Triangle(3, 4),
            // new Rectangle(5, 10),
            // new Circle(10),
            // new Triangle(7, 2)
            // };

            // foreach (var shape in shapes)
            // {
            //     Console.WriteLine(shape);
            // }
            #endregion

            #region Implement Your Own Sorting
            // Shape square = new Shape("Square", 25.0);
            // Shape circle = new Shape("Circle", 78.5);
            // Shape rectangle = new Shape("Rectangle", 40.0);
            // Shape triangle = new Shape("Triangle", 15.0);
            // Shape ellipse = new Shape("Ellipse", 60.0);

            // Shape[] shapes = { square, circle, rectangle, triangle, ellipse };

            // Console.WriteLine("Before Sorting:");
            // foreach (var shape in shapes)
            // {
            //     Console.WriteLine(shape);
            // }

            // InsertionSort(shapes);

            // Console.WriteLine("\nAfter Sorting (Ascending by Area):");
            // foreach (var shape in shapes)
            // {
            //     Console.WriteLine(shape);
            // }
            #endregion

            #region Implement Factory Pattern (Bonus)
            // GeometricShape shape1 = ShapeFactory.CreateShape("triangle", 3, 4);
            // GeometricShape shape2 = ShapeFactory.CreateShape("rectangle", 5, 10);

            // Console.WriteLine("Shapes:\n");
            // Console.WriteLine(shape1);
            // Console.WriteLine(shape2);
            #endregion
        }

        public static void PrintTenShapes(IShapeSeries series)
        {
            series.ResetSeries();
            for (int i = 0; i < 10; i++)
            {
                series.GetNextArea();
                Console.WriteLine($"Shape {i + 1} Area: {series.CurrentShapeArea}");
            }
        }

        // Insertion Sort
        public static void InsertionSort(Shape[] shapes)
        {
            for (int i = 1; i < shapes.Length; i++)
            {
                Shape key = shapes[i];
                int j = i - 1;

                while (j >= 0 && shapes[j].Area > key.Area)
                {
                    shapes[j + 1] = shapes[j];
                    j--;
                }
                shapes[j + 1] = key;
            }
        }
    }
}

