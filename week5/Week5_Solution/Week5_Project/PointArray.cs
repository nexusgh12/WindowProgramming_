using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Project
{
    class PointArray
    {
        Point[] p = new Point[10];

        public Point this[int index]
        {
            get
            {
                return p[index];
            }
            set
            {
                p[index] = value;
            }
        }
        
        public Point getArray(int index)
        {
            return p[index];
        }

        public void setArray(Point p, int index)
        {
            this.p[index] = p;
        }


    }
}
