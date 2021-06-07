using System.Drawing;
using System.Windows.Forms;

namespace Lab5_OOP_PartTwo
{
    class Rhomb : Figure
    {
        private readonly Form1 _form1;
        private readonly float _horDiagLen;
        private readonly float _vertDiagLen;

        public Rhomb(float horDiagLen, float vertDiagLen, float x, float y, Form1 form1)
            : base(x, y)
        {
            _horDiagLen = horDiagLen;
            _vertDiagLen = vertDiagLen;
            _form1 = form1;
        }

        protected override void DrawBlack(PictureBox box)
        {
            using (var graph = Graphics.FromImage(box.Image))
                graph.DrawPolygon(Pens.Black, new PointF[]
                {
                    new PointF(X, _horDiagLen / Y), new PointF((_vertDiagLen / Y) + X, 0f),
                    new PointF(_vertDiagLen + X, _horDiagLen / Y), new PointF(_vertDiagLen / Y + X, _horDiagLen)
                });
        }

        protected override void HideDrawingBackGround(PictureBox box)
        {
            using (var graph = Graphics.FromImage(box.Image))
                graph.DrawPolygon(new Pen(_form1.BackColor), new PointF[]
                {
                    new PointF(X, _horDiagLen / Y), new PointF((_vertDiagLen / Y) + X, 0f),
                    new PointF(_vertDiagLen + X, _horDiagLen / Y), new PointF(_vertDiagLen / Y + X, _horDiagLen)
                });
        }
    }
}