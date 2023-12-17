namespace WinFormsApp1
{
    partial class SignupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            username = new TextBox();
            name = new TextBox();
            password = new TextBox();
            conf_password = new TextBox();
            signup = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            admin_password = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new Point(46, 40);
            username.Name = "username";
            username.Size = new Size(130, 23);
            username.TabIndex = 0;
            // 
            // name
            // 
            name.Location = new Point(46, 98);
            name.Name = "name";
            name.Size = new Size(130, 23);
            name.TabIndex = 1;
            // 
            // password
            // 
            password.Location = new Point(46, 154);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(130, 23);
            password.TabIndex = 2;
            // 
            // conf_password
            // 
            conf_password.Location = new Point(46, 209);
            conf_password.Name = "conf_password";
            conf_password.PasswordChar = '*';
            conf_password.Size = new Size(130, 23);
            conf_password.TabIndex = 3;
            // 
            // signup
            // 
            signup.Location = new Point(68, 321);
            signup.Name = "signup";
            signup.Size = new Size(79, 27);
            signup.TabIndex = 4;
            signup.Text = "signup";
            signup.UseVisualStyleBackColor = true;
            signup.Click += signup_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 22);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 5;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 80);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 136);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 7;
            label3.Text = "password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 191);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 8;
            label4.Text = "confirm password";
            // 
            // admin_password
            // 
            admin_password.Location = new Point(46, 262);
            admin_password.Name = "admin_password";
            admin_password.PasswordChar = '*';
            admin_password.Size = new Size(130, 23);
            admin_password.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 244);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 10;
            label5.Text = "admin password";
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 426);
            Controls.Add(label5);
            Controls.Add(admin_password);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(signup);
            Controls.Add(conf_password);
            Controls.Add(password);
            Controls.Add(name);
            Controls.Add(username);
            Name = "SignupForm";
            Text = "Sign up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private TextBox name;
        private TextBox password;
        private TextBox conf_password;
        private Button signup;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox admin_password;
        private Label label5;
    }
}