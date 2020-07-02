    namespace AvtoSalon
{
    partial class FormCars
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
            this.labelModel = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelGosNumber = new System.Windows.Forms.Label();
            this.labelYear_Relase = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.listViewCars = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GosNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Release_Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.maskedTextBoxGosNumber = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxYearRelase = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(12, 9);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(46, 13);
            this.labelModel.TabIndex = 0;
            this.labelModel.Text = "Модель";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(12, 51);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(32, 13);
            this.labelColor.TabIndex = 1;
            this.labelColor.Text = "Цвет";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(12, 96);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 13);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Цена";
            // 
            // labelGosNumber
            // 
            this.labelGosNumber.AutoSize = true;
            this.labelGosNumber.Location = new System.Drawing.Point(12, 138);
            this.labelGosNumber.Name = "labelGosNumber";
            this.labelGosNumber.Size = new System.Drawing.Size(132, 13);
            this.labelGosNumber.TabIndex = 3;
            this.labelGosNumber.Text = "Государственный номер";
            // 
            // labelYear_Relase
            // 
            this.labelYear_Relase.AutoSize = true;
            this.labelYear_Relase.Location = new System.Drawing.Point(12, 176);
            this.labelYear_Relase.Name = "labelYear_Relase";
            this.labelYear_Relase.Size = new System.Drawing.Size(71, 13);
            this.labelYear_Relase.TabIndex = 4;
            this.labelYear_Relase.Text = "Год выпуска";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(241, 195);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 5;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(322, 195);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(403, 195);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 7;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // listViewCars
            // 
            this.listViewCars.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewCars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Model,
            this.Color,
            this.Price,
            this.GosNumber,
            this.Release_Year});
            this.listViewCars.FullRowSelect = true;
            this.listViewCars.GridLines = true;
            this.listViewCars.HideSelection = false;
            this.listViewCars.Location = new System.Drawing.Point(241, 16);
            this.listViewCars.MultiSelect = false;
            this.listViewCars.Name = "listViewCars";
            this.listViewCars.Size = new System.Drawing.Size(439, 173);
            this.listViewCars.TabIndex = 8;
            this.listViewCars.UseCompatibleStateImageBehavior = false;
            this.listViewCars.View = System.Windows.Forms.View.Details;
            this.listViewCars.SelectedIndexChanged += new System.EventHandler(this.listViewCars_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 26;
            // 
            // Model
            // 
            this.Model.Text = "Модель";
            // 
            // Color
            // 
            this.Color.Text = "Цвет";
            // 
            // Price
            // 
            this.Price.Text = "Цена";
            this.Price.Width = 83;
            // 
            // GosNumber
            // 
            this.GosNumber.Text = "Гос. номер";
            this.GosNumber.Width = 72;
            // 
            // Release_Year
            // 
            this.Release_Year.Text = "Год выпуска";
            this.Release_Year.Width = 75;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(15, 25);
            this.textBoxModel.Multiline = true;
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxModel.TabIndex = 9;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(15, 113);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 11;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_TextChanged);
            // 
            // maskedTextBoxGosNumber
            // 
            this.maskedTextBoxGosNumber.Location = new System.Drawing.Point(15, 155);
            this.maskedTextBoxGosNumber.Mask = "L000LL";
            this.maskedTextBoxGosNumber.Name = "maskedTextBoxGosNumber";
            this.maskedTextBoxGosNumber.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxGosNumber.TabIndex = 12;
            // 
            // maskedTextBoxYearRelase
            // 
            this.maskedTextBoxYearRelase.Location = new System.Drawing.Point(15, 193);
            this.maskedTextBoxYearRelase.Mask = "0000";
            this.maskedTextBoxYearRelase.Name = "maskedTextBoxYearRelase";
            this.maskedTextBoxYearRelase.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxYearRelase.TabIndex = 13;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Серый",
            "Чёрный",
            "Белый",
            "Красный",
            "Синий",
            "Зелёный",
            "Жёлтый",
            "Рыжий"});
            this.comboBoxColor.Location = new System.Drawing.Point(15, 68);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxColor.TabIndex = 14;
            // 
            // FormCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 244);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.maskedTextBoxYearRelase);
            this.Controls.Add(this.maskedTextBoxGosNumber);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.listViewCars);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelYear_Relase);
            this.Controls.Add(this.labelGosNumber);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelModel);
            this.Name = "FormCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автомобили";
            this.Load += new System.EventHandler(this.FormCars_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelGosNumber;
        private System.Windows.Forms.Label labelYear_Relase;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ListView listViewCars;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Color;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader GosNumber;
        private System.Windows.Forms.ColumnHeader Release_Year;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxGosNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxYearRelase;
        private System.Windows.Forms.ComboBox comboBoxColor;
    }
}