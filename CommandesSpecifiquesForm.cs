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
        public CommandesSpecifiquesForm()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
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

        private void CommandesSpecifiquesForm_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'commandesDataSet.Products'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.productsTableAdapter.Fill(this.commandesDataSet.Products);
            // TODO: cette ligne de code charge les données dans la table 'commandesDataSet.Order_Details'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.order_DetailsTableAdapter.Fill(this.commandesDataSet.Order_Details);

        }
    }
}
