using MasterPol.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterPol.AppForms
{
    public partial class HistoryPartnersProductsForm : Form
    {
        private Partners partners;
        public HistoryPartnersProductsForm(Partners partners)
        {
            InitializeComponent();
            this.partners = partners;
        }

        //private void partnersProductsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.partnersProductsBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.masterPolDataSet);

        //}

        private void HistoryPartnersProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "masterPolDataSet.Partners". При необходимости она может быть перемещена или удалена.
            this.partnersTableAdapter.Fill(this.masterPolDataSet.Partners);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "masterPolDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.masterPolDataSet.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "masterPolDataSet.PartnersProducts". При необходимости она может быть перемещена или удалена.
            this.partnersProductsTableAdapter.Fill(this.masterPolDataSet.PartnersProducts);

            using (var context = new MasterPolEntities())
            {
                partnersProductsBindingSource.DataSource = context.PartnersProducts
                    .Where(p => p.NamePartnersId == partners.IdTypePartners)
                    .OrderByDescending(p => p.DateProdaji)
                    .ToList();
            }
        }
    }
}
