using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Lab5_OOP_PartTwo
{
    public partial class Form1 : Form
    {
        private Figure _figure;

        public Form1()
        {
            InitializeComponent();
            var bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;
        }

        private void ThreadTask(Figure figure)
        {
            new Thread(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    figure.MoveRight(pictureBox1);
                    Thread.Sleep(100);
                    Invoke(new MethodInvoker(() => { pictureBox1.Refresh(); }));
                }
            }) {IsBackground = true}.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _figure = new Circle(25.0f, 25.0f, 25.0f, this);
            ThreadTask(_figure);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _figure = new Square(25.0f, 25.0f, 25.0f, this);
            ThreadTask(_figure);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _figure = new Rhomb(25.0f, 25.0f, 0f, 2.0f, this);
            ThreadTask(_figure);
        }
    }
}