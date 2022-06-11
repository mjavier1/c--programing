using System.Text;
using System.IO;

namespace fileread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            string text = File.ReadAllText(@"C:\Users\mjagu\OneDrive\Documentos\easy.txt", Encoding.UTF8) ;
            
            string[] lines = text.Split("\n");
            textBox1.Text = text;
            comboBox1.Items.Clear();

            foreach (String line in lines)
            {
                // MessageBox.Show (line);
                comboBox1.Items.Add(line);

               
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }
    }
}