namespace MasterPol.AppForms
{
    partial class CreateUpdateForm
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
            System.Windows.Forms.Label nameTypePartnersIdLabel;
            System.Windows.Forms.Label namePartnersLabel;
            System.Windows.Forms.Label directorLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label iNNLabel;
            System.Windows.Forms.Label raitingLabel;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUpdateForm));
            this.panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnAddPartners = new System.Windows.Forms.Button();
            this.masterPolDataSet = new MasterPol.MasterPolDataSet();
            this.partnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partnersTableAdapter = new MasterPol.MasterPolDataSetTableAdapters.PartnersTableAdapter();
            this.tableAdapterManager = new MasterPol.MasterPolDataSetTableAdapters.TableAdapterManager();
            this.nameTypePartnersIdComboBox = new System.Windows.Forms.ComboBox();
            this.namePartnersTextBox = new System.Windows.Forms.TextBox();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.iNNMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.raitingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            nameTypePartnersIdLabel = new System.Windows.Forms.Label();
            namePartnersLabel = new System.Windows.Forms.Label();
            directorLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            iNNLabel = new System.Windows.Forms.Label();
            raitingLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterPolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raitingNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTypePartnersIdLabel
            // 
            nameTypePartnersIdLabel.AutoSize = true;
            nameTypePartnersIdLabel.Location = new System.Drawing.Point(23, 146);
            nameTypePartnersIdLabel.Name = "nameTypePartnersIdLabel";
            nameTypePartnersIdLabel.Size = new System.Drawing.Size(117, 21);
            nameTypePartnersIdLabel.TabIndex = 4;
            nameTypePartnersIdLabel.Text = "Тип партнера";
            // 
            // namePartnersLabel
            // 
            namePartnersLabel.AutoSize = true;
            namePartnersLabel.Location = new System.Drawing.Point(23, 179);
            namePartnersLabel.Name = "namePartnersLabel";
            namePartnersLabel.Size = new System.Drawing.Size(161, 21);
            namePartnersLabel.TabIndex = 6;
            namePartnersLabel.Text = "Название партнера";
            // 
            // directorLabel
            // 
            directorLabel.AutoSize = true;
            directorLabel.Location = new System.Drawing.Point(23, 216);
            directorLabel.Name = "directorLabel";
            directorLabel.Size = new System.Drawing.Size(88, 21);
            directorLabel.TabIndex = 8;
            directorLabel.Text = "Директор";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(23, 251);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(87, 21);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "Эл. почта";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(458, 148);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(75, 21);
            phoneLabel.TabIndex = 12;
            phoneLabel.Text = "Телефон";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(458, 183);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(54, 21);
            addressLabel.TabIndex = 14;
            addressLabel.Text = "Адрес";
            // 
            // iNNLabel
            // 
            iNNLabel.AutoSize = true;
            iNNLabel.Location = new System.Drawing.Point(458, 218);
            iNNLabel.Name = "iNNLabel";
            iNNLabel.Size = new System.Drawing.Size(46, 21);
            iNNLabel.TabIndex = 16;
            iNNLabel.Text = "ИНН";
            // 
            // raitingLabel
            // 
            raitingLabel.AutoSize = true;
            raitingLabel.Location = new System.Drawing.Point(458, 250);
            raitingLabel.Name = "raitingLabel";
            raitingLabel.Size = new System.Drawing.Size(76, 21);
            raitingLabel.TabIndex = 18;
            raitingLabel.Text = "Рейтинг";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(198, 281);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(225, 15);
            label3.TabIndex = 20;
            label3.Text = "Введите в формате \"admin@mail.com\"";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Location = new System.Drawing.Point(12, 9);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(810, 114);
            this.panel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(123, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Добавление нового партнера";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Мастер пол";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::MasterPol.Properties.Resources.Мастер_пол;
            this.pictureBox.Location = new System.Drawing.Point(17, 13);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 86);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // btnAddPartners
            // 
            this.btnAddPartners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnAddPartners.ForeColor = System.Drawing.Color.White;
            this.btnAddPartners.Location = new System.Drawing.Point(299, 317);
            this.btnAddPartners.Name = "btnAddPartners";
            this.btnAddPartners.Size = new System.Drawing.Size(288, 36);
            this.btnAddPartners.TabIndex = 3;
            this.btnAddPartners.Text = "Добавить партнера";
            this.btnAddPartners.UseVisualStyleBackColor = false;
            this.btnAddPartners.Click += new System.EventHandler(this.btnAddPartners_Click);
            // 
            // masterPolDataSet
            // 
            this.masterPolDataSet.DataSetName = "MasterPolDataSet";
            this.masterPolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partnersBindingSource
            // 
            this.partnersBindingSource.DataMember = "Partners";
            this.partnersBindingSource.DataSource = this.masterPolDataSet;
            // 
            // partnersTableAdapter
            // 
            this.partnersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PartnersProductsTableAdapter = null;
            this.tableAdapterManager.PartnersTableAdapter = this.partnersTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.ProductsTypeTableAdapter = null;
            this.tableAdapterManager.TypeMaterialTableAdapter = null;
            this.tableAdapterManager.TypePartnersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MasterPol.MasterPolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nameTypePartnersIdComboBox
            // 
            this.nameTypePartnersIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnersBindingSource, "NameTypePartnersId", true));
            this.nameTypePartnersIdComboBox.FormattingEnabled = true;
            this.nameTypePartnersIdComboBox.Location = new System.Drawing.Point(190, 144);
            this.nameTypePartnersIdComboBox.Name = "nameTypePartnersIdComboBox";
            this.nameTypePartnersIdComboBox.Size = new System.Drawing.Size(248, 29);
            this.nameTypePartnersIdComboBox.TabIndex = 5;
            // 
            // namePartnersTextBox
            // 
            this.namePartnersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnersBindingSource, "NamePartners", true));
            this.namePartnersTextBox.Location = new System.Drawing.Point(190, 179);
            this.namePartnersTextBox.Name = "namePartnersTextBox";
            this.namePartnersTextBox.Size = new System.Drawing.Size(248, 29);
            this.namePartnersTextBox.TabIndex = 7;
            // 
            // directorTextBox
            // 
            this.directorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnersBindingSource, "Director", true));
            this.directorTextBox.Location = new System.Drawing.Point(190, 214);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(248, 29);
            this.directorTextBox.TabIndex = 9;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnersBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(190, 249);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(248, 29);
            this.emailTextBox.TabIndex = 11;
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnersBindingSource, "Phone", true));
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(555, 145);
            this.phoneMaskedTextBox.Mask = "+0 000 000 00 00";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(248, 29);
            this.phoneMaskedTextBox.TabIndex = 13;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnersBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(555, 180);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(248, 29);
            this.addressTextBox.TabIndex = 15;
            // 
            // iNNMaskedTextBox
            // 
            this.iNNMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnersBindingSource, "INN", true));
            this.iNNMaskedTextBox.Location = new System.Drawing.Point(555, 215);
            this.iNNMaskedTextBox.Mask = "0000000000";
            this.iNNMaskedTextBox.Name = "iNNMaskedTextBox";
            this.iNNMaskedTextBox.Size = new System.Drawing.Size(248, 29);
            this.iNNMaskedTextBox.TabIndex = 17;
            // 
            // raitingNumericUpDown
            // 
            this.raitingNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.partnersBindingSource, "Raiting", true));
            this.raitingNumericUpDown.Location = new System.Drawing.Point(555, 250);
            this.raitingNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.raitingNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.raitingNumericUpDown.Name = "raitingNumericUpDown";
            this.raitingNumericUpDown.Size = new System.Drawing.Size(248, 29);
            this.raitingNumericUpDown.TabIndex = 19;
            this.raitingNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CreateUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(842, 417);
            this.Controls.Add(label3);
            this.Controls.Add(nameTypePartnersIdLabel);
            this.Controls.Add(this.nameTypePartnersIdComboBox);
            this.Controls.Add(namePartnersLabel);
            this.Controls.Add(this.namePartnersTextBox);
            this.Controls.Add(directorLabel);
            this.Controls.Add(this.directorTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneMaskedTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(iNNLabel);
            this.Controls.Add(this.iNNMaskedTextBox);
            this.Controls.Add(raitingLabel);
            this.Controls.Add(this.raitingNumericUpDown);
            this.Controls.Add(this.btnAddPartners);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление партнера";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterPolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raitingNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnAddPartners;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
        private MasterPolDataSet masterPolDataSet;
        private System.Windows.Forms.BindingSource partnersBindingSource;
        private MasterPolDataSetTableAdapters.PartnersTableAdapter partnersTableAdapter;
        private MasterPolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox nameTypePartnersIdComboBox;
        private System.Windows.Forms.TextBox namePartnersTextBox;
        private System.Windows.Forms.TextBox directorTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.MaskedTextBox iNNMaskedTextBox;
        private System.Windows.Forms.NumericUpDown raitingNumericUpDown;
    }
}