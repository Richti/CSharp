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
        private string user;

        public string MyProperty
        {
            get { return user; }
            set { user = value; }
        }

        public InfoUser()
        {
            InitializeComponent();
        }

        private void InfoUser_Load(object sender, EventArgs e)
        {
            labelUser.Text = "Welcome : " + MyProperty;
            Text = "Coucou " + MyProperty;
        }

        private void labelUser_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
