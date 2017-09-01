namespace HomeWorkDefiningClassesPart2
{
    using System;
    using System.Text;

    struct Point3D
    {
        //problem 2
        private static readonly Point3D startPoint0 = new Point3D(0, 0, 0);

        //problem 1
        private double x;
        private double y;
        private double z;

        #region Constructor

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        #endregion

        #region Properties
        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public double Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }

        //problem 2
        public static Point3D returnStartPoint
        {
            get
            {
                return startPoint0;
            }
        } 

        #endregion

        #region ToString

        public override string ToString()
        {
            return $"{this.X}, {this.Y}, {this.Z}";
        }
        #endregion

        #region Parse_Method
        //Method for parsing the 3dPoints from the saved txt file

        public static Point3D Parse(string input)
        {
            StringBuilder coordinates = new StringBuilder();
            double[] xyz = new double[3];
            int xyzIndex = 0;

            // input is the "nextPointTxt" from the txt file 

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]) || input[i] == '-')
                {
                    while (i < input.Length && (Char.IsDigit(input[i]) || input[i] == '-' || input[i] == '.'))
                    {
                        coordinates.Append(input[i]);
                        i++;
                    }
                }

                if (coordinates.Length > 0)
                {
                    double coord = double.Parse(coordinates.ToString());
                    xyz[xyzIndex] = coord;
                    xyzIndex++;
                    coordinates.Clear();
                }
            }

            return new Point3D(xyz[0], xyz[1], xyz[2]);
        }
        #endregion

    }

}
