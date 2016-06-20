namespace Structure
{
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> listOfPoints;

        public Path()
        {
            this.ListOfPoints = new List<Point3D>();
        }

        public List<Point3D> ListOfPoints
        {
            get
            {
                return this.listOfPoints;
            }
            set
            {
                this.listOfPoints = value;
            }
        }

        public void AddPoint(Point3D point)
        {
            this.listOfPoints.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.listOfPoints.Remove(point);
        }
    }
}
