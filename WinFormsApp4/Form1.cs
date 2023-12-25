using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        private Circle circle;
        private Square square;
        private Rhomb rhomb;
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.White;
            circle = new Circle(20, 10, 20, this);
            rhomb = new Rhomb(50, 80, 30, 100, this);
            square = new Square(40, 55, 50, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            square.MoveRight();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rhomb.MoveRight();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            circle.MoveRight();
        }
    }
}
