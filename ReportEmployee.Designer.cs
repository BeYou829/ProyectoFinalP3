namespace ProyectoFinalP3
{
    partial class ReportEmployee
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
            label1 = new Label();
            dg_Employees = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dg_Employees).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(296, 31);
            label1.Name = "label1";
            label1.Size = new Size(301, 36);
            label1.TabIndex = 0;
            label1.Text = "Report of Employees";
            // 
            // dg_Employees
            // 
            dg_Employees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_Employees.Location = new Point(12, 137);
            dg_Employees.Name = "dg_Employees";
            dg_Employees.Size = new Size(879, 393);
            dg_Employees.TabIndex = 1;
            dg_Employees.CellContentClick += dg_Employees_CellContentClick;
            // 
            // ReportEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 542);
            Controls.Add(dg_Employees);
            Controls.Add(label1);
            Name = "ReportEmployee";
            Text = "ReportEmployee";
            Load += ReportEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)dg_Employees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dg_Employees;
    }
}