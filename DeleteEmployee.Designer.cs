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
            ((System.ComponentModel.ISupportInitialize)dg_Employees).BeginInit();
            SuspendLayout();
            // 
            // dg_Employees
            // 
            dg_Employees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_Employees.Location = new Point(12, 55);
            dg_Employees.Name = "dg_Employees";
            dg_Employees.Size = new Size(481, 383);
            dg_Employees.TabIndex = 0;
            dg_Employees.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Deletebtn
            // 
            Deletebtn.Location = new Point(598, 177);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(75, 23);
            Deletebtn.TabIndex = 1;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // DeleteEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Deletebtn);
            Controls.Add(dg_Employees);
            Name = "DeleteEmployee";
            Text = "DeleteEmployee";
            Load += DeleteEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)dg_Employees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dg_Employees;
        private Button Deletebtn;
    }
}