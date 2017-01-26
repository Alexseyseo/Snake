using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> vList;

        public VerticalLine(int yTop, int yBottom, int x, char sym)
        {
            vList = new List<Point>();
            for(int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, sym);
                vList.Add(p);
            }
        }

        public void Drow()
        {
            foreach (Point p in vList)
            {
                p.Draw();
            }
        }
    }
}
