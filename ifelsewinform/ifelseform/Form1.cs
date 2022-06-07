namespace ifelseform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Convert.ToInt32
            int age = int.Parse(textBox1.Text);
            if (age <= 110)
            {
                MessageBox.Show(age.ToString());
            }
            else
            {
                MessageBox.Show("Error to old!");
            }
           
        }
    }
}