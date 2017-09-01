namespace HomeWorkDefiningClassesPart2
{
    using System;

    //problem 2
    static class CalculateDistance
    {
        public static double Distance(Point3D pointOne, Point3D pointTwo)
        {
            double distance = 0;

            distance = Math.Sqrt((pointOne.X - pointTwo.X) * (pointOne.X - pointTwo.X) +
                     (pointOne.Y - pointTwo.Y) * (pointOne.Y - pointTwo.Y) +
                     (pointOne.Z - pointTwo.Z) * (pointOne.Z - pointTwo.Z));

            return distance;
        }
    }
}
