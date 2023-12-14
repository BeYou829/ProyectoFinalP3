using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalP3
{
    public partial class DeleteEmployee : Form
    {
        public DeleteEmployee()
        {
            InitializeComponent();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string UID = dg_Employees.CurrentRow.Cells["ID"].Value.ToString() ?? "";

            if (Employee.DeleteEmployee(UID))
            {
                MessageBox.Show("Employee Deleted");
                dg_Employees.DataSource = Employee.ReportEmployee();
            }
            else
            {
                MessageBox.Show("Something Went wrong");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteEmployee_Load(object sender, EventArgs e)
        {
            dg_Employees.DataSource = Employee.ReportEmployee();
        }
    }
}
