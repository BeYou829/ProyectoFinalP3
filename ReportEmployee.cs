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
    public partial class ReportEmployee : Form
    {
        public ReportEmployee()
        {
            InitializeComponent();
        }

        private void ReportEmployee_Load(object sender, EventArgs e)
        {
            dg_Employees.DataSource = Employee.ReportEmployee();
        }

        private void dg_Employees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
