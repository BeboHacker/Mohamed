namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void login_Click(object sender, EventArgs e)
        {
            var db = new Db();
            db.Database.EnsureCreated();    
            var user = db.employees.FirstOrDefault(x => x.username == userName.Text && x.password == password.Text);

            if (user != null ) {
                MessageBox.Show($@"Welcome {user.name}");
                Form subjectFrom = new SubjectForm();
                subjectFrom.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Wrong one ");
            }
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            Form signupForm = new SignupForm();
            signupForm.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
