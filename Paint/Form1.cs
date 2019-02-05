using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
         
    {
        Graphics g;
        int x = 0;
        int y = 0;
        int size=1;
        Color color;
        bool MouseOn;
        bool isCleaner;
        public Form1()
        {
            InitializeComponent();
            
            g = panel1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
           
        }
       
       
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       
       
        private void drawingPen(object sender, MouseEventArgs e)
        {
          
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isCleaner)
            {
                color = colorDialog1.Color;
                button3.BackColor = color;
            }
            else
            {
                color = SystemColors.Window;
            }
            if (MouseOn)
            {
                base.OnMouseMove(e);
                Pen p = new Pen(color, size);
                p.StartCap = p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                Pen deleter = new Pen(Color.Black, size);
                //g.DrawEllipse(deleter, x, y, 1, 1);
                //g.DrawEllipse(p, x, y, 1, 1);
                g.DrawLine(p, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }


        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseOn = false;
            base.OnMouseUp(e);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseOn = true;
            x = e.X;
            y = e.Y;
        }

        private void BRUSH(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            size = int.Parse(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            isCleaner = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            isCleaner = true;
        }
    }
}
