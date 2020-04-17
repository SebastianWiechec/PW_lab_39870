using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel_logowania
{
    public partial class PanelLogowania : Form
    {
        public PanelLogowania()
        {
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
// Wstępne ukrycie tekstu z informacją o braku loginu lub hasła
            BrakLoginu.Visible = false;
            BrakHasla.Visible = false;
//pierwsze sprawdzenie, czy pole z loginem nie jest puste
            if (textBoxLogin.Text != "")
            {
//drugie prawdzanie czy pole hasło nie jest puste
                if (textBoxHaslo.Text != "")
                {
//Tworzenie użytkownika do porownania
                    User uzytkownik = new User()
                    {
                        UserName = "Sebastian",
                        UserPassword = "39870"
                    };
//Nadanie loginu i hasła do nowego użytkownika (logowanie) z textboxów
                    User logowanie = new User() 
                    { 
                        UserName = textBoxLogin.Text, UserPassword = textBoxHaslo.Text 
                    };

//Tworzenie obiektu nowego okna
                    LoginCheck loginCheckWindow = new LoginCheck();

//Sprawdzanie czy dane logowania są poprawne
                    if (logowanie.UserName == uzytkownik.UserName)
                    {
                        if (logowanie.passwordSHA512() == uzytkownik.passwordSHA512())
                        {
//Logowanie OK
                            loginCheckWindow.loginStatus = true;
                            loginCheckWindow.loginText = "Logowanie poprawne!";
                            loginCheckWindow.Show();
                        }
                        else
                        {
//Hasło się nie zgadza
                            loginCheckWindow.loginStatus = false;
                            loginCheckWindow.loginText = "Nieprawidłowe hasło!\nPodpowiedź: numer indeksu";
                            loginCheckWindow.Show();
                        }
                    }
                    else
                    {
//Login się nie zgadza
                        loginCheckWindow.loginStatus = false;
                        loginCheckWindow.loginText = "Nieprawidłowy login!\nPodpowiedź: Twoje imię";
                        loginCheckWindow.Show();
                    }
                }
//Wyświetlenie ostrzeżenia o braku hasła
                else
                {
                    BrakHasla.Visible = true;
                }
            }
//Wyświetlenie ostrzeżenia o braku loginu
            else
            {
                BrakLoginu.Visible = true;
            }
        }

        private void labelPasswordEmpty_Click(object sender, EventArgs e)
        {

        }

        private void PanelLogowania_Load(object sender, EventArgs e)
        {

        }
    }
}
