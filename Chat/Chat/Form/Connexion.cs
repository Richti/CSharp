using AuthentificationN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class Connexion : Form
    {
        Authentification am;

        public Connexion()
        {
            InitializeComponent();
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            am.authentify(textBoxLogin.Text, textBoxPassword.Text);
            this.Hide();
            InfoUser info = new InfoUser();
            info.MyProperty = textBoxLogin.Text;
            info.ShowDialog();
        }

        private void buttonCréer_Click(object sender, EventArgs e)
        {
            am = new Authentification();
            am.addUser(textBoxLogin.Text, textBoxPassword.Text);
            System.Windows.Forms.MessageBox.Show("Votre compte à bien été créé !", textBoxLogin.Text);
        }
    }
}
