using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SubjectForm : Form
    {
        private string _studentID = null;
        public SubjectForm()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
            var db = new Db();
            foreach (var i in db.students.Select(x => x))
            {
                dataGridView1.Rows.Add(i.name, i.ID, i.age);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void subjectsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            var db = new Db();
            var student = db.students.FirstOrDefault((x) => x.ID == studentId.Text);
            if (student != null)
            {
                _studentID = student.ID;
                subjectsTable.Rows.Clear();
                foreach (var i in db.subjects
                    .Select((x) => x)
                    .Where((x) => x.student_id == studentId.Text)
                    )
                    subjectsTable.Rows.Add(i.name,i.gpa,i.weight);
            }
            else
            {
                MessageBox.Show("Student Id Not found");
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            var db = new Db();
            if (_studentID != null)
            {
                var toRemove = db.subjects.Where((x) => x.student_id == _studentID);
                 if (toRemove != null)
                    db.subjects.RemoveRange(toRemove);
                foreach (DataGridViewRow i in subjectsTable.Rows)
                {
                    if (i.Cells["subject"].Value == null) break;
                    var k = new Subject()
                    {
                        name = i.Cells["subject"].Value?.ToString(),
                        gpa = float.Parse(i.Cells["gpa"].Value?.ToString()),
                        student_id = _studentID,
                        weight = int.Parse(i.Cells["weight"].Value?.ToString()),

                    };
                    db.subjects.Add(k);
                }

                    
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("enter a student");
            }

        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            Form addstudent = new AddStudentForm();
            addstudent.ShowDialog();
        }
        private void addSubjet_Click (object sender, EventArgs e)
        {
            subjectsTable.Rows.Add();
        }
    }
}
