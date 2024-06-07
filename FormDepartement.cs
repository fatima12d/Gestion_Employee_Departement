using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestion_DepartementEmployee
{
    public partial class FormDepartement : Form
    {
        gestion_departementEntities contexte = new gestion_departementEntities();
        public FormDepartement()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            departement departement = new departement();
            departement.libelle = txtlibelle.Text;
      
            contexte.departement.Add(departement);
            contexte.SaveChanges();
            MessageBox.Show("Ajout departement avec succé!");
            dataGridView1.DataSource = contexte.departement.ToList();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtid.Text, out id))
            {
                departement departement = contexte.departement.Find(id);
                if (departement != null)
                {
                    departement.libelle = txtlibelle.Text;
                   
                    contexte.SaveChanges();
                    MessageBox.Show("departement mis à jour avec succès!");
                    dataGridView1.DataSource = contexte.departement.ToList();
                }
                else
                {
                    MessageBox.Show("Aucun departemt trouvé avec cet ID.");
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
                departement departement = contexte.departement.Find(id);
                if (departement != null)
                {
                    contexte.departement.Remove(departement);
                    contexte.SaveChanges();
                    MessageBox.Show("departement supprimé avec succès!");
                    dataGridView1.DataSource = contexte.departement.ToList();
                }
                else
                {
                    MessageBox.Show("Aucun departement trouvé avec cet ID.");
                }
            }
            else
            {
                MessageBox.Show("L'ID saisi n'est pas valide.");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtlibelle.Text = "";
        }

        private void FormDepartement_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = contexte.departement.ToList();
        }
    }
}
