using MasterPol.CustomControls;
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
    public partial class MainForm : Form
    {
        private Partners partners;
        private List<Partners> listPartners;
        public MainForm()
        {
            InitializeComponent();
            ShowDataPartners();
        }
        public void ShowDataPartners()
        {
            flowLayoutPanel.Controls.Clear();

            using (var context = new MasterPolEntities())
            {
                listPartners = context.Partners.ToList();

                foreach (var onePartner in listPartners)
                {
                    var partner = new PartnersControl(onePartner,this);

                    flowLayoutPanel.Controls.Add(partner);
                }
            }
        }

        private void btnAddNewPartners_Click(object sender, EventArgs e)
        {
            CreateUpdateForm createUpdate = new CreateUpdateForm(partners);
            createUpdate.ShowDialog();
            ShowDataPartners();
        }

        
        private void btnCalculateMaterial_Click(object sender, EventArgs e)
        {
            CalculateMaterialForm calculateMaterial = new CalculateMaterialForm();
            calculateMaterial.ShowDialog();
        }
    }
}
