using System.Drawing;
using System.Windows.Forms;

namespace Lab5_OOP_PartTwo
{
    class Square : Figure
    {
        private readonly Form1 _form1;
        private readonly float _sideLength;

        public Square(float sideLength, float x, float y, Form1 form1) : base(x, y)
        {
            _sideLength = sideLength;
            _form1 = form1;
        }

        protected override void DrawBlack(PictureBox box)
        {
            using (var graph = Graphics.FromImage(box.Image))
                graph.DrawRectangle(Pens.Black, X, Y, _sideLength, _sideLength);
        }

        protected override void HideDrawingBackGround(PictureBox box)
        {
            using (var graph = Graphics.FromImage(box.Image))
                graph.DrawRectangle(new Pen(_form1.BackColor), X, Y, _sideLength, _sideLength);
        }
    }
}