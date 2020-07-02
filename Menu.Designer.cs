namespace AvtoSalon
{
    partial class Menu
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFirms = new System.Windows.Forms.Button();
            this.buttonCars = new System.Windows.Forms.Button();
            this.buttonAvailability = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFirms
            // 
            this.buttonFirms.Location = new System.Drawing.Point(237, 83);
            this.buttonFirms.Name = "buttonFirms";
            this.buttonFirms.Size = new System.Drawing.Size(120, 36);
            this.buttonFirms.TabIndex = 0;
            this.buttonFirms.Text = "Фирмы";
            this.buttonFirms.UseVisualStyleBackColor = true;
            this.buttonFirms.Click += new System.EventHandler(this.buttonFirms_Click);
            // 
            // buttonCars
            // 
            this.buttonCars.Location = new System.Drawing.Point(237, 143);
            this.buttonCars.Name = "buttonCars";
            this.buttonCars.Size = new System.Drawing.Size(120, 36);
            this.buttonCars.TabIndex = 1;
            this.buttonCars.Text = "Автомобили";
            this.buttonCars.UseVisualStyleBackColor = true;
            this.buttonCars.Click += new System.EventHandler(this.buttonCars_Click);
            // 
            // buttonAvailability
            // 
            this.buttonAvailability.Location = new System.Drawing.Point(237, 199);
            this.buttonAvailability.Name = "buttonAvailability";
            this.buttonAvailability.Size = new System.Drawing.Size(120, 42);
            this.buttonAvailability.TabIndex = 2;
            this.buttonAvailability.Text = "Наличие";
            this.buttonAvailability.UseVisualStyleBackColor = true;
            this.buttonAvailability.Click += new System.EventHandler(this.buttonAvailability_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 322);
            this.Controls.Add(this.buttonAvailability);
            this.Controls.Add(this.buttonCars);
            this.Controls.Add(this.buttonFirms);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFirms;
        private System.Windows.Forms.Button buttonCars;
        private System.Windows.Forms.Button buttonAvailability;
    }
}

