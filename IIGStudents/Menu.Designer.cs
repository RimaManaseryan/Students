namespace IIGStudents
{
    partial class Menu
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
            this.to_register = new System.Windows.Forms.Button();
            this.to_studentsList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // to_register
            // 
            this.to_register.Location = new System.Drawing.Point(100, 29);
            this.to_register.Name = "to_register";
            this.to_register.Size = new System.Drawing.Size(121, 46);
            this.to_register.TabIndex = 0;
            this.to_register.Text = "Register";
            this.to_register.UseVisualStyleBackColor = true;
            this.to_register.Click += new System.EventHandler(this.to_register_Click);
            this.to_register.MouseHover += new System.EventHandler(this.to_register_MouseHover);
            // 
            // to_studentsList
            // 
            this.to_studentsList.Location = new System.Drawing.Point(100, 98);
            this.to_studentsList.Name = "to_studentsList";
            this.to_studentsList.Size = new System.Drawing.Size(121, 44);
            this.to_studentsList.TabIndex = 1;
            this.to_studentsList.Text = "All Students";
            this.to_studentsList.UseVisualStyleBackColor = true;
            this.to_studentsList.Click += new System.EventHandler(this.to_studentsList_Click);
            this.to_studentsList.MouseHover += new System.EventHandler(this.to_studentsList_MouseHover);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 288);
            this.Controls.Add(this.to_studentsList);
            this.Controls.Add(this.to_register);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button to_register;
        private System.Windows.Forms.Button to_studentsList;
    }
}