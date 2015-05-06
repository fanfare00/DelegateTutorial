using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace JamesDelegateHandout
{
    class Blob
    {
        public Rectangle Rect;

        // This is the delgate type, this will specify the name of the delegate
        // and the function signature of the function that this delgaet can call
        public delegate void CurrentSizeBroadcaster(Size curSize);

        // This is the instance of out delegate type which will hold
        // list of functions to call too
        public CurrentSizeBroadcaster currentSizeBroadcaster;

        public Blob()
        {
            Rect = new Rectangle(200, 200, 50, 50);
        }

        public void Draw(PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Blue, Rect);
        }

        public Size CurrentSize
        {
            get
            {
                return Rect.Size;
            }
            set
            {
                //processes will call this setter to set the battery level
                Rect.Size = value;

                //check whether someone has registered for listening or not
                if (currentSizeBroadcaster != null)
                {
                    //call all the functions with new battery level value
                    currentSizeBroadcaster(Rect.Size);
                }
            }
        }

    }
}
