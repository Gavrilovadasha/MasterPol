namespace MasterPol.AppForms
{
    partial class CalculateMaterialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateMaterialForm));
            this.partnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterPolDataSet = new MasterPol.MasterPolDataSet();
            this.tableAdapterManager = new MasterPol.MasterPolDataSetTableAdapters.TableAdapterManager();
            this.partnersTableAdapter = new MasterPol.MasterPolDataSetTableAdapters.PartnersTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcMaterial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownIdProd = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIdMaterial = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKolvoProd = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterPolDataSet)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKolvoProd)).BeginInit();
            this.SuspendLayout();
            // 
            // partnersBindingSource
            // 
            this.partnersBindingSource.DataMember = "Partners";
            this.partnersBindingSource.DataSource = this.masterPolDataSet;
            // 
            // masterPolDataSet
            // 
            this.masterPolDataSet.DataSetName = "MasterPolDataSet";
            this.masterPolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // partnersTableAdapter
            // 
            this.partnersTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(123, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Расчёт количества необходимого материала";
            // 
            // btnCalcMaterial
            // 
            this.btnCalcMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnCalcMaterial.ForeColor = System.Drawing.Color.White;
            this.btnCalcMaterial.Location = new System.Drawing.Point(287, 276);
            this.btnCalcMaterial.Name = "btnCalcMaterial";
            this.btnCalcMaterial.Size = new System.Drawing.Size(288, 36);
            this.btnCalcMaterial.TabIndex = 22;
            this.btnCalcMaterial.Text = "Рассчитать кол-во материала";
            this.btnCalcMaterial.UseVisualStyleBackColor = false;
            this.btnCalcMaterial.Click += new System.EventHandler(this.btnCalcMaterial_Click);
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
            // panel
            // 
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(810, 114);
            this.panel.TabIndex = 21;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 42);
            this.label3.TabIndex = 23;
            this.label3.Text = "Идентификатор\r\nпродукции";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 42);
            this.label4.TabIndex = 24;
            this.label4.Text = "Идентификатор\r\nматериала";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(624, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Кол-во продукции";
            // 
            // numericUpDownIdProd
            // 
            this.numericUpDownIdProd.Location = new System.Drawing.Point(29, 208);
            this.numericUpDownIdProd.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownIdProd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIdProd.Name = "numericUpDownIdProd";
            this.numericUpDownIdProd.Size = new System.Drawing.Size(181, 29);
            this.numericUpDownIdProd.TabIndex = 26;
            this.numericUpDownIdProd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownIdMaterial
            // 
            this.numericUpDownIdMaterial.Location = new System.Drawing.Point(337, 208);
            this.numericUpDownIdMaterial.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownIdMaterial.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIdMaterial.Name = "numericUpDownIdMaterial";
            this.numericUpDownIdMaterial.Size = new System.Drawing.Size(181, 29);
            this.numericUpDownIdMaterial.TabIndex = 27;
            this.numericUpDownIdMaterial.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownKolvoProd
            // 
            this.numericUpDownKolvoProd.Location = new System.Drawing.Point(628, 208);
            this.numericUpDownKolvoProd.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownKolvoProd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKolvoProd.Name = "numericUpDownKolvoProd";
            this.numericUpDownKolvoProd.Size = new System.Drawing.Size(181, 29);
            this.numericUpDownKolvoProd.TabIndex = 28;
            this.numericUpDownKolvoProd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CalculateMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 330);
            this.Controls.Add(this.numericUpDownKolvoProd);
            this.Controls.Add(this.numericUpDownIdMaterial);
            this.Controls.Add(this.numericUpDownIdProd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcMaterial);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CalculateMaterialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчёт количества необходимого материала";
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterPolDataSet)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKolvoProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource partnersBindingSource;
        private MasterPolDataSet masterPolDataSet;
        private MasterPolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MasterPolDataSetTableAdapters.PartnersTableAdapter partnersTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownIdProd;
        private System.Windows.Forms.NumericUpDown numericUpDownIdMaterial;
        private System.Windows.Forms.NumericUpDown numericUpDownKolvoProd;
    }
}