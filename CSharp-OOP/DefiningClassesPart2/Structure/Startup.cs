namespace Structure
{
    using System;

    public class Startup
    {
        static void Main()
        {
            Console.WriteLine(new string('-', 50));

            Path test = new Path();
            Point3D point1 = new Point3D(1.5, 2.5, 3.5);
            Point3D point2 = new Point3D(-1, 2, 7);
            Point3D point3 = new Point3D(4, 2, 3);
            Point3D point4 = new Point3D(-5, -4, 3);
            Point3D point5 = new Point3D(1.25, 2.375, 3);

            test.AddPoint(point1);
            test.AddPoint(point2);
            test.AddPoint(point3);
            test.AddPoint(point4);
            test.AddPoint(point5);

            PathStorage.SavePath(test, "sample");

            Path loadedPath = PathStorage.LoadPath(@"../../pointsample.txt");

            Console.WriteLine("The points from the text file are: ");
            for (int i = 0; i < loadedPath.ListOfPoints.Count; i++)
            {
                Console.WriteLine("Point {0}: {1}", i + 1, loadedPath.ListOfPoints[i].ToString());
            }
        }
    }
}
