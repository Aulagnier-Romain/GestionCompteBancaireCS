namespace GUICompteBancaire
{
    partial class BDD
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proprietaireDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            compteBindingSource = new BindingSource(components);
            dataGridView2 = new DataGridView();
            transactionBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            idCompteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            montantDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            notesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idCompteNavigationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)compteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, proprietaireDataGridViewTextBoxColumn, numeroDataGridViewTextBoxColumn, transactionsDataGridViewTextBoxColumn });
            dataGridView1.DataSource = compteBindingSource;
            dataGridView1.Location = new Point(100, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(243, 306);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // proprietaireDataGridViewTextBoxColumn
            // 
            proprietaireDataGridViewTextBoxColumn.DataPropertyName = "Proprietaire";
            proprietaireDataGridViewTextBoxColumn.HeaderText = "Proprietaire";
            proprietaireDataGridViewTextBoxColumn.Name = "proprietaireDataGridViewTextBoxColumn";
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            // 
            // transactionsDataGridViewTextBoxColumn
            // 
            transactionsDataGridViewTextBoxColumn.DataPropertyName = "Transactions";
            transactionsDataGridViewTextBoxColumn.HeaderText = "Transactions";
            transactionsDataGridViewTextBoxColumn.Name = "transactionsDataGridViewTextBoxColumn";
            transactionsDataGridViewTextBoxColumn.Visible = false;
            // 
            // compteBindingSource
            // 
            compteBindingSource.DataSource = typeof(CompteBancaireEF.Compte);
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, idCompteDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, montantDataGridViewTextBoxColumn, notesDataGridViewTextBoxColumn, idCompteNavigationDataGridViewTextBoxColumn });
            dataGridView2.DataSource = transactionBindingSource;
            dataGridView2.Location = new Point(363, 60);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(343, 306);
            dataGridView2.TabIndex = 1;
            // 
            // transactionBindingSource
            // 
            transactionBindingSource.DataSource = typeof(CompteBancaireEF.Transaction);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idCompteDataGridViewTextBoxColumn
            // 
            idCompteDataGridViewTextBoxColumn.DataPropertyName = "IdCompte";
            idCompteDataGridViewTextBoxColumn.HeaderText = "IdCompte";
            idCompteDataGridViewTextBoxColumn.Name = "idCompteDataGridViewTextBoxColumn";
            idCompteDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Date";
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // montantDataGridViewTextBoxColumn
            // 
            montantDataGridViewTextBoxColumn.DataPropertyName = "Montant";
            montantDataGridViewTextBoxColumn.HeaderText = "Montant";
            montantDataGridViewTextBoxColumn.Name = "montantDataGridViewTextBoxColumn";
            // 
            // notesDataGridViewTextBoxColumn
            // 
            notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            // 
            // idCompteNavigationDataGridViewTextBoxColumn
            // 
            idCompteNavigationDataGridViewTextBoxColumn.DataPropertyName = "IdCompteNavigation";
            idCompteNavigationDataGridViewTextBoxColumn.HeaderText = "IdCompteNavigation";
            idCompteNavigationDataGridViewTextBoxColumn.Name = "idCompteNavigationDataGridViewTextBoxColumn";
            idCompteNavigationDataGridViewTextBoxColumn.Visible = false;
            // 
            // BDD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "BDD";
            Text = "BDD";
            FormClosed += BDD_FormClosed;
            Load += BDD_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)compteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource compteBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn proprietaireDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionsDataGridViewTextBoxColumn;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn idCompteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn montantDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idCompteNavigationDataGridViewTextBoxColumn;
        private BindingSource transactionBindingSource;
    }
}