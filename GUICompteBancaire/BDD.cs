using CompteBancaireEF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICompteBancaire
{
    public partial class BDD : Form
    {
        public BDD()
        {
            InitializeComponent();
        }

        ComptesBancaireContext fichierSQLite = new ComptesBancaireContext();

        private void BDD_Load(object sender, EventArgs e)
        {
            fichierSQLite = new ComptesBancaireContext();
            fichierSQLite.Database.EnsureCreated();
            fichierSQLite.Comptes.Load();

            compteBindingSource.DataSource = fichierSQLite.Comptes.Local.ToBindingList();

        }

        private void BDD_FormClosed(object sender, FormClosedEventArgs e)
        {
            fichierSQLite.SaveChanges();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (dataGridView1.CurrentRow.DataBoundItem != null) 
                { 
                    Compte cpte = (Compte) dataGridView1.CurrentRow.DataBoundItem;

                    if (cpte != null)
                    {

                        fichierSQLite.Entry(cpte).Collection(c=>c.Transactions).Load();
                        transactionBindingSource.DataSource = cpte.Transactions;

                    }

                }

            }
        }
    }
}
