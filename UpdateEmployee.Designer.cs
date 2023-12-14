namespace ProyectoFinalP3
{
    partial class UpdateEmployee
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
            clearbtn = new Button();
            updateEmployeebtn = new Button();
            fname = new Label();
            lname = new Label();
            sex = new Label();
            docid = new Label();
            dob = new Label();
            email = new Label();
            phonenumber = new Label();
            altphonenumber = new Label();
            direccion = new Label();
            ciudad = new Label();
            provincia = new Label();
            rol = new Label();
            departamento = new Label();
            fnametxtb = new TextBox();
            lnametxtb = new TextBox();
            sextxtb = new TextBox();
            docidtxtb = new TextBox();
            dobtxtb = new TextBox();
            emailtxtb = new TextBox();
            phtxtb = new TextBox();
            aphtxtb = new TextBox();
            direcciontxtb = new TextBox();
            ciudadtxtb = new TextBox();
            provinciatxtb = new TextBox();
            roltxtb = new TextBox();
            depttxtb = new TextBox();
            dg_Employees = new DataGridView();
            getInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)dg_Employees).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(420, 20);
            label1.Name = "label1";
            label1.Size = new Size(257, 36);
            label1.TabIndex = 0;
            label1.Text = "Update Employee";
            label1.Click += label1_Click;
            // 
            // clearbtn
            // 
            clearbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            clearbtn.Location = new Point(486, 347);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(75, 23);
            clearbtn.TabIndex = 56;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = true;
            clearbtn.Click += clearbtn_Click;
            // 
            // updateEmployeebtn
            // 
            updateEmployeebtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            updateEmployeebtn.Location = new Point(567, 347);
            updateEmployeebtn.Name = "updateEmployeebtn";
            updateEmployeebtn.Size = new Size(75, 23);
            updateEmployeebtn.TabIndex = 55;
            updateEmployeebtn.Text = "Save";
            updateEmployeebtn.UseVisualStyleBackColor = true;
            updateEmployeebtn.Click += updateEmployeebtn_Click;
            // 
            // fname
            // 
            fname.AutoSize = true;
            fname.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            fname.Location = new Point(25, 119);
            fname.Name = "fname";
            fname.Size = new Size(67, 15);
            fname.TabIndex = 29;
            fname.Text = "First Name";
            // 
            // lname
            // 
            lname.AutoSize = true;
            lname.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lname.Location = new Point(25, 160);
            lname.Name = "lname";
            lname.Size = new Size(65, 15);
            lname.TabIndex = 30;
            lname.Text = "Last Name";
            // 
            // sex
            // 
            sex.AutoSize = true;
            sex.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            sex.Location = new Point(25, 199);
            sex.Name = "sex";
            sex.Size = new Size(28, 15);
            sex.TabIndex = 31;
            sex.Text = "Sex";
            // 
            // docid
            // 
            docid.AutoSize = true;
            docid.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            docid.Location = new Point(201, 119);
            docid.Name = "docid";
            docid.Size = new Size(82, 15);
            docid.TabIndex = 32;
            docid.Text = "Document ID";
            // 
            // dob
            // 
            dob.AutoSize = true;
            dob.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dob.Location = new Point(201, 160);
            dob.Name = "dob";
            dob.Size = new Size(33, 15);
            dob.TabIndex = 33;
            dob.Text = "DOB";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            email.Location = new Point(201, 199);
            email.Name = "email";
            email.Size = new Size(41, 15);
            email.TabIndex = 34;
            email.Text = "E-mail";
            // 
            // phonenumber
            // 
            phonenumber.AutoSize = true;
            phonenumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            phonenumber.Location = new Point(390, 119);
            phonenumber.Name = "phonenumber";
            phonenumber.Size = new Size(91, 15);
            phonenumber.TabIndex = 35;
            phonenumber.Text = "Phone Number";
            // 
            // altphonenumber
            // 
            altphonenumber.AutoSize = true;
            altphonenumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            altphonenumber.Location = new Point(390, 160);
            altphonenumber.Name = "altphonenumber";
            altphonenumber.Size = new Size(113, 15);
            altphonenumber.TabIndex = 36;
            altphonenumber.Text = "Alt. Phone Number";
            // 
            // direccion
            // 
            direccion.AutoSize = true;
            direccion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            direccion.Location = new Point(25, 253);
            direccion.Name = "direccion";
            direccion.Size = new Size(60, 15);
            direccion.TabIndex = 37;
            direccion.Text = "Direccion";
            // 
            // ciudad
            // 
            ciudad.AutoSize = true;
            ciudad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ciudad.Location = new Point(25, 288);
            ciudad.Name = "ciudad";
            ciudad.Size = new Size(44, 15);
            ciudad.TabIndex = 38;
            ciudad.Text = "Ciudad";
            // 
            // provincia
            // 
            provincia.AutoSize = true;
            provincia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            provincia.Location = new Point(233, 288);
            provincia.Name = "provincia";
            provincia.Size = new Size(58, 15);
            provincia.TabIndex = 39;
            provincia.Text = "Provincia";
            // 
            // rol
            // 
            rol.AutoSize = true;
            rol.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rol.Location = new Point(25, 350);
            rol.Name = "rol";
            rol.Size = new Size(25, 15);
            rol.TabIndex = 40;
            rol.Text = "Rol";
            // 
            // departamento
            // 
            departamento.AutoSize = true;
            departamento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            departamento.Location = new Point(233, 350);
            departamento.Name = "departamento";
            departamento.Size = new Size(89, 15);
            departamento.TabIndex = 41;
            departamento.Text = "Departamento";
            // 
            // fnametxtb
            // 
            fnametxtb.Location = new Point(95, 116);
            fnametxtb.Name = "fnametxtb";
            fnametxtb.Size = new Size(100, 23);
            fnametxtb.TabIndex = 42;
            // 
            // lnametxtb
            // 
            lnametxtb.Location = new Point(95, 157);
            lnametxtb.Name = "lnametxtb";
            lnametxtb.Size = new Size(100, 23);
            lnametxtb.TabIndex = 43;
            // 
            // sextxtb
            // 
            sextxtb.Location = new Point(95, 196);
            sextxtb.Name = "sextxtb";
            sextxtb.Size = new Size(100, 23);
            sextxtb.TabIndex = 44;
            // 
            // docidtxtb
            // 
            docidtxtb.Location = new Point(284, 116);
            docidtxtb.Name = "docidtxtb";
            docidtxtb.Size = new Size(100, 23);
            docidtxtb.TabIndex = 45;
            // 
            // dobtxtb
            // 
            dobtxtb.Location = new Point(284, 157);
            dobtxtb.Name = "dobtxtb";
            dobtxtb.Size = new Size(100, 23);
            dobtxtb.TabIndex = 46;
            // 
            // emailtxtb
            // 
            emailtxtb.Location = new Point(284, 196);
            emailtxtb.Name = "emailtxtb";
            emailtxtb.Size = new Size(194, 23);
            emailtxtb.TabIndex = 47;
            // 
            // phtxtb
            // 
            phtxtb.Location = new Point(505, 116);
            phtxtb.Name = "phtxtb";
            phtxtb.Size = new Size(100, 23);
            phtxtb.TabIndex = 48;
            // 
            // aphtxtb
            // 
            aphtxtb.Location = new Point(505, 157);
            aphtxtb.Name = "aphtxtb";
            aphtxtb.Size = new Size(100, 23);
            aphtxtb.TabIndex = 49;
            // 
            // direcciontxtb
            // 
            direcciontxtb.Location = new Point(95, 250);
            direcciontxtb.Name = "direcciontxtb";
            direcciontxtb.Size = new Size(466, 23);
            direcciontxtb.TabIndex = 50;
            // 
            // ciudadtxtb
            // 
            ciudadtxtb.Location = new Point(95, 285);
            ciudadtxtb.Name = "ciudadtxtb";
            ciudadtxtb.Size = new Size(100, 23);
            ciudadtxtb.TabIndex = 51;
            // 
            // provinciatxtb
            // 
            provinciatxtb.Location = new Point(295, 285);
            provinciatxtb.Name = "provinciatxtb";
            provinciatxtb.Size = new Size(160, 23);
            provinciatxtb.TabIndex = 52;
            // 
            // roltxtb
            // 
            roltxtb.Location = new Point(95, 347);
            roltxtb.Name = "roltxtb";
            roltxtb.Size = new Size(100, 23);
            roltxtb.TabIndex = 53;
            // 
            // depttxtb
            // 
            depttxtb.Location = new Point(326, 347);
            depttxtb.Name = "depttxtb";
            depttxtb.Size = new Size(129, 23);
            depttxtb.TabIndex = 54;
            // 
            // dg_Employees
            // 
            dg_Employees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_Employees.Location = new Point(655, 109);
            dg_Employees.Name = "dg_Employees";
            dg_Employees.Size = new Size(412, 279);
            dg_Employees.TabIndex = 57;
            dg_Employees.CellContentClick += dg_Employees_CellContentClick;
            // 
            // getInfo
            // 
            getInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            getInfo.Location = new Point(530, 306);
            getInfo.Name = "getInfo";
            getInfo.Size = new Size(75, 23);
            getInfo.TabIndex = 58;
            getInfo.Text = "GetInfo";
            getInfo.UseVisualStyleBackColor = true;
            getInfo.Click += getInfo_Click;
            // 
            // UpdateEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 511);
            Controls.Add(getInfo);
            Controls.Add(dg_Employees);
            Controls.Add(clearbtn);
            Controls.Add(updateEmployeebtn);
            Controls.Add(depttxtb);
            Controls.Add(roltxtb);
            Controls.Add(provinciatxtb);
            Controls.Add(ciudadtxtb);
            Controls.Add(direcciontxtb);
            Controls.Add(aphtxtb);
            Controls.Add(phtxtb);
            Controls.Add(emailtxtb);
            Controls.Add(dobtxtb);
            Controls.Add(docidtxtb);
            Controls.Add(sextxtb);
            Controls.Add(lnametxtb);
            Controls.Add(fnametxtb);
            Controls.Add(departamento);
            Controls.Add(rol);
            Controls.Add(provincia);
            Controls.Add(ciudad);
            Controls.Add(direccion);
            Controls.Add(altphonenumber);
            Controls.Add(phonenumber);
            Controls.Add(email);
            Controls.Add(dob);
            Controls.Add(docid);
            Controls.Add(sex);
            Controls.Add(lname);
            Controls.Add(fname);
            Controls.Add(label1);
            Name = "UpdateEmployee";
            Text = "UpdateEmployee";
            Load += UpdateEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)dg_Employees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button clearbtn;
        private Button updateEmployeebtn;
        private Label fname;
        private Label lname;
        private Label sex;
        private Label docid;
        private Label dob;
        private Label email;
        private Label phonenumber;
        private Label altphonenumber;
        private Label direccion;
        private Label ciudad;
        private Label provincia;
        private Label rol;
        private Label departamento;
        private TextBox fnametxtb;
        private TextBox lnametxtb;
        private TextBox sextxtb;
        private TextBox docidtxtb;
        private TextBox dobtxtb;
        private TextBox emailtxtb;
        private TextBox phtxtb;
        private TextBox aphtxtb;
        private TextBox direcciontxtb;
        private TextBox ciudadtxtb;
        private TextBox provinciatxtb;
        private TextBox roltxtb;
        private TextBox depttxtb;
        private DataGridView dg_Employees;
        private Button getInfo;
    }
}