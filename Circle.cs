using System.Drawing;
using System.Windows.Forms;

namespace Lab5_OOP_PartTwo
{
    class Circle : Figure
    {
        private readonly Form1 _form1;
        private readonly float _radius;

        public Circle(float radius, float x, float y, Form1 form1) : base(x, y)
        {
            _radius = radius;
            _form1 = form1;
        }

        protected override void DrawBlack(PictureBox box)
        {
            using (var graph = Graphics.FromImage(box.Image))
                graph.DrawEllipse(Pens.Black, X, Y, _radius, _radius);
        }

        protected override void HideDrawingBackGround(PictureBox box)
        {
            using (var graph = Graphics.FromImage(box.Image))
                graph.DrawEllipse(new Pen(_form1.BackColor), X, Y, _radius, _radius);
        }
    }
}