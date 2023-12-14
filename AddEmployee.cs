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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            fnametxtb.ResetText();
            lnametxtb.ResetText();
            sextxtb.ResetText();
            dobtxtb.ResetText();
            docidtxtb.ResetText();
            emailtxtb.ResetText();
            phtxtb.ResetText();
            aphtxtb.ResetText();
            direcciontxtb.ResetText();
            ciudadtxtb.ResetText();
            provinciatxtb.ResetText();
            roltxtb.ResetText();
            depttxtb.ResetText();
        }

        private void addEmployeebtn_Click(object sender, EventArgs e)
        {
            if (Employee.SaveEmployee(fnametxtb.Text,lnametxtb.Text,sextxtb.Text,docidtxtb.Text,dobtxtb.Text,emailtxtb.Text,phtxtb.Text,aphtxtb.Text,direcciontxtb.Text,ciudadtxtb.Text,provinciatxtb.Text,roltxtb.Text,depttxtb.Text))
            {
                MessageBox.Show("Employee Saved");
                fnametxtb.ResetText();
                lnametxtb.ResetText();
                sextxtb.ResetText();
                dobtxtb.ResetText();
                docidtxtb.ResetText();
                emailtxtb.ResetText();
                phtxtb.ResetText();
                aphtxtb.ResetText();
                direcciontxtb.ResetText();
                ciudadtxtb.ResetText();
                provinciatxtb.ResetText();
                roltxtb.ResetText();
                depttxtb.ResetText();
            }
            else
            {
                MessageBox.Show("Something Went wrong");
            }
        }
    }
}
