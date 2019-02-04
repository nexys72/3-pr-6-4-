using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_практика_6_3_
{
    public partial class Form1 : Form
    {
        class Valuta
        {
            public static double ValDollar(double a1)
            {
                double p;
                p = a1 * 66;
                return a1 * 66;
            }
            public static double ValEvro(double a1)
            {
                double p;
                p = a1 * 74;
                return a1 * 74;
            }
            
            public static double ValFynt(double a1)
            {
                double p;
                p = a1 * 86;
                return a1 * 86;
            }
        }
        
            public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a1, s = 0;
            a1 = Convert.ToDouble(textBox1.Text);

            if (listBox1.Text == "доллар")
            {
                s = Valuta.ValDollar(a1);
                label1.Text = a1 + " руб " + " = " + Convert.ToString(s) + " долларов";
            }
            else
                if (listBox1.Text == "евро")
            {
                s = Valuta.ValEvro(a1);
                label1.Text = a1 + " руб " + " = " + Convert.ToString(s) + " евро";
            }
            
               
            else
                        if (listBox1.Text == "фунт")
            {
                s = Valuta.ValFynt(a1);
                label1.Text = a1 + " руб " + " = " + Convert.ToString(s) + " фунтов";
            }
            else
            {
                s = a1;
                label1.Text = a1 + " руб " + " = " + Convert.ToString(s) + " грн";
            }
        }
    }
}
