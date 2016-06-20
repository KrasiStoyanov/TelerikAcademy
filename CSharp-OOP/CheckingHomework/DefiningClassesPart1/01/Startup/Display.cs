using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{

    //Problem 1. Define class
    //Define 3 separate classes(class GSM holding instances of the classes Battery and Display).
    public class Display
    {
        private double? size;
        private int? displayColors;

        public Display()
        {
            this.Size = null;
            this.DisplayColors = null;
        }

        public Display(double? size, int? displayColors)
        {
            this.size = size;
            this.displayColors = displayColors;
        }
        
        //Problem 5. Properties
        //Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
        //Ensure all fields hold correct data at any given time.

        public double? Size
        {
            get
            {
                return this.size;
            }

            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Size canot be negative number!");
                }

                this.size = value;
            }
        }

        public int? DisplayColors
        {
            get
            {
                return this.displayColors;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Display Colors canot be negative number!");
                }
                    this.displayColors = value;
            }
        }

        //Problem 4. ToString
        //Add a method in the GSM class for displaying all information about it.
        //Try to override ToString().

        public override string ToString()
        {
            return string.Format("Display Size: {0}, Display Colors: {1}",
                this.size, this.displayColors);
        }
    }
}
