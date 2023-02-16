namespace IIGStudents
{
    partial class Register
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
            this.firstname = new System.Windows.Forms.Label();
            this.fname_box = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.Label();
            this.lname_box = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.Label();
            this.age_box = new System.Windows.Forms.TextBox();
            this.course = new System.Windows.Forms.Label();
            this.course_box = new System.Windows.Forms.ComboBox();
            this.save_box = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.Location = new System.Drawing.Point(13, 28);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(86, 20);
            this.firstname.TabIndex = 0;
            this.firstname.Text = "First Name";
            // 
            // fname_box
            // 
            this.fname_box.Location = new System.Drawing.Point(106, 28);
            this.fname_box.Name = "fname_box";
            this.fname_box.Size = new System.Drawing.Size(100, 26);
            this.fname_box.TabIndex = 1;
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Location = new System.Drawing.Point(13, 77);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(86, 20);
            this.lastname.TabIndex = 2;
            this.lastname.Text = "Last Name";
            // 
            // lname_box
            // 
            this.lname_box.Location = new System.Drawing.Point(125, 74);
            this.lname_box.Name = "lname_box";
            this.lname_box.Size = new System.Drawing.Size(148, 26);
            this.lname_box.TabIndex = 3;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(13, 124);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(38, 20);
            this.age.TabIndex = 4;
            this.age.Text = "Age";
            // 
            // age_box
            // 
            this.age_box.Location = new System.Drawing.Point(76, 118);
            this.age_box.Name = "age_box";
            this.age_box.Size = new System.Drawing.Size(63, 26);
            this.age_box.TabIndex = 5;
            // 
            // course
            // 
            this.course.AutoSize = true;
            this.course.Location = new System.Drawing.Point(12, 169);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(60, 20);
            this.course.TabIndex = 6;
            this.course.Text = "Course";
            // 
            // course_box
            // 
            this.course_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.course_box.FormattingEnabled = true;
            this.course_box.Items.AddRange(new object[] {
            "CSharp",
            "HTML",
            "JS",
            "Python"});
            this.course_box.Location = new System.Drawing.Point(106, 166);
            this.course_box.Name = "course_box";
            this.course_box.Size = new System.Drawing.Size(121, 28);
            this.course_box.TabIndex = 8;
            // 
            // save_box
            // 
            this.save_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_box.Location = new System.Drawing.Point(16, 242);
            this.save_box.Name = "save_box";
            this.save_box.Size = new System.Drawing.Size(102, 33);
            this.save_box.TabIndex = 9;
            this.save_box.Text = "Register";
            this.save_box.UseVisualStyleBackColor = true;
            this.save_box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.save_box_MouseClick);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 555);
            this.Controls.Add(this.save_box);
            this.Controls.Add(this.course_box);
            this.Controls.Add(this.course);
            this.Controls.Add(this.age_box);
            this.Controls.Add(this.age);
            this.Controls.Add(this.lname_box);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.fname_box);
            this.Controls.Add(this.firstname);
            this.MaximizeBox = false;
            this.Name = "Register";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.TextBox fname_box;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.TextBox lname_box;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.TextBox age_box;
        private System.Windows.Forms.Label course;
        private System.Windows.Forms.ComboBox course_box;
        private System.Windows.Forms.Button save_box;
    }
}

