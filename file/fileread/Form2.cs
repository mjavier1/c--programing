using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fileread
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = txtname.Text;
            String cou=comboBox1.Text;

            System.IO.StreamWriter file = new StreamWriter("c:\\Users\\mjagu\\Documents\\hello.txt");
            file.WriteLine("name:" +name);
            file.WriteLine("country:" + cou);
            file.Close();

            MessageBox.Show("Save");
        }
    }
}
