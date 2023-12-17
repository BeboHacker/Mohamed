namespace WinFormsApp1
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login = new Button();
            userName = new TextBox();
            password = new TextBox();
            signUp = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // login
            // 
            login.Location = new Point(104, 171);
            login.Name = "login";
            login.Size = new Size(75, 23);
            login.TabIndex = 0;
            login.Text = "Login In";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // userName
            // 
            userName.Location = new Point(90, 55);
            userName.Name = "userName";
            userName.Size = new Size(100, 23);
            userName.TabIndex = 1;
            // 
            // password
            // 
            password.Location = new Point(90, 105);
            password.Name = "password";
            password.Size = new Size(100, 23);
            password.TabIndex = 2;
            password.PasswordChar = '*';
            // 
            // signUp
            // 
            signUp.Location = new Point(104, 213);
            signUp.Name = "signUp";
            signUp.Size = new Size(75, 23);
            signUp.TabIndex = 3;
            signUp.Text = "Sign up";
            signUp.UseVisualStyleBackColor = true;
            signUp.Click += signUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 87);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 4;
            label1.Text = "password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 37);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 5;
            label2.Text = "User Name";
            // 
            // LoginForm
            // 
            ClientSize = new Size(284, 261);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(signUp);
            Controls.Add(password);
            Controls.Add(userName);
            Controls.Add(login);
            Name = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion



        private Button login;
        private TextBox userName;
        private TextBox password;
        private Button signUp;
        private Label label1;
        private Label label2;
    }
}
