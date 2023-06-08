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
    public partial class Dialog : Form
    {

        int thickness;

          public int Thick
        {
            set { 
                thickness = value;
                if (thickness == 1)
                {
                    radioButton1.Checked = true;
                }else if(thickness == 2)
                {
                    radioButton2.Checked = true;
                }else if(thickness==3)
                {
                    radioButton3.Checked = true;
                }else if(thickness==4)
                {
                    radioButton4.Checked = true;
                }else if(thickness==5)
                {
                    radioButton5.Checked = true;
                }
            
            }
            get {
                int thick = 0;
                if (radioButton1.Checked == true)
                {
                    thick = 1;
                }else if(radioButton2.Checked == true)
                {
                    thick = 2;
                }else if(radioButton3.Checked== true)
                {
                    thick = 3;
                } else if(radioButton4.Checked== true)
                {
                    thick = 4;
                }else if(radioButton5.Checked==true)
                {
                    thick = 5;
                }
                return thick;
            }
        }
        public Dialog()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel; 
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Form1.penColor;
            DialogResult colordialog= colorDialog1.ShowDialog();
            if(colordialog==DialogResult.OK)
            {
                Form1.penColor=colorDialog1.Color;
            }
        }
    }
}
