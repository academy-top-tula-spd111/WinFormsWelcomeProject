namespace WinFormsWelcomeProject
{
    public partial class Form1 : Form
    {
        public string Name { set; get; }
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            Name = "Bob";
            form2 = new Form2(Name);
            form2.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            form2.Close();
        }
    }
}