using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsole.BusinessLogic
{
    using System.Drawing;

    public class Tree
    {
        private static Graphics _target;
        private static Brush _brush;
        
        public Tree(Graphics target, Brush brush)
        {
            _target = target;
            _brush = brush;
        }
        
        public DoublePoint GetFirstEndpoint()
        {
            return Utility.GetEndpoint(250.0, 50.0, (Math.PI * 0.5), 100.0);
        }

        public void Branch(int currDepth, double x, double y, double angle, double length, double width, int height, int maxDepth)
        {
            Utility.DrawLine(_target, _brush, x, y, angle, length, width, height);

            if (currDepth <= maxDepth)
            {
                DoublePoint newPoint = Utility.GetEndpoint(x, y, angle, length);
                Branch((currDepth + 1), newPoint.X, newPoint.Y, (angle + 0.3), (length * 0.8), (width * 0.7), height, maxDepth);
                Branch((currDepth + 1), newPoint.X, newPoint.Y, (angle - 0.3), (length * 0.8), (width * 0.7), height, maxDepth);
            }
        }
    }
}
