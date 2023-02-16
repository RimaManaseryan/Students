namespace IIGStudents
{
    partial class AllStudents
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
            this.components = new System.ComponentModel.Container();
            this.groupDataSet = new IIGStudents.GroupDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new IIGStudents.GroupDataSetTableAdapters.studentsTableAdapter();
            this.tableAdapterManager = new IIGStudents.GroupDataSetTableAdapters.TableAdapterManager();
            this.list_firstname = new System.Windows.Forms.Label();
            this.search_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.total_age = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDataSet
            // 
            this.groupDataSet.DataSetName = "GroupDataSet";
            this.groupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.groupDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = IIGStudents.GroupDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // list_firstname
            // 
            this.list_firstname.AutoSize = true;
            this.list_firstname.Location = new System.Drawing.Point(37, 67);
            this.list_firstname.Name = "list_firstname";
            this.list_firstname.Size = new System.Drawing.Size(0, 20);
            this.list_firstname.TabIndex = 3;
            // 
            // search_box
            // 
            this.search_box.Location = new System.Drawing.Point(390, 12);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(100, 26);
            this.search_box.TabIndex = 4;
            this.search_box.Text = "Search";
            this.search_box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.search_box_MouseClick);
            this.search_box.TextChanged += new System.EventHandler(this.search_box_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total";
            // 
            // total_age
            // 
            this.total_age.AutoSize = true;
            this.total_age.Location = new System.Drawing.Point(358, 67);
            this.total_age.Name = "total_age";
            this.total_age.Size = new System.Drawing.Size(0, 20);
            this.total_age.TabIndex = 6;
            // 
            // AllStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 494);
            this.Controls.Add(this.total_age);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.list_firstname);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AllStudents";
            this.Text = "AllStudents";
            this.Load += new System.EventHandler(this.AllStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupDataSet groupDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private GroupDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private GroupDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label list_firstname;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label total_age;
    }
}