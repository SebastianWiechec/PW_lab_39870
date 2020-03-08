using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //[9,99 x masa ciała (kg)] + [6,25 x wzrost (cm)] - [4,92 x wiek (lata)] + 5 dla M  lub -161 dla K
        private void button1_Click(object sender, EventArgs e)

        {
            int z = 1;
            if ((textBox1.Text != "") && (textBox2.Text != "") && ((radioButton1.Checked) | (radioButton2.Checked)))
            {
                if (radioButton1.Checked) z = -165;
                if (radioButton2.Checked) z = 5;
                               
                label3.ForeColor = Color.Black;
                double waga = Convert.ToDouble(textBox1.Text);
                double wzrost = Convert.ToDouble(textBox2.Text);
                double wiek = Convert.ToDouble(textBox3.Text);
                // Debug.WriteLine(z);
                //Debug.WriteLine(wzrost);
                double bmr = (9.99 * waga) + (6.25 * wzrost) - (4.92 * wiek) + z;
                label3.Text = bmr.ToString();
            }
            else
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Brak Danych !";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}

