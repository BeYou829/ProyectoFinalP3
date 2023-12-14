using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalP3
{
    public partial class UpdateEmployee : Form
    {
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        private void updateEmployeebtn_Click(object sender, EventArgs e)
        {


        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            dg_Employees.DataSource = Employee.ReportEmployee();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void getInfo_Click(object sender, EventArgs e)
        {
            string ID = dg_Employees.CurrentRow.Cells["ID"].Value.ToString()??"";
            string fname = dg_Employees.CurrentRow.Cells["fname"].Value.ToString() ?? "";
            string lname = dg_Employees.CurrentRow.Cells["lname"].Value.ToString() ?? "";
            string sex = dg_Employees.CurrentRow.Cells["sex"].Value.ToString() ?? "";
            string docid = dg_Employees.CurrentRow.Cells["docid"].Value.ToString() ?? "";
            string dob = dg_Employees.CurrentRow.Cells["DOB"].Value.ToString() ?? "";
            string email = dg_Employees.CurrentRow.Cells["email"].Value.ToString() ?? "";
            string phonenumber = dg_Employees.CurrentRow.Cells["phonenumber"].Value.ToString() ?? "";
            string altphonenumber = dg_Employees.CurrentRow.Cells["altphonenumber"].Value.ToString() ?? "";
            string direccion = dg_Employees.CurrentRow.Cells["direccion"].Value.ToString() ?? "";
            string ciudad= dg_Employees.CurrentRow.Cells["ciudad"].Value.ToString() ?? "";
            string provincia = dg_Employees.CurrentRow.Cells["provincia"].Value.ToString() ?? "";
            string rol = dg_Employees.CurrentRow.Cells["rol"].Value.ToString() ?? "";
            string departamento = dg_Employees.CurrentRow.Cells["departamento"].Value.ToString() ?? "";

            fnametxtb.Text = fname;
            lnametxtb.Text = lname;
            sextxtb.Text = sex;
            docidtxtb.Text = docid;
            dobtxtb.Text = dob;
            emailtxtb.Text = email;
            phtxtb.Text = phonenumber;
            aphtxtb.Text = altphonenumber;
            fnametxtb.Text = fname;
            fnametxtb.Text = fname;
            fnametxtb.Text = fname;
            fnametxtb.Text = fname;
            fnametxtb.Text = fname;
            fnametxtb.Text = fname;
        }
    }
}
