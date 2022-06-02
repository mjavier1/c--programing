namespace CustomerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            foreach (String customer in comboBox1.Items)
            {
                String msg = "Hi" + customer;
                MessageBox.Show(msg);

            }
        }
    }
}