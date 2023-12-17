using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WinFormsApp1
{
    internal class Db : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = DataBase.db");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Employee> employees { get; set; }
        public DbSet<Subject> subjects { get; set; }
        public DbSet<Student> students { get; set; }
    }
    public record Employee
    {
        [Key]
        public string username { get; set; }
        public string name { get; set; }
        public string password { get; set; }
 
    }
    public record Student
    {
        [Key]
        public string ID { get; set; }

        public string name { get; set; }
        public int age { get; set; }

    }
    public record Subject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string student_id { get; set; }
        public string name { get; set; }
        public int weight { get; set; }
        public float gpa { get; set; }

    }

}
