namespace tabladeMu
{
    public partial class Form1 : Form
    {
       // int a, b, c;
        public Form1()
        {
            InitializeComponent();
        //    a = Int32.Parse(txtistem.Text);
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            //int a,b,c;
            // a = 5;
            // b=int.Parse(textBox1.Text);
            // c = a + b;
            //prueba    txtistem.Text=c.ToString();
         int num=0;

            num = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i < 12; i++)
            {
                listBox1.Items.Add(num + "*" + i +"\n= "+num*i);
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
            //listBox1.Items="";
        }
    }
}