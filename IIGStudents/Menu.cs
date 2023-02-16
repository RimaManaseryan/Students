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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void to_register_MouseHover(object sender, EventArgs e)
        {
            to_register.BackColor = Color.LightBlue;
        }

        private void to_register_Click(object sender, EventArgs e)
        {
            Hide();
            new Register().Show();
        }

        private void to_studentsList_MouseHover(object sender, EventArgs e)
        {
            to_studentsList.BackColor = Color.LightBlue;
        }

        private void to_studentsList_Click(object sender, EventArgs e)
        {
            Hide();
            new AllStudents().Show();
        }
    }
}
