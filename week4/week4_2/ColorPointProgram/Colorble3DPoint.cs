using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorPointProgram
{
    class Colorble3DPoint : Point
    {
        private int z;
        private string color;

        public Colorble3DPoint(int x, int y, int z, string color) : base(x, y)
        {
            this.z = z;
            this.color = color;

        }

        public void SetZ(int z)
        {
            this.z = z;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public int GetZ()
        {
            return this.z;
        }

        public string GetColor()
        {
            return this.color;
        }

        public void MoveTo(int x, int y, int z)
        {
            MoveTo(x, y);
            this.z = z;
        }

        public void MoveBy(int x, int y, int z)
        {
            MoveBy(x, y);
            this.z = this.z + z;
        }
        public override string ToString()
        {
            return base.ToString() + ", z : " + this.z + ", color : " + this.color;
        }

    }
}
