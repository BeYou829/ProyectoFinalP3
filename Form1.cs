namespace ProyectoFinalP3
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            //dg_employees.DataSource = Employee.ReportEmployee();
        }

        private void ReportEmployee_Click(object sender, EventArgs e)
        {
            ReportEmployee reportEmployeeForm = new ReportEmployee();
            reportEmployeeForm.Visible = true;

        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployeeForm = new AddEmployee();
            addEmployeeForm.Visible = true;
        }

        private void UpdateEmployee_Click(object sender, EventArgs e)
        {
            UpdateEmployee updateEmployeeForm = new UpdateEmployee();
            updateEmployeeForm.Visible = true;
        }
    }
}
