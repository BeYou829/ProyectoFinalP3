namespace ProyectoFinalP3
{
    partial class AddEmployee
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
            titleadd = new Label();
            fname = new Label();
            lname = new Label();
            sex = new Label();
            SuspendLayout();
            // 
            // titleadd
            // 
            titleadd.AutoSize = true;
            titleadd.Location = new Point(335, 23);
            titleadd.Name = "titleadd";
            titleadd.Size = new Size(110, 15);
            titleadd.TabIndex = 0;
            titleadd.Text = "Adding a Employee";
            // 
            // fname
            // 
            fname.AutoSize = true;
            fname.Location = new Point(44, 78);
            fname.Name = "fname";
            fname.Size = new Size(64, 15);
            fname.TabIndex = 1;
            fname.Text = "First Name";
            // 
            // lname
            // 
            lname.AutoSize = true;
            lname.Location = new Point(44, 107);
            lname.Name = "lname";
            lname.Size = new Size(63, 15);
            lname.TabIndex = 2;
            lname.Text = "Last Name";
            // 
            // sex
            // 
            sex.AutoSize = true;
            sex.Location = new Point(44, 135);
            sex.Name = "sex";
            sex.Size = new Size(25, 15);
            sex.TabIndex = 3;
            sex.Text = "Sex";
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sex);
            Controls.Add(lname);
            Controls.Add(fname);
            Controls.Add(titleadd);
            Name = "AddEmployee";
            Text = "AddEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleadd;
        private Label fname;
        private Label lname;
        private Label sex;
    }
}