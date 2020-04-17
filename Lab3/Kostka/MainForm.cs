using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Kostka_do_gry
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // inicjalizacja - wstępne losowanie na start
            Losuj(); 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public void Losuj()
        {
            labelWynik.Text = "Rzut kostką trwa ...";
            WaitNSeconds(1);
            Random rnd = new Random();
             int wartosc = 0;
                wartosc = rnd.Next(1, 7);
                Debug.WriteLine("wartosc: " + wartosc);
                switch (wartosc)
                {
                    case 1:
                        LabGoraLewy.Visible = false;
                        LabSrodekLewy.Visible = false;
                        LabDolLewy.Visible = false;
                        LabSrodek.Visible = true;
                        LabGoraPrawy.Visible = false;
                        LabSrodekPrawy.Visible = false;
                        LabDolPrawy.Visible = false;
                        break;
                    case 2:
                        LabGoraLewy.Visible = false;
                        LabSrodekLewy.Visible = false;
                        LabDolLewy.Visible = true;
                        LabSrodek.Visible = false;
                        LabGoraPrawy.Visible = true;
                        LabSrodekPrawy.Visible = false;
                        LabDolPrawy.Visible = false;
                        break;
                    case 3:
                        LabGoraLewy.Visible = false;
                        LabSrodekLewy.Visible = false;
                        LabDolLewy.Visible = true;
                        LabSrodek.Visible = true;
                        LabGoraPrawy.Visible = true;
                        LabSrodekPrawy.Visible = false;
                        LabDolPrawy.Visible = false;
                        break;
                    case 4:
                        LabGoraLewy.Visible = true;
                        LabSrodekLewy.Visible = false;
                        LabDolLewy.Visible = true;
                        LabSrodek.Visible = false;
                        LabGoraPrawy.Visible = true;
                        LabSrodekPrawy.Visible = false;
                        LabDolPrawy.Visible = true;
                        break;
                    case 5:
                        LabGoraLewy.Visible = true;
                        LabSrodekLewy.Visible = false;
                        LabDolLewy.Visible = true;
                        LabSrodek.Visible = true;
                        LabGoraPrawy.Visible = true;
                        LabSrodekPrawy.Visible = false;
                        LabDolPrawy.Visible = true;
                        break;
                    case 6:
                        LabGoraLewy.Visible = true;
                        LabSrodekLewy.Visible = true;
                        LabDolLewy.Visible = true;
                        LabSrodek.Visible = false;
                        LabGoraPrawy.Visible = true;
                        LabSrodekPrawy.Visible = true;
                        LabDolPrawy.Visible = true;
                        break;
                }

            labelWynik.Text = "Wypadło w rzucie: " + wartosc;
            globalVariable.doSchowka = wartosc;
        }
        private void labelControl_DoubleClick(object sender, EventArgs e)
        {

        }

        public void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
        //Po naciśnięciu klawisza r - ponowne losowanie
            if (e.KeyChar == 'r')
            {
                Losuj();
            }
        }

        private void WaitNSeconds(int secs)
        {
            if (secs < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(secs);
            while (DateTime.Now < _desired)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            using (Pen pen = new Pen(Color.Black));
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(globalVariable.doSchowka.ToString());
        }

        private void LabelDownRight_Click(object sender, EventArgs e)
        {

        }

        private void labelHint_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTopRight_Click(object sender, EventArgs e)
        {

        }

        private void LabSrodekPrawy_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
