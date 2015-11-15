using AuthentificationN;
using Net;
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
        private TextGestTopics topic;
        private IChatroom cr;

        public InfoUser(User U1)
        {
            InitializeComponent();
            utilisateur = U1;
            splitContainer1.SplitterDistance = 128; //Permet de bien placer ce pu*ain de séparteur...
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3); // cache la tabpage
        }

        private void InfoUser_Load(object sender, EventArgs e)
        {
            labelUser.Text = "Bienvenue à toi " + utilisateur.login + " !";
            labelUser.Show();
            Text = "Chat";
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
            if (textBoxAlias.Text == "")
            {
                labelAlias.Text = "Il faut que tu choisisses un alias !";
            }
            else
            {
                chatter = new TextChatter(textBoxAlias.Text);
                labelAlias.Text = "Ton alias est : " + chatter.alias;
                labelAlias.Show();
                Text = "Enjoy " + chatter.alias + " !";
                tabControl1.TabPages.Insert(1, tabPage2);
                tabControl1.SelectedTab = tabControl1.TabPages["tabPage2"];
            }
        }

        private void buttonValiderSalon_Click(object sender, EventArgs e)
        {
            if (textBoxNomSalon.Text == "")
            {
                labelSalonCréer.Text = "Merci de rentrer un nom de salon !";
                labelSalonCréer.Show();
            }
            else
            {
                topic = new TextGestTopics();
                topic.createTopic(textBoxNomSalon.Text);
                labelSalonCréer.Text = "Votre salon " + textBoxNomSalon.Text + " a été créer avec succès !";
                labelSalonCréer.Show();
                comboBox1.Items.Add((String)topic.listTopics());
                comboBox1.Text = textBoxNomSalon.Text;
            }

        }

        private void labelSalonCréer_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void buttonAccéderSalons_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox1.Text == "Selectionner")
            {
                labelErrorCreaSal.Text = "Merci de choisir un salon parmi la liste !";
                labelErrorCreaSal.Show();
            }
            else
            {
                tabControl1.TabPages.Insert(2, tabPage3); //Réaffiche la tabPage à sa place d'origine
                tabPage3.Text = "Salon : " + comboBox1.Text;
                tabControl1.SelectedTab = tabControl1.TabPages["tabPage3"]; // Bouge de page
                cr = topic.joinTopic(comboBox1.Text);
                textBoxConv.Text = "(Message from Chatroom : " + comboBox1.Text + ") " + chatter.alias + " has join the room";
            }
        }

        private void richTextBoxConv_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEnvoyer_Click(object sender, EventArgs e)
        {
            cr.post(textBoxConv.Text, chatter);
            textBoxConv.Text += Environment.NewLine + richTextBoxMsg.Text;
            richTextBoxMsg.Text = "";
        }
    }
}
