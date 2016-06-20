using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Display
    {
        private int size;
        private string color;

        public Display()
        {

        }

        public Display(int size, string color)
        {
            this.Size = size;
            this.Color = color;
        }

        public int Size { get; set; }
        public string Color { get; set; }
    }
}
