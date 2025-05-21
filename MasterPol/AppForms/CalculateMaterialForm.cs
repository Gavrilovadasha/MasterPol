using MasterPol.DopMethod;
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
    public partial class CalculateMaterialForm : Form
    {
        public CalculateMaterialForm()
        {
            InitializeComponent();
        }

        private void btnCalcMaterial_Click(object sender, EventArgs e)
        {
            var calc = new CalculateMaterialClass();
            var result = calc.CalcMaterial(Convert.ToInt32(numericUpDownIdProd.Value),
                Convert.ToInt32(numericUpDownIdMaterial.Value),
                Convert.ToInt32(numericUpDownKolvoProd.Value));

            MessageBox.Show($"Для идентификатора товара {numericUpDownIdProd.Value} с идентификатором материала {numericUpDownIdMaterial.Value} для производства продукции в размере {numericUpDownKolvoProd.Value} единиц потребуется {result} материала");
        }
    }
}
