using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Project
{
    class Point : iMove
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //멤버 변수에 대한 접근 - 프로퍼티(대문자로 지정)
        public int X
        {
            get
            {
                return x; // int v = p.X : get블럭 호출
            }
            set
            {
                this.x = value; //p.X = 10 : set블럭 호출
            }
        }
        public int Y
        {
            get
            {
                return y; // int v = p.X : get블럭 호출
            }
            set
            {
                this.y = value; //p.X = 10 : set블럭 호출
            }
        }

        public override string ToString()
        {
            return "x : " + x + " y : " + y;
        }

        public void MoveTo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void MoveBy(int offX, int offY)
        {
            this.x += offX;
            this.y += offY;
        }

        public Point Add(Point pOther)
        {
            int x;
            int y;
            //Point pnew = new Point(0, 0);
            x = this.x + pOther.X;
            y = this.y + pOther.Y;
            Point pnew = new Point(x, y);

            return pnew;

        }

        public static Point operator+ (Point p1, Point p2)
        {
            //return new Point(p1.X + p2.X, p1.Y + p2.Y);
            int x;
            int y;
            x = p1.X + p2.X;
            y = p1.Y + p2.Y;
            Point pnew = new Point(x, y);
            return pnew;
        }

    }
}
