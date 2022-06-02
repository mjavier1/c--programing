namespace formhello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Hello message box button
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked");

        }

        private void btnmessa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txt.Text);
        }
    }
}