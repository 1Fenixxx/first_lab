using System.Windows.Forms;

namespace HelloWorldWPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HelloWorldButton.Click += HelloWorldButton_Click;
        }

        private void HelloWorldButton_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("HELLO WORLD");
        }
    }
}
