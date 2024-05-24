using EmployeeNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void computeBtn_Click(object sender, EventArgs e)
        {
            PartTimeEmployee pTE = new PartTimeEmployee(fNameTxtBox.Text, lNameTxtBox.Text, depTxtBox.Text, jobTxtBox.Text);
            pTE.computeSalary(int.Parse(hourTxtBox.Text), double.Parse(rateTxtBox.Text));
            fNameLbl.Text = pTE.FirstName;
            lNameLbl.Text = pTE.LastName;
            salaryLbl.Text = pTE.getSalary().ToString();
        }
    }
}
