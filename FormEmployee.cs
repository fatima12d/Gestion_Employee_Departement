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
    public partial class FormEmployee : Form

    {
        gestion_departementEntities contexte = new gestion_departementEntities();
        public FormEmployee()
        {
            InitializeComponent();
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtprenom.Text = "";
            txtnom.Text = "";
            txtfonc.Text = "";
            txtsalaire.Text = "";
           
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            employee employee = new employee();
            employee.prenom = txtprenom.Text;
            employee.nom = txtnom.Text;
            
            employee.fonction = txtfonc.Text;
            employee.salaire = int.Parse(txtsalaire.Text);


            employee.iddep = Convert.ToInt32(comboBox1.SelectedValue);
            contexte.employee.Add(employee);
            contexte.SaveChanges();
            MessageBox.Show("Ajout employee avec succé!");
            dataGridView1.DataSource = contexte.employee.ToList();

        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = contexte.employee.ToList();
            comboBox1.DataSource = contexte.departement.ToList();
            comboBox1.DisplayMember = "libelle";
            comboBox1.ValueMember = "id";
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtid.Text, out id))
            {
                employee employee = contexte.employee.Find(id);
                if (employee != null)
                {
                    employee.prenom = txtprenom.Text;
                    employee.nom = txtnom.Text;
                    employee.fonction = txtfonc.Text;
                    employee.salaire =int.Parse( txtsalaire.Text);

                    employee.iddep = Convert.ToInt32(comboBox1.SelectedValue);
                    contexte.SaveChanges();
                    MessageBox.Show("Employee mis à jour avec succès!");
                    dataGridView1.DataSource = contexte.employee.ToList();
                }
                else
                {
                    MessageBox.Show("Aucun employee trouvé avec cet ID.");
                }
            }
            else
            {
                MessageBox.Show("L'ID saisi n'est pas valide.");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtid.Text, out id))
            {
                employee employee = contexte.employee.Find(id);
                if (employee != null)
                {
                    contexte.employee.Remove(employee);
                    contexte.SaveChanges();
                    MessageBox.Show("employee supprimé avec succès!");
                    dataGridView1.DataSource = contexte.employee.ToList();
                }
                else
                {
                    MessageBox.Show("Aucun employee trouvé avec cet ID.");
                }
            }
            else
            {
                MessageBox.Show("L'ID saisi n'est pas valide.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iddep = Convert.ToInt32(comboBox1.SelectedValue);
            var emp = contexte.employee.Where(em => em.iddep == iddep).ToList();

            if (emp.Count > 0)
            {
                dataGridView1.DataSource = emp;
            }
            else
            {
                MessageBox.Show("Aucun employee trouvé dans cette classe.");
            }

        }
    }
}
