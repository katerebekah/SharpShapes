using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Quadrilateral
    {
        public Rectangle() { }
        public Rectangle(int side1, int side2)
        {
            this.Top = side1;
            this.Right = side2;
            this.Bottom = side1;
            this.Left = side2;
        }

        public override float Area()
        {
            return this.Top * this.Right;
        }
    }
}
