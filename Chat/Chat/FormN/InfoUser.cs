using AuthentificationN;
using Chat;
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

namespace FormN
{
    public partial class InfoUser : Form
    {
        private User utilisateur;
        private IChatter chatter;        
        public ClientGestTopics clientGT { get; set; }

        public InfoUser(User U1)
        {
            InitializeComponent();
            utilisateur = U1;
            splitContainer1.SplitterDistance = 128; //Permet de bien placer ce pu*ain de séparteur...
            tabControl1.TabPages.Remove(tabPage2);
        }        

        public String[] listTopic(String topics)
        {
            return topics.Split(';');
        }

        private void InfoUser_Load(object sender, EventArgs e)
        {
            labelUser.Text = "Bienvenue à toi " + utilisateur.login + " !";
            labelUser.Show();
            Text = "Chat";
        }


        private void buttonDéco_Click(object sender, EventArgs e)
        {
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
                    chatter = new TextChatter(textBoxAlias.Text); //Mise en place du chatter
                   
                    //Interface
                    labelAlias.Text = "Ton alias est : " + chatter.getAlias();
                    labelAlias.Show();                    
                    Text = "Enjoy " + chatter.getAlias() + " !";
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
                try
                {
                    //Client
                    clientGT.createTopic(textBoxNomSalon.Text);
                    String[] topics = listTopic(clientGT.listTopics());
                    //Interface
                    labelSalonCréer.Text = "Votre salon " + textBoxNomSalon.Text + " a été créer avec succès !";
                    labelSalonCréer.Show();
                    comboBox1.Items.Clear();
                    foreach(String topic in topics)
                    {
                        comboBox1.Items.Add(topic);
                    }
                    comboBox1.Text = topics[topics.Count() - 1];
                }
                catch(TopicExistsException)
                {
                    labelSalonCréer.Text = "Le salon nommé " + textBoxNomSalon.Text + " existe déjà!";
                    labelSalonCréer.Show();
                }
            }

        }


  

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void buttonAccéderSalons_Click(object sender, EventArgs e) // A MODIFIER
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
                    IChatroom iChatRoom = clientGT.joinTopic(comboBox1.Text); 
                    iChatRoom.join(chatter); 
                    ((ClientChatRoom)iChatRoom).room = new RoomTab(this,iChatRoom); 
                    iChatRoom.post(" s'est connecté", chatter); 
                }
                 else
                {
                    tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
                    MessageBox.Show("Merci de lancer le serveur !", "Aucun server lancé");
                    labelStartServeur.Text = "Merci de lancer le serveur !";
                }
            }
        }        

        private void labelAlias_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
          
            String[] topics = listTopic(clientGT.listTopics());
            //Interface
           
            comboBox1.Items.Clear();
            foreach (String topic in topics)
            {
                comboBox1.Items.Add(topic);
            }
            comboBox1.Text = topics[topics.Count() - 1];
        }


        private void textBoxAlias_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNomSalon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
