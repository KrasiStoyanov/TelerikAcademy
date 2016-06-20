namespace Structure
{
    using System;
    using System.Text;

    public class Point3D
    {
        private double x;
        private double y;
        private double z;
        private static readonly Point3D o;

        public Point3D()
        {

        }

        static Point3D()
        {
            o = new Point3D(0, 0, 0);
        }

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public static Point3D O
        {
            get
            {
                return o;
            }
        }

        public static Point3D Parse(string input)
        {
            StringBuilder coordinates = new StringBuilder();
            double[] xyz = new double[3];
            int xyzIndex = 0;

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

        public override string ToString()
        {
            return string.Format("x = {0}, y = {1}, z = {2}", this.X, this.Y, this.Z);
        }
    }
}
