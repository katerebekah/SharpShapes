using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Quadrilateral : Shape
    {
        private float top;
        private float bottom;
        private float left;
        private float right;

        public float Top
        {
            get
            {
                return this.top;
            }
            set
            {
                if (value <= 0.0)
                {
                    this.top = value;
                }
            }
        }
        public float Right
        {
            get
            {
                return this.right;
            }
            set
            {
                if (value <= 0.0)
                {
                    this.right = value;
                }
            }
        }
        public float Bottom
        {
            get
            {
                return this.bottom;
            }
            set
            {
                if (value <= 0.0)
                {
                    this.bottom = value;
                }
            }
        }
        public float Left
        {
            get
            {
                return this.left;
            }
            set
            {
                if (value <= 0.0)
                {
                    this.left = value;
                }
            }
        }
        public Quadrilateral() : base() { }
        public Quadrilateral(float top, float right, float bottom, float left)
        {
            this.Top = top;
            this.Right = right;
            this.Bottom = bottom;
            this.Left = left;
        }

        public abstract override float Area();
             
        public override float Perimeter()
        {
            if (this.Top == 0.0 || this.Right == 0.0 || this.Bottom == 0.0 || this.Left == 0.0)
            {
                throw new ArgumentException();
            }
            return this.Top + this.Right + this.Bottom + this.Left;
        }
    }
}