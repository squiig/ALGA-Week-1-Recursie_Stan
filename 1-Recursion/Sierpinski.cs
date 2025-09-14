using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGA
{
    public class Sierpinski
    {
        public static void draw_sierpinski_carpet(int levels, double x, double y, double width, double height, SierpinskiCanvas canvas)
        {
            canvas.drawSquare(0, 0, 100, 100);
        }

        public interface SierpinskiCanvas
        {
            void drawSquare(double x, double y, double width, double height);
        }
    }
}
