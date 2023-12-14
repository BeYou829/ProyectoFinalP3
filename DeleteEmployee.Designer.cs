namespace ProyectoFinalP3
{
    partial class DeleteEmployee
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
            dg_Employees = new DataGridView();
            Deletebtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dg_Employees).BeginInit();
            SuspendLayout();
            // 
            // dg_Employees
            // 
            dg_Employees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_Employees.Location = new Point(12, 114);
            dg_Employees.Name = "dg_Employees";
            dg_Employees.Size = new Size(476, 324);
            dg_Employees.TabIndex = 0;
            dg_Employees.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Deletebtn
            // 
            Deletebtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Deletebtn.Location = new Point(593, 228);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(111, 62);
            Deletebtn.TabIndex = 1;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 20);
            label1.Name = "label1";
            label1.Size = new Size(284, 36);
            label1.TabIndex = 2;
            label1.Text = "Delete an Employee";
            // 
            // DeleteEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Deletebtn);
            Controls.Add(dg_Employees);
            Name = "DeleteEmployee";
            Text = "DeleteEmployee";
            Load += DeleteEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)dg_Employees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dg_Employees;
        private Button Deletebtn;
        private Label label1;
    }
}