using IIGStudents.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IIGStudents
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private void save_box_MouseClick(object sender, MouseEventArgs e)
        {
            using (GroupContext _context = new GroupContext())
            {
                save_box.BackColor = Color.DarkGray;
                try
                {
                    Student student = new Student
                    {
                        FirstName = fname_box.Text.ToString(),
                        LastName = lname_box.Text.ToString(),
                        Age = int.Parse(age_box.Text),
                        CourseName = course_box.Text.ToString()
                    };
                    _context.students.Add(student);
                    _context.SaveChanges();
                }
                catch(Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
            fname_box.Text = string.Empty;
            lname_box.Text = string.Empty;
            age_box.Text = string.Empty;
            course_box.Text = null;
        }
    }
}
