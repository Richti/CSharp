using Chat;
using Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormN 
{
    public class RoomTab : TabPage
    {
        private InfoUser infoUser;
        public IChatroom iChatRoom {get; set; }

        private Button buttonQuitter = new Button();
        private TextBox textBoxConv = new TextBox();
        private Button buttonEnvoyer = new Button();
        private RichTextBox richTextBoxMsg = new RichTextBox();

        public RoomTab(InfoUser infoUser,IChatroom iChatRoom)
        {
            this.infoUser = infoUser;
            this.iChatRoom = iChatRoom;
            initTab();
            initButtonQuitter();
            initTextBox();
            initButtonEnvoyer();
            initRichTextBox();

            Controls.Add(buttonQuitter);
            Controls.Add(textBoxConv);
            Controls.Add(buttonEnvoyer);
            Controls.Add(richTextBoxMsg);

          
        }

        public TextBox getTextBoxConv() { return textBoxConv; }

        public void setTextBox(String msg)
        {
            if (textBoxConv.InvokeRequired)
            {
                dSetTexBox d = new dSetTexBox(setTextBox);
                Invoke(d, new object[] { msg });

            }
            else
            {
                textBoxConv.Text = msg;
                textBoxConv.SelectionStart = textBoxConv.TextLength;
                textBoxConv.ScrollToCaret();
            }

        }
        delegate void dSetTexBox(string msg);

        private void initRichTextBox()
        {
            richTextBoxMsg.Location = new System.Drawing.Point(27, 206);
            richTextBoxMsg.Margin = new Padding(2);
            richTextBoxMsg.Name = "richTextBoxMsg";
            richTextBoxMsg.Size = new System.Drawing.Size(300, 39);
            richTextBoxMsg.TabIndex = 4;
            richTextBoxMsg.Text = "";
            richTextBoxMsg.KeyDown += new KeyEventHandler(richTextBoxMsg_KeyDown);
        }

        private void initButtonEnvoyer()
        {
            buttonEnvoyer.Location = new System.Drawing.Point(135, 248);
            buttonEnvoyer.Margin = new System.Windows.Forms.Padding(2);
            buttonEnvoyer.Name = "buttonEnvoyer";
            buttonEnvoyer.Size = new System.Drawing.Size(76, 25);
            buttonEnvoyer.TabIndex = 5;
            buttonEnvoyer.Text = "Envoyer";
            buttonEnvoyer.UseVisualStyleBackColor = true;
            buttonEnvoyer.Click += new System.EventHandler(this.buttonEnvoyer_Click);
        }

        private void initTextBox()
        {
            textBoxConv.BackColor = System.Drawing.Color.White;
            textBoxConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBoxConv.Location = new System.Drawing.Point(27, 17);
            textBoxConv.Margin = new System.Windows.Forms.Padding(2);
            textBoxConv.Multiline = true;
            textBoxConv.Name = "textBoxConv";
            textBoxConv.ReadOnly = true;
            textBoxConv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBoxConv.Size = new System.Drawing.Size(300, 173);
            textBoxConv.TabIndex = 6;
        }



        private void initTab()
        {
            infoUser.tabControl1.TabPages.Insert(2, this);
            Text = "Salon : " + infoUser.comboBox1.Text;
            Name = infoUser.comboBox1.Text;
            infoUser.tabControl1.SelectedTab = infoUser.tabControl1.TabPages[infoUser.comboBox1.Text];
            SuspendLayout();
            BackColor = System.Drawing.Color.LightSalmon;
            Location = new System.Drawing.Point(4, 25);
            Margin = new Padding(2);
            Padding = new Padding(2);
            Size = new System.Drawing.Size(349, 287);
            TabIndex = 2;
            ResumeLayout(false);
            PerformLayout();
        }


        private void initButtonQuitter()
        {
            buttonQuitter.Location = new System.Drawing.Point(27, 248);
            buttonQuitter.Margin = new System.Windows.Forms.Padding(2);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new System.Drawing.Size(71, 24);
            buttonQuitter.TabIndex = 7;
            buttonQuitter.Text = "Quitter";
            buttonQuitter.UseVisualStyleBackColor = true;
            buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
        }


        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            iChatRoom.quit(((ClientChatRoom)iChatRoom).chatter);
            infoUser.tabControl1.TabPages.Remove(this);
            infoUser.tabControl1.SelectedTab = infoUser.tabControl1.TabPages["tabPage2"];
            infoUser.rooms.Remove(this);
        }

        private void buttonEnvoyer_Click(object sender, EventArgs e)
        {           
            if (richTextBoxMsg.Text != "" && richTextBoxMsg.Text != "\n")
            {
                iChatRoom.post(richTextBoxMsg.Text, ((ClientChatRoom)iChatRoom).chatter);
            }
            richTextBoxMsg.Clear();
            richTextBoxMsg.Focus();
        }

        private void richTextBoxMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonEnvoyer_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
