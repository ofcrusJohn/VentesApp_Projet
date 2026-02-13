// =========================================
// Projet 01 - ADO.Net
// But: Liste des commandes d’un client spécifique
// Auteur: Haba Jean de la Croix
//         Douanla Dountio Jerry Bostel
//         Dosso Ibrahima
// Date: 11 Février 2026
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
    public partial class CommandesSpecifiquesForm : Form
    {

        #region Initialisation
        public CommandesSpecifiquesForm()
        {
            InitializeComponent();
        }


        private void CommandesSpecifiquesForm_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'commandesDataSet.Products'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.productsTableAdapter.Fill(this.commandesDataSet.Products);
            // TODO: cette ligne de code charge les données dans la table 'commandesDataSet.Order_Details'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.order_DetailsTableAdapter.Fill(this.commandesDataSet.Order_Details);

        }
        #endregion

        #region methodes de flitration des donnees
        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Le Transact-SQL de la procédure stockée au début de la méthode pour obtenir l’information
                /*ALTER PROCEDURE [dbo].[CustOrdersOrders] @CustomerID nchar(5)
                    AS
                    SELECT OrderID, 
                	OrderDate,
                	RequiredDate,
                	ShippedDate
                    FROM Orders
                    WHERE CustomerID = @CustomerID
                    ORDER BY OrderID
                */
                this.custOrdersOrdersTableAdapter.Fill(this.commandesDataSet.CustOrdersOrders, customerIDToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        #endregion
    
    }
}
