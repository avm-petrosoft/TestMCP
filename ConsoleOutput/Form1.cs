using System.Diagnostics;

namespace ConsoleOutput
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Hello, World!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("button 2 clicked");
        }
    }
}
