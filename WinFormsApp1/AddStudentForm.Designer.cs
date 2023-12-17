namespace WinFormsApp1
{
    partial class AddStudentForm
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
            studentName = new TextBox();
            studentID = new TextBox();
            addStudent = new Button();
            level = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // studentName
            // 
            studentName.Location = new Point(114, 56);
            studentName.Name = "studentName";
            studentName.Size = new Size(138, 23);
            studentName.TabIndex = 0;
            // 
            // studentID
            // 
            studentID.Location = new Point(114, 105);
            studentID.Name = "studentID";
            studentID.Size = new Size(138, 23);
            studentID.TabIndex = 1;
            // 
            // addStudent
            // 
            addStudent.Location = new Point(137, 204);
            addStudent.Name = "addStudent";
            addStudent.Size = new Size(90, 31);
            addStudent.TabIndex = 2;
            addStudent.Text = "add student";
            addStudent.UseVisualStyleBackColor = true;
            addStudent.Click += addStudent_Click;
            // 
            // level
            // 
            level.Location = new Point(114, 156);
            level.Name = "level";
            level.Size = new Size(138, 23);
            level.TabIndex = 3;
            level.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 159);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 4;
            label1.Text = "Level";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 105);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 5;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 59);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Name";
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 280);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(level);
            Controls.Add(addStudent);
            Controls.Add(studentID);
            Controls.Add(studentName);
            Name = "AddStudentForm";
            Text = "AddStudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox studentName;
        private TextBox studentID;
        private Button addStudent;
        private TextBox level;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}