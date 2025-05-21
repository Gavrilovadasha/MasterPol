namespace MasterPol.CustomControls
{
    partial class PartnersControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTypeAndName = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelRaiting = new System.Windows.Forms.Label();
            this.labelSale = new System.Windows.Forms.Label();
            this.btnHistoryPartners = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTypeAndName
            // 
            this.labelTypeAndName.AutoSize = true;
            this.labelTypeAndName.Location = new System.Drawing.Point(27, 18);
            this.labelTypeAndName.Name = "labelTypeAndName";
            this.labelTypeAndName.Size = new System.Drawing.Size(162, 21);
            this.labelTypeAndName.TabIndex = 0;
            this.labelTypeAndName.Text = "Тип и наименование";
            this.labelTypeAndName.Click += new System.EventHandler(this.UpdatePartners_Click);
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Location = new System.Drawing.Point(28, 52);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(88, 21);
            this.labelDirector.TabIndex = 1;
            this.labelDirector.Text = "Директор";
            this.labelDirector.Click += new System.EventHandler(this.UpdatePartners_Click);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(27, 86);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(75, 21);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Телефон";
            this.labelPhone.Click += new System.EventHandler(this.UpdatePartners_Click);
            // 
            // labelRaiting
            // 
            this.labelRaiting.AutoSize = true;
            this.labelRaiting.Location = new System.Drawing.Point(25, 119);
            this.labelRaiting.Name = "labelRaiting";
            this.labelRaiting.Size = new System.Drawing.Size(76, 21);
            this.labelRaiting.TabIndex = 3;
            this.labelRaiting.Text = "Рейтинг";
            this.labelRaiting.Click += new System.EventHandler(this.UpdatePartners_Click);
            // 
            // labelSale
            // 
            this.labelSale.AutoSize = true;
            this.labelSale.Location = new System.Drawing.Point(679, 63);
            this.labelSale.Name = "labelSale";
            this.labelSale.Size = new System.Drawing.Size(63, 21);
            this.labelSale.TabIndex = 4;
            this.labelSale.Text = "Скидка";
            this.labelSale.Click += new System.EventHandler(this.UpdatePartners_Click);
            // 
            // btnHistoryPartners
            // 
            this.btnHistoryPartners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnHistoryPartners.ForeColor = System.Drawing.Color.White;
            this.btnHistoryPartners.Location = new System.Drawing.Point(519, 108);
            this.btnHistoryPartners.Name = "btnHistoryPartners";
            this.btnHistoryPartners.Size = new System.Drawing.Size(223, 32);
            this.btnHistoryPartners.TabIndex = 5;
            this.btnHistoryPartners.Text = "История о партнере";
            this.btnHistoryPartners.UseVisualStyleBackColor = false;
            this.btnHistoryPartners.Click += new System.EventHandler(this.btnHistoryPartners_Click);
            // 
            // PartnersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(211)))));
            this.Controls.Add(this.btnHistoryPartners);
            this.Controls.Add(this.labelSale);
            this.Controls.Add(this.labelRaiting);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.labelTypeAndName);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PartnersControl";
            this.Size = new System.Drawing.Size(770, 160);
            this.Click += new System.EventHandler(this.UpdatePartners_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTypeAndName;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelRaiting;
        private System.Windows.Forms.Label labelSale;
        private System.Windows.Forms.Button btnHistoryPartners;
    }
}
