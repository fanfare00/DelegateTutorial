using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JamesDelegateHandout
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();

            bool run = false;
            Bitmap bm = new Bitmap(this.Size.Width, this.Size.Height);
            Blob blob = new Blob();
            Point mouseLocation = new Point();
            List<Food> foods = new List<Food>();

            // Subscribe to the current size delegate to know the current size
            blob.currentSizeBroadcaster += new Blob.CurrentSizeBroadcaster(newSizeIndicator);

            // Here we have another module that is listening to the
            // Listen to the size change but this time implemented with an anonymous function
            blob.currentSizeBroadcaster += delegate(Size newSize) { labelAnonymous.Text = "Anonymous: " + newSize.ToString(); };

            // The third approach using a  Lambda expression to subsribe to the delegates
            blob.currentSizeBroadcaster += (newSize) => labelLambda.Text = "Lambda: " + newSize.ToString();

            //set up / reset blob and foods
            initializeTest(foods, blob);
                
            //Example of defining event handlers as lambda expressions, allowing the passing of variables
            this.Paint += new PaintEventHandler((sender, e) => TestForm_Paint(sender, e, bm, blob, foods));
            this.MouseMove += new MouseEventHandler((sender, e) => TestForm_MouseMove(sender, e, mouseLocation, blob, foods, run));
            this.MouseUp += (o, e) => run = false;
            this.MouseDown += (o,e) => run = true;
            this.buttonReset.Click += (o, e) => initializeTest(foods, blob);

            this.DoubleBuffered = true;
        }

        private void newSizeIndicator(Size newSize)
        {
            labelDelegate.Text = "Delegate: " + newSize.ToString();
        }

        private void initializeTest(List<Food> foods, Blob blob)
        {
            ////////////////////////////////////////////////////////////////////
            /// Local Variables
            ////////////////////////////////////////////////////////////////////

            Random rand = new Random();
            int randWidth = 0;
            int randHeight = 0;

            ////////////////////////////////////////////////////////////////////

            foods.Clear();
            Invalidate();
            blob.CurrentSize = new Size(50, 50);

            for (int i = 0; i < 5; i++)
            {
                randWidth = rand.Next(100, this.Width-100);
                randHeight = rand.Next(50, this.Height-50);
                foods.Add(new Food(randWidth, randHeight, 30, 30));
            }
        }

        private void growOnCollision(Blob blob, Food food, List<Food> foods)
        {
            if (blob.Rect.IntersectsWith(food.Rect))
            {
                blob.CurrentSize = new Size(blob.Rect.Width + 30, blob.Rect.Height + 30);
                foods.Remove(food);
            }
        }

        private void TestForm_Paint(object sender, PaintEventArgs e, Bitmap bm, Blob blob, List<Food> foods)
        {
            e.Graphics.DrawImage(bm, 0, 0);
            blob.Draw(e);

            foreach (Food food in foods)
            {
                food.Draw(e);
            } 
        }

        private void TestForm_MouseMove(object sender, MouseEventArgs e, Point mouseLocation, Blob blob, List<Food> foods, bool run)
        {
            mouseLocation = e.Location;
            labelLocation.Text = mouseLocation.ToString();

            if (run)
            {
                blob.Rect.X = mouseLocation.X - (blob.Rect.Width/2);
                blob.Rect.Y = mouseLocation.Y - (blob.Rect.Height/2);

                for(int i = foods.Count - 1; i >= 0; i--) 
                {
                    growOnCollision(blob, foods[i], foods);
                }

                Invalidate();
            }
        }
    }
}
