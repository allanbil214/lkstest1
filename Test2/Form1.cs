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
    public partial class Form1 : Form
    {
        public int role;
        public Form1()
        {
            InitializeComponent();
        }
        void showForm()
        {
            formMain main = new formMain(this);
            main.Show();
            this.Visible = false;
        }
        void auth()
        {
            using (squekEnt sqlData = new squekEnt())
            {
                var counting = sqlData.Karyawans.Count(i => i.Username == textBox1.Text && i.Password == textBox2.Text);
                if (counting == 1)
                {
                    var getinfo = sqlData.Karyawans.FirstOrDefault(i => i.Username == textBox1.Text);
                    role = getinfo.Role;
                    showForm();
                }
                else
                {
                    MessageBox.Show("Salah");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            auth();
        }
    }
}
