namespace Estacionamiento
{
    partial class carroAlta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(carroAlta));
            this.pnlAlta = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCarBrand = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.pnlAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAlta
            // 
            this.pnlAlta.BackColor = System.Drawing.Color.Transparent;
            this.pnlAlta.Controls.Add(this.label1);
            this.pnlAlta.Controls.Add(this.label4);
            this.pnlAlta.Controls.Add(this.btnAlta);
            this.pnlAlta.Controls.Add(this.label3);
            this.pnlAlta.Controls.Add(this.txtPlate);
            this.pnlAlta.Controls.Add(this.label2);
            this.pnlAlta.Controls.Add(this.txtCarBrand);
            this.pnlAlta.Controls.Add(this.txtModel);
            this.pnlAlta.Controls.Add(this.txtColor);
            this.pnlAlta.Location = new System.Drawing.Point(33, 25);
            this.pnlAlta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAlta.Name = "pnlAlta";
            this.pnlAlta.Size = new System.Drawing.Size(299, 258);
            this.pnlAlta.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Placas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "Color:";
            // 
            // btnAlta
            // 
            this.btnAlta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlta.BackgroundImage")));
            this.btnAlta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlta.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.Location = new System.Drawing.Point(65, 172);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(161, 63);
            this.btnAlta.TabIndex = 6;
            this.btnAlta.Text = "&";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 30;
            this.label3.Text = "Modelo:";
            // 
            // txtplacas
            // 
            this.txtPlate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlate.Location = new System.Drawing.Point(128, 18);
            this.txtPlate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlate.Name = "txtplacas";
            this.txtPlate.Size = new System.Drawing.Size(132, 29);
            this.txtPlate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "Marca:";
            // 
            // txtmarca
            // 
            this.txtCarBrand.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarBrand.Location = new System.Drawing.Point(128, 50);
            this.txtCarBrand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCarBrand.Name = "txtmarca";
            this.txtCarBrand.Size = new System.Drawing.Size(132, 29);
            this.txtCarBrand.TabIndex = 3;
            // 
            // txtmodelo
            // 
            this.txtModel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(128, 82);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModel.Name = "txtmodelo";
            this.txtModel.Size = new System.Drawing.Size(132, 29);
            this.txtModel.TabIndex = 4;
            // 
            // txtcolor
            // 
            this.txtColor.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(128, 114);
            this.txtColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtColor.Name = "txtcolor";
            this.txtColor.Size = new System.Drawing.Size(132, 29);
            this.txtColor.TabIndex = 5;
            // 
            // carroAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(371, 298);
            this.Controls.Add(this.pnlAlta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "carroAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "carroAlta";
            this.pnlAlta.ResumeLayout(false);
            this.pnlAlta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAlta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCarBrand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtColor;
    }
}