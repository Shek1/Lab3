namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float radius = Convert.ToSingle(textBox1.Text);
            float angle = Convert.ToSingle(textBox2.Text);
            MessageBox.Show("Площа сектора кола: " +Convert.ToString(Math.PI * Math.Pow(radius, 2) * angle / 360));
        }
    }
}
