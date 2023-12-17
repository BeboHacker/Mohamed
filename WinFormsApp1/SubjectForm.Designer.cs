namespace WinFormsApp1
{
    partial class SubjectForm
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
            subjectsTable = new DataGridView();
            subject = new DataGridViewTextBoxColumn();
            gpa = new DataGridViewTextBoxColumn();
            weight = new DataGridViewTextBoxColumn();
            studentId = new TextBox();
            search = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            studentName = new DataGridViewTextBoxColumn();
            studentIdData = new DataGridViewTextBoxColumn();
            age = new DataGridViewTextBoxColumn();
            update = new Button();
            addStudent = new Button();
            ((System.ComponentModel.ISupportInitialize)subjectsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // subjectsTable
            // 
            subjectsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            subjectsTable.Columns.AddRange(new DataGridViewColumn[] { subject, gpa, weight });
            subjectsTable.Location = new Point(443, 64);
            subjectsTable.Name = "subjectsTable";
            subjectsTable.Size = new Size(345, 303);
            subjectsTable.TabIndex = 0;
            subjectsTable.CellContentClick += subjectsTable_CellContentClick;
            // 
            // subject
            // 
            subject.HeaderText = "subject";
            subject.Name = "subject";
            // 
            // gpa
            // 
            gpa.HeaderText = "gpa";
            gpa.Name = "gpa";
            // 
            // weight
            // 
            weight.HeaderText = "weight";
            weight.Name = "weight";
            // 
            // studentId
            // 
            studentId.Location = new Point(465, 26);
            studentId.Name = "studentId";
            studentId.Size = new Size(206, 23);
            studentId.TabIndex = 1;
            // 
            // search
            // 
            search.Location = new Point(677, 21);
            search.Name = "search";
            search.Size = new Size(115, 30);
            search.TabIndex = 2;
            search.Text = "search";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(399, 34);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "student Id";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { studentName, studentIdData, age });
            dataGridView1.Location = new Point(12, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(345, 303);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // studentName
            // 
            studentName.HeaderText = "Name";
            studentName.Name = "studentName";
            // 
            // studentIdData
            // 
            studentIdData.HeaderText = "ID";
            studentIdData.Name = "studentIdData";
            // 
            // age
            // 
            age.HeaderText = "age";
            age.Name = "age";
            // 
            // update
            // 
            update.Location = new Point(653, 382);
            update.Name = "update";
            update.Size = new Size(115, 30);
            update.TabIndex = 5;
            update.Text = "update values";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // addStudent
            // 
            addStudent.Location = new Point(12, 382);
            addStudent.Name = "addStudent";
            addStudent.Size = new Size(115, 30);
            addStudent.TabIndex = 6;
            addStudent.Text = "add student";
            addStudent.UseVisualStyleBackColor = true;
            addStudent.Click += addStudent_Click;
            // 
            // SubjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addStudent);
            Controls.Add(update);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(search);
            Controls.Add(studentId);
            Controls.Add(subjectsTable);
            Name = "SubjectForm";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)subjectsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView subjectsTable;
        private TextBox studentId;
        private Button search;
        private Label label1;
        private DataGridView dataGridView1;
        private Button update;
        private Button addStudent;
        private DataGridViewTextBoxColumn subject;
        private DataGridViewTextBoxColumn gpa;
        private DataGridViewTextBoxColumn weight;
        private DataGridViewTextBoxColumn studentName;
        private DataGridViewTextBoxColumn studentIdData;
        private DataGridViewTextBoxColumn age;
    }
}