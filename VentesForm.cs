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
    public partial class VentesForm : Form
    {
        public VentesForm()
        {
            InitializeComponent();
        }

        private void listesDesCommandesButton_Click(object sender, EventArgs e)
        {
            try
            {
                CommandesSpecifiquesForm commandes = new CommandesSpecifiquesForm();
                commandes.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue " + ex.Message);

            }
        }

        private void listeDesVentesButton_Click(object sender, EventArgs e)
        {
            try
            {
                VentesParAnneeForm ventes = new VentesParAnneeForm();
                ventes.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue " + ex.Message);

            }

        }

        private void VentesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
