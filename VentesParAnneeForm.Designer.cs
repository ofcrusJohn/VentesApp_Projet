namespace VentesApp_Projet
{
    partial class VentesParAnneeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label totalVentesLabel;
            this.commandesDataSet = new VentesApp_Projet.CommandesDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new VentesApp_Projet.CommandesDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager = new VentesApp_Projet.CommandesDataSetTableAdapters.TableAdapterManager();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.countryToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.countryToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.dateDebutToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.dateDebutToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.dateFinToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.dateFinToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.totalVentesLabel1 = new System.Windows.Forms.Label();
            totalVentesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.commandesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // commandesDataSet
            // 
            this.commandesDataSet.DataSetName = "CommandesDataSet";
            this.commandesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.commandesDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Order_DetailsTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VentesApp_Projet.CommandesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countryToolStripLabel,
            this.countryToolStripTextBox,
            this.dateDebutToolStripLabel,
            this.dateDebutToolStripTextBox,
            this.dateFinToolStripLabel,
            this.dateFinToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(800, 27);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // countryToolStripLabel
            // 
            this.countryToolStripLabel.Name = "countryToolStripLabel";
            this.countryToolStripLabel.Size = new System.Drawing.Size(40, 24);
            this.countryToolStripLabel.Text = "Pays:";
            // 
            // countryToolStripTextBox
            // 
            this.countryToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.countryToolStripTextBox.Name = "countryToolStripTextBox";
            this.countryToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // dateDebutToolStripLabel
            // 
            this.dateDebutToolStripLabel.Name = "dateDebutToolStripLabel";
            this.dateDebutToolStripLabel.Size = new System.Drawing.Size(85, 24);
            this.dateDebutToolStripLabel.Text = "DateDebut:";
            // 
            // dateDebutToolStripTextBox
            // 
            this.dateDebutToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateDebutToolStripTextBox.Name = "dateDebutToolStripTextBox";
            this.dateDebutToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // dateFinToolStripLabel
            // 
            this.dateFinToolStripLabel.Name = "dateFinToolStripLabel";
            this.dateFinToolStripLabel.Size = new System.Drawing.Size(63, 24);
            this.dateFinToolStripLabel.Text = "DateFin:";
            // 
            // dateFinToolStripTextBox
            // 
            this.dateFinToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateFinToolStripTextBox.Name = "dateFinToolStripTextBox";
            this.dateFinToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(123, 24);
            this.fillToolStripButton.Text = "Obtenir la valeur";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // totalVentesLabel
            // 
            totalVentesLabel.AutoSize = true;
            totalVentesLabel.Location = new System.Drawing.Point(12, 90);
            totalVentesLabel.Name = "totalVentesLabel";
            totalVentesLabel.Size = new System.Drawing.Size(49, 16);
            totalVentesLabel.TabIndex = 2;
            totalVentesLabel.Text = "Valeur:";
            // 
            // totalVentesLabel1
            // 
            this.totalVentesLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalVentesLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "TotalVentes", true));
            this.totalVentesLabel1.Location = new System.Drawing.Point(146, 90);
            this.totalVentesLabel1.Name = "totalVentesLabel1";
            this.totalVentesLabel1.Size = new System.Drawing.Size(100, 23);
            this.totalVentesLabel1.TabIndex = 3;
            this.totalVentesLabel1.Text = "Total";
            // 
            // VentesParAnneeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(totalVentesLabel);
            this.Controls.Add(this.totalVentesLabel1);
            this.Controls.Add(this.fillToolStrip);
            this.Name = "VentesParAnneeForm";
            this.Text = "VentesParAnneeForm";
            this.Load += new System.EventHandler(this.VentesParAnneeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.commandesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CommandesDataSet commandesDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private CommandesDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private CommandesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel countryToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox countryToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel dateDebutToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox dateDebutToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel dateFinToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox dateFinToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.Label totalVentesLabel1;
    }
}