using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

//Obliczamy wartość wg wzoru: 1* A+3* B+7* C+9* D+1* E+3* F+7* G+9* H+1* I+3* J = 155
//Bierzemy ostatnią cyfrę z wyniku 155 i odejmujemy ją od 10, czyli: 10-5=5. To powinna być ostatnia cyfra w numerze PESEL.





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
            if (textBox1.Text != "")
            {
                int[] a = new int[] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 7, 9 };
                bool dobry = true;
                string wprowadzony = textBox1.Text;
                int dlugosc = wprowadzony.Length;
                //int PESEL = Convert.ToInt32(textBox1.Text);

                
                int suma = 0, wart=0;
                for (int i = 0; i<dlugosc; i++)
                {
                    //suma = suma + int.Parse(wprowadzony[i].ToString());
                    wart = wart + (int.Parse(wprowadzony[i].ToString()) * a[i]);
                }

                
                int czyok = wart % 10;                                       

                if (czyok == int.Parse(wprowadzony[wprowadzony.Length - 1].ToString())) dobry = true;
                else dobry = false;


                if (dobry)
                {
                    label3.ForeColor = Color.Green;
                    label3.Text = "OK";
                }
                else
                {
                    label3.ForeColor = Color.Red;
                    label3.Text = "NOK";
                }
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
            label3.Text = "";
        }
    }
}

