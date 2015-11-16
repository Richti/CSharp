using AuthentificationN;
using Client;
using Net;
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

namespace Chat
{
    public partial class InfoUser : Form
    {
        private User utilisateur;
        private TextChatter chatter;
        private TextGestTopics topic;
        private IChatroom cr;
         
        private ServerGestTopics server;
        private ClientGestTopics cg;
        private IPAddress Ip;
        private int port;

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


        private void buttonDéco_Click(object sender, EventArgs e)
        {
            server.stopServer();
            Application.Exit();
        }


        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxAlias.Text == "")
            {
                labelAlias.Text = "Il faut que tu choisisses un alias !";
            }
            else
            {
                if (tabControl1.TabPages.Count <= 1)
                {
                    try
                    {
                        launcherServer();
                        labelStartServeur.Text = "Etat du Server : ON";

                    }
                    catch (Exception)
                    {
                        labelStartServeur.Text = "Error lors du lancement du serveur !";
                    }

                    chatter = new TextChatter(textBoxAlias.Text);
                    labelAlias.Text = "Ton alias est : " + chatter.alias;
                    labelAlias.Show();
                    Text = "Enjoy " + chatter.alias + " !";
                    tabControl1.TabPages.Insert(1, tabPage2);
                    tabControl1.SelectedTab = tabControl1.TabPages["tabPage2"];
                }
                else if(tabControl1.TabPages.Count >1)
                        {
                    tabControl1.SelectedTab = tabControl1.TabPages["tabPage2"];
                }
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
                //cg.createTopic(textBoxNomSalon.Text); // client
                topic.createTopic(textBoxNomSalon.Text);
                labelSalonCréer.Text = "Votre salon " + textBoxNomSalon.Text + " a été créer avec succès !";
                labelSalonCréer.Show();
                comboBox1.Items.Add((String)topic.listTopics());
                comboBox1.Text = textBoxNomSalon.Text;
            }

        }

  

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
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
                if (labelStartServeur.Text == "Etat du Server : ON")
                {
                    connexion();
                    tabControl1.TabPages.Insert(2, tabPage3);
                    tabPage3.Text = "Salon : " + comboBox1.Text;                   
                    tabControl1.SelectedTab = tabControl1.TabPages["tabPage3"];
                    cg.createTopic(comboBox1.Text); // Marche pas encore
                    cr = topic.joinTopic(comboBox1.Text);
                    textBoxConv.Text = "(Message from Chatroom : " + comboBox1.Text + ") " + chatter.alias + " has join the room";
                    }
                 else
                {
                    tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
                    System.Windows.Forms.MessageBox.Show("Merci de lancer le serveur !", "Aucun server lancé");
                    labelStartServeur.Text = "Merci de lancer le serveur !";
                }
            }
        }

       
        private void buttonEnvoyer_Click(object sender, EventArgs e)
        {
            cr.post(textBoxConv.Text, chatter);
            textBoxConv.Text += Environment.NewLine + richTextBoxMsg.Text;
            richTextBoxMsg.Text = "";
        }

        public bool launcherServer()
        {
            Ip = IPAddress.Parse("127.0.0.1");
            server = new ServerGestTopics(Ip);
            port = 55555;
            ParameterizedThreadStart ts = new ParameterizedThreadStart(server.startServer);
            Thread t = new Thread(ts);
            t.Start(port);
            return true;
        }

        public void connexion()
        {
            cg = new ClientGestTopics(Ip, port);
            Thread test1 = new Thread(new ThreadStart(cg.connect));
            test1.Start();
        }
    }
}
