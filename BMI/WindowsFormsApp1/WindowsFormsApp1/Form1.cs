﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                label3.ForeColor = Color.Black;
                double waga = Convert.ToDouble(textBox1.Text);
                double wzrost = Convert.ToDouble(textBox2.Text);
                //Debug.WriteLine(waga);
                //Debug.WriteLine(wzrost);
                double bmi = waga / (wzrost * wzrost);
                label3.Text = bmi.ToString();
            }
            else
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Brak Danych !";
            }
        }
    }
}

