using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_abhikadiya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle();


            texthypo.Text = $"Side C : {triangle.GetHypotenuse(double.Parse(txtSide_a.Text), double.Parse(textSide_b.Text))} {Environment.NewLine}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle();
            textArea.Text = $"Area of Triangle : {triangle.GetAngle(double.Parse(textSide1.Text), double.Parse(textSide2.Text))} {Environment.NewLine}";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle();
            textAngle.Text = $"Remaining angle of Triangle : {triangle.GetAngle(double.Parse(textAngle_a.Text), double.Parse(textAngle_b.Text))} {Environment.NewLine}";
        }
    }
}
