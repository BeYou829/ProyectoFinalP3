namespace ProyectoFinalP3
{
    partial class Mainform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Maintitle = new Label();
            AddEmployee = new Button();
            ReportEmployee = new Button();
            UpdateEmployee = new Button();
            DeleteEmployee = new Button();
            SuspendLayout();
            // 
            // Maintitle
            // 
            Maintitle.AutoSize = true;
            Maintitle.Location = new Point(459, 25);
            Maintitle.Name = "Maintitle";
            Maintitle.Size = new Size(128, 15);
            Maintitle.TabIndex = 0;
            Maintitle.Text = "Human Resources APP";
            // 
            // AddEmployee
            // 
            AddEmployee.Location = new Point(76, 110);
            AddEmployee.Name = "AddEmployee";
            AddEmployee.Size = new Size(75, 23);
            AddEmployee.TabIndex = 2;
            AddEmployee.Text = "Create";
            AddEmployee.UseVisualStyleBackColor = true;
            AddEmployee.Click += AddEmployee_Click;
            // 
            // ReportEmployee
            // 
            ReportEmployee.Location = new Point(76, 161);
            ReportEmployee.Name = "ReportEmployee";
            ReportEmployee.Size = new Size(75, 23);
            ReportEmployee.TabIndex = 3;
            ReportEmployee.Text = "Report";
            ReportEmployee.UseVisualStyleBackColor = true;
            ReportEmployee.Click += ReportEmployee_Click;
            // 
            // UpdateEmployee
            // 
            UpdateEmployee.Location = new Point(76, 219);
            UpdateEmployee.Name = "UpdateEmployee";
            UpdateEmployee.Size = new Size(75, 23);
            UpdateEmployee.TabIndex = 4;
            UpdateEmployee.Text = "Update";
            UpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // DeleteEmployee
            // 
            DeleteEmployee.Location = new Point(76, 279);
            DeleteEmployee.Name = "DeleteEmployee";
            DeleteEmployee.Size = new Size(75, 23);
            DeleteEmployee.TabIndex = 5;
            DeleteEmployee.Text = "Delete";
            DeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 571);
            Controls.Add(DeleteEmployee);
            Controls.Add(UpdateEmployee);
            Controls.Add(ReportEmployee);
            Controls.Add(AddEmployee);
            Controls.Add(Maintitle);
            Name = "Mainform";
            Text = "CRUD HR";
            Load += Mainform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Maintitle;
        private Button AddEmployee;
        private Button ReportEmployee;
        private Button UpdateEmployee;
        private Button DeleteEmployee;
    }
}
