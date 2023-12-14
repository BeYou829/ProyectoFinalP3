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
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            modoOscuroToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Maintitle
            // 
            Maintitle.AutoSize = true;
            Maintitle.Font = new Font("Broadway", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Maintitle.Location = new Point(320, 42);
            Maintitle.Name = "Maintitle";
            Maintitle.Size = new Size(449, 40);
            Maintitle.TabIndex = 0;
            Maintitle.Text = "Human Resources APP";
            Maintitle.Click += Maintitle_Click;
            // 
            // AddEmployee
            // 
            AddEmployee.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddEmployee.Location = new Point(77, 146);
            AddEmployee.Name = "AddEmployee";
            AddEmployee.Size = new Size(105, 45);
            AddEmployee.TabIndex = 2;
            AddEmployee.Text = "Create";
            AddEmployee.UseVisualStyleBackColor = true;
            AddEmployee.Click += AddEmployee_Click;
            // 
            // ReportEmployee
            // 
            ReportEmployee.Font = new Font("Times New Roman", 14.25F);
            ReportEmployee.Location = new Point(77, 224);
            ReportEmployee.Name = "ReportEmployee";
            ReportEmployee.Size = new Size(105, 46);
            ReportEmployee.TabIndex = 3;
            ReportEmployee.Text = "Report";
            ReportEmployee.UseVisualStyleBackColor = true;
            ReportEmployee.Click += ReportEmployee_Click;
            // 
            // UpdateEmployee
            // 
            UpdateEmployee.Font = new Font("Times New Roman", 14.25F);
            UpdateEmployee.Location = new Point(77, 306);
            UpdateEmployee.Name = "UpdateEmployee";
            UpdateEmployee.Size = new Size(105, 49);
            UpdateEmployee.TabIndex = 4;
            UpdateEmployee.Text = "Update";
            UpdateEmployee.UseVisualStyleBackColor = true;
            UpdateEmployee.Click += UpdateEmployee_Click;
            // 
            // DeleteEmployee
            // 
            DeleteEmployee.Font = new Font("Times New Roman", 14.25F);
            DeleteEmployee.Location = new Point(77, 387);
            DeleteEmployee.Name = "DeleteEmployee";
            DeleteEmployee.Size = new Size(105, 48);
            DeleteEmployee.TabIndex = 5;
            DeleteEmployee.Text = "Delete";
            DeleteEmployee.UseVisualStyleBackColor = true;
            DeleteEmployee.Click += DeleteEmployee_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hr_image;
            pictureBox1.Location = new Point(386, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(669, 416);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1067, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { modoOscuroToolStripMenuItem });
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(48, 20);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // modoOscuroToolStripMenuItem
            // 
            modoOscuroToolStripMenuItem.Name = "modoOscuroToolStripMenuItem";
            modoOscuroToolStripMenuItem.Size = new Size(180, 22);
            modoOscuroToolStripMenuItem.Text = "Modo Oscuro";
            modoOscuroToolStripMenuItem.Click += modoOscuroToolStripMenuItem_Click;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 571);
            Controls.Add(pictureBox1);
            Controls.Add(DeleteEmployee);
            Controls.Add(UpdateEmployee);
            Controls.Add(ReportEmployee);
            Controls.Add(AddEmployee);
            Controls.Add(Maintitle);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Mainform";
            Text = "CRUD HR";
            Load += Mainform_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Maintitle;
        private Button AddEmployee;
        private Button ReportEmployee;
        private Button UpdateEmployee;
        private Button DeleteEmployee;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem modoOscuroToolStripMenuItem;
    }
}
