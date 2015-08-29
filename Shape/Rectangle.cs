using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Quadrilateral
    {

        public Rectangle() : base() { }

        public Rectangle(float side1, float side2) :base()
        {
            this.Top = side1;
            this.Right = side2;
            this.Bottom = side1;
            this.Left = side2;
        }

        public override float Area()
        {
            if (this.Top <= 0 || this.Right <= 0)
            {
                throw new ArgumentException();
            }
            return this.Top * this.Right;
        }
    }
}
