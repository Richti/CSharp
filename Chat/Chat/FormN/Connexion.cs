using AuthentificationN;
using Client;
using Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormN
{
    public partial class Connexion : Form
    {
        private User user;
        public ClientGestTopics clientGT { get; set; }

        public Connexion(IPAddress Ip, int port)
        {
            InitializeComponent();
            clientGT = new ClientGestTopics(Ip, port);
            Thread test1 = new Thread(new ThreadStart(clientGT.connect));
            test1.Start();
        }

        public void initText()
        {
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
            labelErreur.Text = "";
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            try {

                clientGT.authentify(textBoxLogin.Text, textBoxPassword.Text);

                user = new User(textBoxLogin.Text, textBoxPassword.Text);
                InfoUser info = new InfoUser(user,this);
                info.Show();
                this.Hide();
            }
            catch(WrongPasswordException)
            {
                labelErreur.Text = "Le password est incorrect !";
            }
            catch(UserUnknownException)
            {
                labelErreur.Text = "Ce compte n'existe pas !";
            }
        }


        private void buttonCréer_Click(object sender, EventArgs e) 
        {
            try {
                if (textBoxLogin.Text == "")
                {
                    labelErreur.Text = "Vous n'avez pas saisie de login !";
                    return;
                }
                if (textBoxPassword.Text == "")
                {
                    labelErreur.Text = "Vous n'avez pas saisie de password !";
                    return;
                }

                clientGT.addUser(textBoxLogin.Text, textBoxPassword.Text);
                System.Windows.Forms.MessageBox.Show("Votre compte à bien été créé !", textBoxLogin.Text);
            }
            catch(UserExistsException)
            {
                labelErreur.Text = "Ce login est déjà utilisé !";
            }
        }


        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttonConnexion_Click(sender, e);
            }
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }
    }
}
