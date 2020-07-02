namespace AvtoSalon
{
    partial class FormFirms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewFirms = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameFirm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxNameFirm = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название фирмы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Город";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Телефон";
            // 
            // listViewFirms
            // 
            this.listViewFirms.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewFirms.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewFirms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.NameFirm,
            this.Address,
            this.Phone});
            this.listViewFirms.FullRowSelect = true;
            this.listViewFirms.GridLines = true;
            this.listViewFirms.Location = new System.Drawing.Point(319, 46);
            this.listViewFirms.MultiSelect = false;
            this.listViewFirms.Name = "listViewFirms";
            this.listViewFirms.Size = new System.Drawing.Size(362, 190);
            this.listViewFirms.TabIndex = 4;
            this.listViewFirms.UseCompatibleStateImageBehavior = false;
            this.listViewFirms.View = System.Windows.Forms.View.Details;
            this.listViewFirms.SelectedIndexChanged += new System.EventHandler(this.listViewFirms_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "ID";
            // 
            // NameFirm
            // 
            this.NameFirm.Text = "Название";
            this.NameFirm.Width = 97;
            // 
            // Address
            // 
            this.Address.Text = "Адрес";
            this.Address.Width = 114;
            // 
            // Phone
            // 
            this.Phone.Text = "Телефон";
            this.Phone.Width = 87;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(319, 260);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 5;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(400, 260);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(481, 260);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 7;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // textBoxNameFirm
            // 
            this.textBoxNameFirm.Location = new System.Drawing.Point(34, 62);
            this.textBoxNameFirm.Multiline = true;
            this.textBoxNameFirm.Name = "textBoxNameFirm";
            this.textBoxNameFirm.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameFirm.TabIndex = 8;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(34, 118);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress.TabIndex = 9;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(34, 174);
            this.textBoxCity.Multiline = true;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxCity.TabIndex = 10;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(34, 239);
            this.textBoxPhone.Multiline = true;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhone.TabIndex = 11;
            // 
            // FormFirms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 335);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxNameFirm);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.listViewFirms);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormFirms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фирмы";
            this.Load += new System.EventHandler(this.FormFirms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewFirms;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader NameFirm;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.TextBox textBoxNameFirm;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxPhone;
    }
}