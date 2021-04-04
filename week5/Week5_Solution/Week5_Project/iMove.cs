using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Project
{
    interface iMove
    {
        void MoveTo(int x, int y);//앞에 public은 적지 않는다
                                //x, y좌표를 지정한 x, y좌표로 이동
        void MoveBy(int offX, int offy); // x, y좌표를 지정한 offx, offy만큼 이동


    }
}
