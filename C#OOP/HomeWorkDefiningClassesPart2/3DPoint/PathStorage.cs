namespace HomeWorkDefiningClassesPart2
{
    using System.IO;

    static class PathStorage
    {
        #region SavePath
        public static void SavePath(Path path, string pathName)
        {
            using (StreamWriter sw = new StreamWriter("..//..//path" + pathName + ".txt"))
            {
                for (int i = 0; i < path.PointList.Count; i++)
                {
                    sw.WriteLine(path.PointList[i]);
                }
            }
        }
        #endregion
        #region LoadPath
        public static Path LoadPath(string filePath)
        {
            Path path = new Path();

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.EndOfStream == false)
                {
                    string nextPointTxt = sr.ReadLine();
                    Point3D nextPoint = Point3D.Parse(nextPointTxt);
                    path.AddPoint(nextPoint);
                }
            }
            return path;
        }
        #endregion

    }
}
