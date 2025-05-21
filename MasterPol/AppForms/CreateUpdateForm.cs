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
    public partial class CreateUpdateForm : Form
    {
        private Partners partners;
        public CreateUpdateForm(Partners partners)
        {
            InitializeComponent();
            this.partners = partners;
            FillComboBox();

            if (partners != null)
            {
                UpdatePartners();
            }
        }

        private void FillComboBox()
        {
            using (var context = new MasterPolEntities())
            {
                var type = context.TypePartners.ToList();

                nameTypePartnersIdComboBox.DataSource = type;
                nameTypePartnersIdComboBox.DisplayMember = "NameTypePartners";
                nameTypePartnersIdComboBox.ValueMember = "IdTypePartners";
            }
        }

        private void UpdatePartners()
        {
            this.Text = "Обновление данных о партнере";
            label2.Text = "Обновление данных о партнере";
            btnAddPartners.Text = "Обновить данные";

            nameTypePartnersIdComboBox.SelectedValue = partners.NameTypePartnersId;
            namePartnersTextBox.Text = partners.NamePartners;
            directorTextBox.Text = partners.Director;
            phoneMaskedTextBox.Text = Convert.ToString(partners.Phone);
            emailTextBox.Text = partners.Email;
            addressTextBox.Text = partners.Address;
            iNNMaskedTextBox.Text = Convert.ToString(partners.INN);
            raitingNumericUpDown.Value = Convert.ToInt32(partners.Raiting);
        }

        private string ClearPhone()
        {
            string trimmedPhone = phoneMaskedTextBox.Text.Replace("+", "");
            trimmedPhone = trimmedPhone.Replace(" ", "");
            return trimmedPhone;
        }
        private void AddAndUpdatePartners()
        {
            try
            {
                var type = Convert.ToInt32(nameTypePartnersIdComboBox.SelectedValue);
                var name = namePartnersTextBox.Text;
                var director = directorTextBox.Text;
                var phone = Convert.ToDouble(ClearPhone());
                var email = emailTextBox.Text;
                var address = addressTextBox.Text;
                var Inn = Convert.ToDouble(iNNMaskedTextBox.Text);
                var raiting = Convert.ToDouble(raitingNumericUpDown.Value);

                if (string.IsNullOrEmpty(name)&&string.IsNullOrEmpty(director)
                    && string.IsNullOrEmpty(email) && string.IsNullOrEmpty(address))
                {
                    MessageBox.Show("Заполните все поля!");
                    return;
                }

                using (var context = new MasterPolEntities())
                {
                    if (partners == null)
                    {
                        var newPartners = new Partners()
                        {
                            NameTypePartnersId = type,
                            NamePartners = name,
                            Director = director,
                            Phone = phone,
                            Email = email,
                            Address = address,
                            INN = Inn,
                            Raiting = raiting,
                        };
                        MessageBox.Show("Партнер успешно добавлен!");
                        context.Partners.Add(newPartners);
                    }
                    else
                    {
                        var updatePartners = context.Partners.Find(partners.IdTypePartners);

                        updatePartners.NameTypePartnersId = type;
                        updatePartners.NamePartners = name;
                        updatePartners.Director = director;
                        updatePartners.Phone = phone;
                        updatePartners.Email = email;
                        updatePartners.Address = address;
                        updatePartners.INN = Inn;
                        updatePartners.Raiting = raiting;
                    }
                    context.SaveChanges();
                }
                DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void btnAddPartners_Click(object sender, EventArgs e)
        {
            AddAndUpdatePartners();
        }
    }
}
