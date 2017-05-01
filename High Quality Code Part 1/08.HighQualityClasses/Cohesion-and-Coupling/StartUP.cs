// <copyright file="StartUP.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>
// <summary>Holds implementation of static class Mathematics.</summary>

using System;

namespace CohesionAndCoupling
{
    /// <summary>
    /// Represent the program starting point.
    /// </summary>
    public class StartUP
    {
        /// <summary>
        /// Represent the first method called in the program live.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine(FileNameParser.GetFileExtension("example"));
            Console.WriteLine(FileNameParser.GetFileExtension("example.pdf"));
            Console.WriteLine(FileNameParser.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileNameParser.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileNameParser.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileNameParser.GetFileNameWithoutExtension("example.new.pdf"));

            Point2D firstPoint2D = new Point2D(1, -2);
            Point2D secondPoint2D = new Point2D(3, 4);
            Console.WriteLine("Distance in the 2D space = {0:f2}", Point2D.CalculateDistance2D(firstPoint2D, secondPoint2D));

            Point3D firstPoint3D = new Point3D(5, 2, -1);
            Point3D secondPoint3D = new Point3D(3, -6, 4);
            Console.WriteLine("Distance in the 3D space = {0:f2}", Point3D.CalculateDistance3D(firstPoint3D, secondPoint3D));

            Cuboid currentCuboid = new Cuboid(3, 4, 5);
            Console.WriteLine("Volume = {0:f2}", currentCuboid.CalculateVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", currentCuboid.CalculateSpaceDiagonal());
            Console.WriteLine("Diagonal XY = {0:f2}", currentCuboid.CalculateFaceDiagonal());
            Console.WriteLine("Diagonal XZ = {0:f2}", currentCuboid.CalculateTopDiagonal());
            Console.WriteLine("Diagonal YZ = {0:f2}", currentCuboid.CalculateSideDiagonal());
        }
    }
}
