using IIGStudents.Models;
using Microsoft.EntityFrameworkCore.Internal;
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
    public partial class AllStudents : Form
    {
        public AllStudents()
        {
            InitializeComponent();
            using (GroupContext _context = new GroupContext())
            {
                foreach (Student student in _context.students)
                {
                    list_firstname.Text += student.FirstName.ToString() + " " + student.LastName.ToString() + "\n";
                }
            }
        }

        private void AllStudents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupDataSet.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.groupDataSet.students);
        }

        private void search_box_MouseClick(object sender, MouseEventArgs e)
        {
            search_box.Text = Console.ReadLine();
            if (String.IsNullOrEmpty(search_box.Text))
                list_firstname.Text = null;
        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(search_box.Text))
                list_firstname.Text = total_age.Text = label1.Text = null;
            int age_temp = 0;
            using (GroupContext _context = new GroupContext())
            {
                list_firstname.Text = null;
                foreach (Student student in _context.students.Where(s =>
                        !String.IsNullOrEmpty(search_box.Text) &&
                       s.FirstName.ToLower().StartsWith(search_box.Text.ToLower())))
                {
                    label1.Text = "Total:";
                    list_firstname.Text += student.FirstName + " " + student.LastName + "\n";
                    age_temp += student.Age;
                    total_age.Text = age_temp.ToString();
                };
            }
        }


    }
}
