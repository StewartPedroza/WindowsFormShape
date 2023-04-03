using Shape;
using static Shape.Rectangle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = Shape.Rectangle;

namespace WindowsFormShape
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupSquare.Visible = false;
            groupRec.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbSquare.Checked)
            {
                Square sq = new Square(txtName.Text, int.Parse(txtNumofSides.Text), double.Parse(txtLengthSquare.Text));
                MessageBox.Show(sq.ToString());
            }
            else if (rbRectangle.Checked)
            {
                Rectangle Rec = new Rectangle(txtName.Text, int.Parse(txtNumofSides.Text), double.Parse(txtLengthSquare.Text),double.Parse(txtWidthRectangle.Text));
                MessageBox.Show(Rec.ToString());
            }
        }

        private void rbRectangle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRectangle.Checked)
            {
                groupRec.Visible = true;

            }
            else 
            {
                groupRec.Visible = false;
            }

        }

        private void rbSquare_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSquare.Checked)
            {
                groupSquare.Visible = true;

            }
            else
            {
                groupSquare.Visible = false;
            }
        }
    }
}
