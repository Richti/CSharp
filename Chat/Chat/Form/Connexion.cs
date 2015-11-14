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
        private Authentification am;
        private User user;

        public Connexion()
        {
            InitializeComponent();
            am = new Authentification();    
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
            try {
                am = new Authentification(); //Obliger de réinstancier...
                am.load("./../../../Users.txt");
                am.authentify(textBoxLogin.Text, textBoxPassword.Text);
                this.Hide();

                user = new User(textBoxLogin.Text, textBoxPassword.Text);
                InfoUser info = new InfoUser(user);
                info.ShowDialog();
            }
            catch(WrongPasswordException)
            {
                System.Windows.Forms.MessageBox.Show("Erreur de mot de passe !");
            }
            catch(UserUnknownException)
            {
                System.Windows.Forms.MessageBox.Show("Ce compte n'existe pas !");
            }
        }

        private void buttonCréer_Click(object sender, EventArgs e)
        {
            try {
                am.addUser(textBoxLogin.Text, textBoxPassword.Text);
                am.save("./../../../Users.txt");
                System.Windows.Forms.MessageBox.Show("Votre compte à bien été créé !", textBoxLogin.Text);
            }
            catch(UserExistsException)
            {
                System.Windows.Forms.MessageBox.Show("Merci de prendre un autre login !", "Compte existant");
            }
        }
    }
}
