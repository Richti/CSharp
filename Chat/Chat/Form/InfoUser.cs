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
    public partial class InfoUser : Form
    {
        private User utilisateur;
        private TextChatter chatter;
        
        public InfoUser(User U1)
        {
            InitializeComponent();
            utilisateur = U1;
        }

        private void InfoUser_Load(object sender, EventArgs e)
        {
            labelUser.Text = "Welcome : " + utilisateur.login;
            Text = "Utilisateur";
        }

        private void labelUser_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonDéco_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void labelAlias_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAlias_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            chatter = new TextChatter(textBoxAlias.Text);
            labelAlias.Text = "Ton alias est : " + chatter.alias;
        }
    }
}
