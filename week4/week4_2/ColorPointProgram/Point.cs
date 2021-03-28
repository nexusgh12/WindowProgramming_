using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorPointProgram
{
    class Point
    {
        /*
        *멤버변수
        *생성자
        *접근자, 수정자get set메서드
        *연산자
        *재정의
        *델리게이트
        *각종 메서드
        *tostring
         */
        private int x;
        private int y;

        public Point(int x, int y)//생성자 부분
        {
            this.x = x;
            this.y = y;
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public int GetX()
        {
            return x;
        }

        public int Gety()
        {
            return y;
        }

        public void MoveTo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void MoveBy(int moveX, int moveY)
        {
            this.x = this.x + moveX;
            this.y = this.y + moveY;

        }

        public override string ToString()
        {
            return "X : " + this.x + ". y : " + this.y;
        }
    }
}
