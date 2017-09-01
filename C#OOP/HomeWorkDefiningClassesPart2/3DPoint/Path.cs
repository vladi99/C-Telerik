namespace HomeWorkDefiningClassesPart2
{
    using System.Collections.Generic;

    class Path
    {
        private List<Point3D> pointList;

        #region Constructor
        public Path()
        {
            this.pointList = new List<Point3D>();
        }
        #endregion

        #region Properties
        public List<Point3D> PointList
        {
            get
            {
                return this.pointList;
            }
            set
            {
                this.pointList = value;
            }
        }
        #endregion

        #region Methods : Add and Remove point

        public void AddPoint(Point3D point)
        {
            this.pointList.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.pointList.Remove(point);
        }

        #endregion
    }
}
