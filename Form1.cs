namespace bca_iv_oct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            AttachEventHandlers();
        }

        private void AttachEventHandlers()
        {
            loginBtn.Click += LoginBtn_Click;
        }

        private void LoginBtn_Click(object? sender, EventArgs e)
        {
            var username = usernameElm.Text;
            var password = passwordElm.Text;

            if(username == "abc" && password == "hola") 
            {
                // Show dashboard
                var dashboardForm = new Dashboard();
                this.Hide();
                dashboardForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Invalid username / password");
            }
        }
    }
}