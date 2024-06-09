using C969Scheduling;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969Scheduling
{
    public partial class LoginForm : Form
    {
        private List<User> users;
        private string culture;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ChangeLoginToSpanish()
        {
            LoginFormLabel.Text = "Pantalla de inicio de sesión";
            UsernameLabel.Text = "Nombre de usuario";
            PasswordLabel.Text = "Contraseña";
            LoginButton.Text = "Iniciar sesión";
            ExitButton.Text = "Salir";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string userName = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            try
            {
                if (userName == "" || password == "")
                {
                    if (culture == "es")
                    {
                        throw new LoginEx("Nombre de usuario y contraseña necesarios para iniciar sesión.");
                    }

                    throw new LoginEx("Username and Password needed to login.");
                }

                List<User> signedInUser = users.Where(user => user.UserName == userName).ToList();

                if (signedInUser.Count < 1)
                {
                    if (culture == "es")
                    {
                        throw new LoginEx("Introduzca un nombre de usuario válido.");
                    }
                    throw new LoginEx("Please enter a valid username.");
                }

                if (signedInUser[0].Password != password)
                {
                    if (culture == "es")
                    {
                        throw new LoginEx("Contraseña incorrecta.");
                    }
                    throw new LoginEx("Password incorrect.");
                }
                Log.ActivityLog(signedInUser[0]);

                var mainScreen = new MainHubForm(signedInUser[0]);
                mainScreen.Show();
                Hide();
            }
            catch (LoginEx error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            users = DB.GetUsers();
            
            if (culture == "es")
            {
                ChangeLoginToSpanish();
            }
        }
    }
}
