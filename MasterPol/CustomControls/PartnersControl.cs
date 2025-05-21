using MasterPol.AppForms;
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

namespace MasterPol.CustomControls
{
    public partial class PartnersControl : UserControl
    {
        private Partners partners;
        private MainForm mainForm;
        public PartnersControl(Partners partners, MainForm mainForm)
        {
            InitializeComponent();
            this.partners = partners;
            FillDataPartners();
            this.mainForm = mainForm;
        }

        private void FillDataPartners()
        {
            labelTypeAndName.Text = $"{partners.TypePartners.NameTypePartners}|{partners.NamePartners}";
            labelDirector.Text = partners.Director.ToString();
            labelPhone.Text = String.Format("{0:+0 000 000 00 00}", partners.Phone);
            labelRaiting.Text = partners.Raiting.ToString();

            using (var context = new MasterPolEntities())
            {
                var kolvoProduct = 0;
                var listProd = context.PartnersProducts
                    .Where(p => p.NamePartnersId == partners.IdTypePartners)
                    .ToList();

                foreach (var oneProd in listProd)
                {
                    int kolvo = Convert.ToInt32(oneProd.KolvoProducts);
                    kolvoProduct = kolvoProduct + kolvo;
                }

                if (kolvoProduct < 10000)
                {
                    labelSale.Text = "0%";
                }
                else if (kolvoProduct < 500000)
                {
                    labelSale.Text = "5%";
                }
                else if (kolvoProduct < 300000)
                {
                    labelSale.Text = "10%";
                }
                else
                {
                    labelSale.Text = "15%";
                }

            }
        }

        private void btnHistoryPartners_Click(object sender, EventArgs e)
        {
            HistoryPartnersProductsForm historyPartners = new HistoryPartnersProductsForm(partners);
            historyPartners.ShowDialog();
        }

        private void UpdatePartners_Click(object sender, EventArgs e)
        {
            using (var update = new CreateUpdateForm(partners))
            {
                if (update.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Данные о партнере успешно обновлены!");
                }
                mainForm.ShowDataPartners();
            }
        }
    }
}
