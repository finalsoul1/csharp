using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
// 솔루션탐색기 -> 참조 -> 참조추가
namespace Shapes
{
    public class Circle
    {
        double radius;
        public Circle()
        {
            this.radius = 0;
        }
        public Circle(int r)
        {
            this.radius = r;
        }
        public double Area()
        {
            return Math.PI * (radius * radius);
        }
        public void Draw()
        {
            Pen p = new Pen(Color.Red);
        }

    }
}
