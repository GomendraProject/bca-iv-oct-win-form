using bca_iv_oct.Models;
using bca_iv_oct.Providers;
using Dapper;

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

            using(var conn = DbConnectionProvider.GetDbConnection())
            {
                // Get user based on Username

                var query = @"
select * from dbo.[User] WHERE Username = @username
";
                var user = conn.QueryFirstOrDefault<User>(query, new {
                    username = username
                });

                if(user == null) {
                    MessageBox.Show("Invalid username");
                    return;
                }

                if (user.Password == password)
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
}