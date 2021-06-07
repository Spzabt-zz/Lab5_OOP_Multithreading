using System.Threading;
using System.Windows.Forms;

namespace Lab5_OOP_PartTwo
{
    abstract class Figure
    {
        protected float X { get; private set; }
        protected float Y { get; private set; }

        protected Figure(float x, float y)
        {
            X = x;
            Y = y;
        }

        protected abstract void DrawBlack(PictureBox pictureBox);

        protected abstract void HideDrawingBackGround(PictureBox pictureBox);

        public void MoveRight(PictureBox pictureBox)
        {
            HideDrawingBackGround(pictureBox);
            X++;
            DrawBlack(pictureBox);
        }
    }
}