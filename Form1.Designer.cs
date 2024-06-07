namespace Gestion_DepartementEmployee
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.departementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeEmployeeDepartementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagrammeNbrEmployeeFonctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportDepartementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departementToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.raportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // departementToolStripMenuItem
            // 
            this.departementToolStripMenuItem.Name = "departementToolStripMenuItem";
            this.departementToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.departementToolStripMenuItem.Text = "Departement";
            this.departementToolStripMenuItem.Click += new System.EventHandler(this.departementToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // raportToolStripMenuItem
            // 
            this.raportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeEmployeeDepartementToolStripMenuItem,
            this.diagrammeNbrEmployeeFonctionToolStripMenuItem,
            this.raportDepartementToolStripMenuItem});
            this.raportToolStripMenuItem.Name = "raportToolStripMenuItem";
            this.raportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.raportToolStripMenuItem.Text = "Raport";
            // 
            // listeEmployeeDepartementToolStripMenuItem
            // 
            this.listeEmployeeDepartementToolStripMenuItem.Name = "listeEmployeeDepartementToolStripMenuItem";
            this.listeEmployeeDepartementToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.listeEmployeeDepartementToolStripMenuItem.Text = "Liste_Employee_Departement";
            this.listeEmployeeDepartementToolStripMenuItem.Click += new System.EventHandler(this.listeEmployeeDepartementToolStripMenuItem_Click);
            // 
            // diagrammeNbrEmployeeFonctionToolStripMenuItem
            // 
            this.diagrammeNbrEmployeeFonctionToolStripMenuItem.Name = "diagrammeNbrEmployeeFonctionToolStripMenuItem";
            this.diagrammeNbrEmployeeFonctionToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.diagrammeNbrEmployeeFonctionToolStripMenuItem.Text = "Diagramme Nbr_Employee_Fonction";
            this.diagrammeNbrEmployeeFonctionToolStripMenuItem.Click += new System.EventHandler(this.diagrammeNbrEmployeeFonctionToolStripMenuItem_Click);
            // 
            // raportDepartementToolStripMenuItem
            // 
            this.raportDepartementToolStripMenuItem.Name = "raportDepartementToolStripMenuItem";
            this.raportDepartementToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.raportDepartementToolStripMenuItem.Text = "Raport Departement";
            this.raportDepartementToolStripMenuItem.Click += new System.EventHandler(this.raportDepartementToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(225, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTION EMPLOYEES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "FormMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem departementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeEmployeeDepartementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagrammeNbrEmployeeFonctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raportDepartementToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

