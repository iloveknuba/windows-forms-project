using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tipaLABA._2
{
    // make a program to find element of progression and sum of all elements in 3 cases
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        Tline l1, l2, l3;
            try
            {
                int a1, d, n1, n2, a, b;
                a1 = Convert.ToInt16(textBox1.Text);
                d = Convert.ToInt16(textBox2.Text);
                n1 = Convert.ToInt16(textBox3.Text);
                n2 = Convert.ToInt16(textBox4.Text);
                a = Convert.ToInt16(textBox5.Text);
                b = Convert.ToInt16(textBox6.Text);
                l1 = new Tline(a1, d, n1, n2);
                l2 = new Tline(a, b);
                l3 = new Tline();
                label8.Text ="Sum of elements ="+ Convert.ToString(Math.Round(l1.SUM, 2));
                l1.Ur(label7);
                label16.Text = "Sum of elements =" + Convert.ToString(Math.Round(l2.SUM, 2));
                l2.Ur(label15);
                label22.Text = "Sum of elements  =" + Convert.ToString(Math.Round(l3.SUM, 2));
                l3.Ur(label21);
                label11.Text = l2.A1.ToString();
                label12.Text = l2.D.ToString();
                label13.Text = l2.N1.ToString();
                label14.Text=l2.N2.ToString();
                label17.Text=l3.A1.ToString();
                label18.Text = l3.D.ToString();
                label19.Text = l3.N1.ToString();
                label20.Text = l3.N2.ToString();
            }
            catch
            {
                MessageBox.Show("error");
            }
        }
    }

    class Tline
    {
        int a1;
        int d;
        int n1;
        int n2;
        double sum;
        int number;
        public Tline(int aa1, int dd1, int nn1, int nn2)  // case 1: all elements input in textbox
        {
            a1 = aa1;
            d = dd1;
            n1 = nn1;
            n2 = nn2;
        }
        public Tline(int a, int b) //  case 2: all elements determines randomly from a to b
        {
            Random ran = new Random();
            a1 = ran.Next(a, b);
            d = ran.Next(a, b);
            n1 = ran.Next(a, b);
            n2 = ran.Next(a, b);
        }
        public Tline() // all elements determines randomly from 0 to 100;
        {
            Random ran = new Random();
            a1 = ran.Next(0, 100);
            d = ran.Next(0, 100);
            n1 = ran.Next(0, 100);
            n2 = ran.Next(0, 100);
        }
        public double SUM
        {
            get
            {
                sum = (2 * a1 + d * (n2 - 1)) * n2 / 2;
                return sum;
            }
        }
        public void Ur(Label l)
        {
            int number;
            number = a1 + d * (n1 - 1);
            l.Text = "Element of progression =" + number;
        }
        public int A1
        {
            get { return a1; }

        }
        public int D
        {
            get { return d; }
        }
        public int N1
        {
            get { return n1; }
        }
        public int N2
        {
            get { return n2; }
        }


    }
}
