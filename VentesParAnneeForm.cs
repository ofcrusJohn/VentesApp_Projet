using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentesApp_Projet
{
    public partial class VentesParAnneeForm : Form
    {
        public VentesParAnneeForm()
        {
            InitializeComponent();
        }

       

        private void VentesParAnneeForm_Load(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeesTableAdapter.Fill(this.commandesDataSet.Employees, countryToolStripTextBox.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateDebutToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateFinToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
