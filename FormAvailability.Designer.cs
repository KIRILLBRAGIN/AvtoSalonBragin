namespace AvtoSalon
{
    partial class FormAvailability
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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.listViewAvailability = new System.Windows.Forms.ListView();
            this.labelFirms = new System.Windows.Forms.Label();
            this.labelCars = new System.Windows.Forms.Label();
            this.comboBoxFirms = new System.Windows.Forms.ComboBox();
            this.comboBoxCars = new System.Windows.Forms.ComboBox();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdFirms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Firms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdCars = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cars = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(202, 133);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(283, 133);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(364, 133);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // listViewAvailability
            // 
            this.listViewAvailability.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewAvailability.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.IdFirms,
            this.Firms,
            this.IdCars,
            this.Cars});
            this.listViewAvailability.FullRowSelect = true;
            this.listViewAvailability.GridLines = true;
            this.listViewAvailability.HideSelection = false;
            this.listViewAvailability.Location = new System.Drawing.Point(202, 30);
            this.listViewAvailability.MultiSelect = false;
            this.listViewAvailability.Name = "listViewAvailability";
            this.listViewAvailability.Size = new System.Drawing.Size(431, 97);
            this.listViewAvailability.TabIndex = 3;
            this.listViewAvailability.UseCompatibleStateImageBehavior = false;
            this.listViewAvailability.View = System.Windows.Forms.View.Details;
            this.listViewAvailability.SelectedIndexChanged += new System.EventHandler(this.listViewAvailability_SelectedIndexChanged);
            // 
            // labelFirms
            // 
            this.labelFirms.AutoSize = true;
            this.labelFirms.Location = new System.Drawing.Point(40, 13);
            this.labelFirms.Name = "labelFirms";
            this.labelFirms.Size = new System.Drawing.Size(44, 13);
            this.labelFirms.TabIndex = 4;
            this.labelFirms.Text = "Фирма";
            // 
            // labelCars
            // 
            this.labelCars.AutoSize = true;
            this.labelCars.Location = new System.Drawing.Point(43, 73);
            this.labelCars.Name = "labelCars";
            this.labelCars.Size = new System.Drawing.Size(69, 13);
            this.labelCars.TabIndex = 5;
            this.labelCars.Text = "Автомобиль";
            // 
            // comboBoxFirms
            // 
            this.comboBoxFirms.FormattingEnabled = true;
            this.comboBoxFirms.Location = new System.Drawing.Point(43, 30);
            this.comboBoxFirms.Name = "comboBoxFirms";
            this.comboBoxFirms.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFirms.TabIndex = 6;
            // 
            // comboBoxCars
            // 
            this.comboBoxCars.FormattingEnabled = true;
            this.comboBoxCars.Location = new System.Drawing.Point(43, 90);
            this.comboBoxCars.Name = "comboBoxCars";
            this.comboBoxCars.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCars.TabIndex = 7;
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 26;
            // 
            // IdFirms
            // 
            this.IdFirms.Text = "ID фирмы";
            this.IdFirms.Width = 65;
            // 
            // Firms
            // 
            this.Firms.Text = "Фирма";
            this.Firms.Width = 107;
            // 
            // IdCars
            // 
            this.IdCars.Text = "ID автомобиля";
            this.IdCars.Width = 88;
            // 
            // Cars
            // 
            this.Cars.Text = "Автомобиль";
            this.Cars.Width = 123;
            // 
            // FormAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 174);
            this.Controls.Add(this.comboBoxCars);
            this.Controls.Add(this.comboBoxFirms);
            this.Controls.Add(this.labelCars);
            this.Controls.Add(this.labelFirms);
            this.Controls.Add(this.listViewAvailability);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonCreate);
            this.Name = "FormAvailability";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Наличие";
            this.Load += new System.EventHandler(this.FormAvailability_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ListView listViewAvailability;
        private System.Windows.Forms.Label labelFirms;
        private System.Windows.Forms.Label labelCars;
        private System.Windows.Forms.ComboBox comboBoxFirms;
        private System.Windows.Forms.ComboBox comboBoxCars;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader IdFirms;
        private System.Windows.Forms.ColumnHeader Firms;
        private System.Windows.Forms.ColumnHeader IdCars;
        private System.Windows.Forms.ColumnHeader Cars;
    }
}