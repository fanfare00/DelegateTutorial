using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace JamesDelegateHandout
{
    class Food
    {
        public Rectangle Rect;
        

        public Food(int x, int y, int width, int height)
        {
            Rect = new Rectangle(x, y, width, height);
        }

        public void Draw(PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Lime, Rect);
        }
    }
}
