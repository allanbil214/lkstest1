using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2
{
    public partial class formMain : Form
    {
        Form1 formLogin;
        public formMain(Form1 form1)
        {
            InitializeComponent();
            this.formLogin = form1;
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            if (formLogin.role == 1)
            {
                MessageBox.Show("Full");
                button1.Visible = true;
                button2.Visible = false;
            }    
            else if (formLogin.role == 0)
            {
                MessageBox.Show("Half");
                button1.Visible = false;
                button2.Visible = true;
            }
        }
    }
}
