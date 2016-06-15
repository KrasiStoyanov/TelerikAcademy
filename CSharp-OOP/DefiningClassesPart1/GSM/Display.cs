namespace GSM
{
    public class Display
    {
        public Display(string manufacturer, string model)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
        }

        public Display(string manufacturer, string model, double size, string resolution) : 
            this(manufacturer, model)
        {
            this.Size = size;
            this.Resolution = resolution;
        }

        public string Manufacturer { get; private set; }

        public string Model { get; private set; }

        public string Resolution { get; private set; }

        public double Size { get; private set; }
    }
}
