using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_DepartementEmployee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void departementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDepartement formDepartement = new FormDepartement();    
            formDepartement.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmployee employee = new FormEmployee();
            employee.Show();
        }

        private void listeEmployeeDepartementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmdep formEmdep = new FormEmdep();
            formEmdep.Show();
        }

        private void diagrammeNbrEmployeeFonctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmp_Fonction formEmp_Fonction = new FormEmp_Fonction();
            formEmp_Fonction.Show();
        }

        private void raportDepartementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDepRaport formDep   =   new FormDepRaport();
                formDep.Show();
        }
    }
}
