// =========================================
// Projet 01 - ADO.Net
// But: Total des ventes selon un pays et un intervalle de dates
// Auteur: Haba Jean de la Croix
//         Douanla Dountio Jerry Bostel
//         Dosso Ibrahima
// Date: 12 Février 2026
// =========================================


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VentesApp_Projet
{
    public partial class VentesParAnneeForm : Form
    {
        #region Initialisation
        public VentesParAnneeForm()
        {
            InitializeComponent();
        }
        #endregion

        #region calculer de somme d'argent
        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            /*
                SELECT Employees.Country, FORMAT(SUM([Order Details].UnitPrice * [Order Details].Quantity), 'C', 'en-US') AS TotalVentes
                FROM Employees INNER JOIN
                     Orders ON Employees.EmployeeID = Orders.EmployeeID INNER JOIN
                     [Order Details] ON Orders.OrderID = [Order Details].OrderID
                WHERE(Employees.Country = @Country) AND(Orders.ShippedDate >= @DateDebut) AND(Orders.ShippedDate <= @DateFin)
                GROUP BY Employees.Country
            */

            try
            {
                this.employeesTableAdapter.Fill(
                    this.commandesDataSet.Employees, 
                    countryToolStripTextBox.Text, 
                    new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateDebutToolStripTextBox.Text, typeof(System.DateTime))))),
                    new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateFinToolStripTextBox.Text, typeof(System.DateTime)))))
                );
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        #endregion
    }
}
