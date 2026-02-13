// =========================================
// Projet 01 - ADO.Net
// But: Formulaire principal
// Auteur: Haba Jean de la Croix
//         Douanla Dountio Jerry Bostel
//         Dosso Ibrahima
// Date: 10 Février 2026
// =========================================


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
        #region Initialisation
        public VentesForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Événements d’ouverture des formulaires en mode modal

        private void listesDesCommandesButton_Click(object sender, EventArgs e)
        {
            try
            {
                CommandesSpecifiquesForm commandes = new CommandesSpecifiquesForm();
                commandes.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue : " + ex.Message);
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
                MessageBox.Show("Une erreur est survenue : " + ex.Message);
            }
        }

        #endregion Formulaires modaux

    }
}
