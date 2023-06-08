using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        //line
        Pen linePen;
        public static Color penColor;
        int lineThickness;

        int shape;

        //freeHand
        Boolean isMouseDown;
        Point p1;

        public Form1()
        {
            InitializeComponent();
            penColor= Color.Red;
            lineThickness = 5;
            isMouseDown= false;
            toolStripStatusLabel1.Text = "color= Red" ;
            toolStripStatusLabel2.Text = "Thickness=5";


        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = 1;
            Invalidate();


            


        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = this.CreateGraphics();
            if (shape == 1)
            {

                linePen = new Pen(penColor, lineThickness);
                g.DrawLine(linePen, 40, 80, 150, 150);
            }
            else if (shape == 2)
            {
                linePen = new Pen(penColor, lineThickness);

                g.DrawEllipse(linePen, 300, 200, 150, 150);

            }
            else if (shape == 3)
            {
                linePen = new Pen(penColor, lineThickness);
                g.DrawRectangle(linePen, 40, 200, 150, 150);
            }
/*            else if (shape == 4)
            {
                

            }*/
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)

        {
            shape = 2;
            Invalidate();


           
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = 3;
            Invalidate();

            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            shape = 1;
            Invalidate();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            shape = 2;
            Invalidate();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            shape = 3;
            Invalidate();
        }

        private void styleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dialog dialog= new Dialog();
            dialog.Thick = lineThickness;

            DialogResult result= dialog.ShowDialog();

            if (result==DialogResult.OK)
            {
                lineThickness = dialog.Thick;
                toolStripStatusLabel1.Text = "color=" + penColor;
                toolStripStatusLabel2.Text = "Thickness=" + lineThickness;

            }
        }

        private void freeHandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = 4;
        }

        private void freeHandToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            shape = 4;
            Invalidate();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Dialog dialog = new Dialog();
            dialog.Thick = lineThickness;

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                lineThickness = dialog.Thick;
                toolStripStatusLabel1.Text = "color=" + penColor;
                toolStripStatusLabel2.Text = "Thickness=" + lineThickness;

                Invalidate();

            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown=true;
            p1 = e.Location;
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown=false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            Graphics g=this.CreateGraphics();

            if(isMouseDown==true && shape==4) {

                linePen = new Pen(penColor, lineThickness);
                g.DrawLine(linePen, p1, e.Location);
                p1= e.Location;

            }
        }
    }
}
