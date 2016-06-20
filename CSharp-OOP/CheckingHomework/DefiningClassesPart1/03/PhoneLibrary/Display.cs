using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    class Display
    {
        //Instance filed
        private double? size;
        private int? colorsNumber;

        public double? Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
            }
        }

        public int? ColorsNumber
        {
            get
            {
                return colorsNumber;
            }

            set
            {
                colorsNumber = value;
            }
        }

        //Constructor
        public Display() : this(null, null)
        {
        }

        public Display(int size) : this(size, null)
        {
        }

        public Display(double? size, int? colorNum)
        {
            this.Size = size;
            this.ColorsNumber = colorNum;
        }

        public override string ToString()
        {
            return $"\nDisplay info: {this.Size} inches \nColors: {this.ColorsNumber}M colors";
        }
    }
}