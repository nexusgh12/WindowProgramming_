using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicPoint
{
    class PointPublic<DataType>
    {
        private DataType x;
        private DataType y;


        public PointPublic(DataType x, DataType y)//생성자 부분
        {
            this.x = x;
            this.y = y;
            
        }

        public void SetX(DataType x)
        {
            this.x = x;
        }

        public void SetY(DataType y)
        {
            this.y = y;
        }

        public DataType GetX()
        {
            return x;
        }

        public DataType Gety()
        {
            return y;
        }

        public void MoveTo(DataType x, DataType y)
        {
            this.x = x;
            this.y = y;
        }

   /*
        public override string ToString()
        {
            return "X : " + this.x + ". y : " + this.y;
        }
    */
    }
}
