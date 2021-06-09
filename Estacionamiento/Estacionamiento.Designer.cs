namespace Estacionamiento
{
    partial class Estacionamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estacionamiento));
            this.dgvParking = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblMTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.pnlsalida = new System.Windows.Forms.Panel();
            this.lblout = new System.Windows.Forms.Label();
            this.lblin = new System.Windows.Forms.Label();
            this.lblPlacas1 = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblModelo2 = new System.Windows.Forms.Label();
            this.txtplacas2 = new System.Windows.Forms.TextBox();
            this.lblMarca2 = new System.Windows.Forms.Label();
            this.txtmarca2 = new System.Windows.Forms.TextBox();
            this.txtmodelo2 = new System.Windows.Forms.TextBox();
            this.txtcolor2 = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblpuntos1 = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.lblSegI = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMinI = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHoraI = new System.Windows.Forms.Label();
            this.lblSegS = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMinS = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblHoraS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParking)).BeginInit();
            this.pnlsalida.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvParking
            // 
            this.dgvParking.AllowUserToAddRows = false;
            this.dgvParking.AllowUserToDeleteRows = false;
            this.dgvParking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParking.Location = new System.Drawing.Point(12, 22);
            this.dgvParking.Name = "dgvParking";
            this.dgvParking.ReadOnly = true;
            this.dgvParking.Size = new System.Drawing.Size(115, 461);
            this.dgvParking.TabIndex = 0;
            this.dgvParking.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParking_CellDoubleClick);
            // 
            // btnNew
            // 
            this.btnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNew.BackgroundImage")));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(261, 74);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(121, 51);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "&";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblMTotal
            // 
            this.lblMTotal.AutoSize = true;
            this.lblMTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblMTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMTotal.ForeColor = System.Drawing.Color.White;
            this.lblMTotal.Location = new System.Drawing.Point(479, 189);
            this.lblMTotal.Name = "lblMTotal";
            this.lblMTotal.Size = new System.Drawing.Size(54, 20);
            this.lblMTotal.TabIndex = 33;
            this.lblMTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(540, 189);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(61, 20);
            this.txtTotal.TabIndex = 34;
            // 
            // pnlsalida
            // 
            this.pnlsalida.BackColor = System.Drawing.Color.Transparent;
            this.pnlsalida.Controls.Add(this.lblout);
            this.pnlsalida.Controls.Add(this.lblin);
            this.pnlsalida.Controls.Add(this.lblPlacas1);
            this.pnlsalida.Controls.Add(this.lblColor);
            this.pnlsalida.Controls.Add(this.btnSalir);
            this.pnlsalida.Controls.Add(this.lblModelo2);
            this.pnlsalida.Controls.Add(this.txtplacas2);
            this.pnlsalida.Controls.Add(this.lblMarca2);
            this.pnlsalida.Controls.Add(this.txtmarca2);
            this.pnlsalida.Controls.Add(this.txtmodelo2);
            this.pnlsalida.Controls.Add(this.txtcolor2);
            this.pnlsalida.Location = new System.Drawing.Point(176, 228);
            this.pnlsalida.Name = "pnlsalida";
            this.pnlsalida.Size = new System.Drawing.Size(291, 255);
            this.pnlsalida.TabIndex = 33;
            this.pnlsalida.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlsalida_Paint);
            // 
            // lblout
            // 
            this.lblout.AutoSize = true;
            this.lblout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblout.ForeColor = System.Drawing.Color.White;
            this.lblout.Location = new System.Drawing.Point(27, 149);
            this.lblout.Name = "lblout";
            this.lblout.Size = new System.Drawing.Size(52, 19);
            this.lblout.TabIndex = 35;
            this.lblout.Text = "Salida:";
            // 
            // lblin
            // 
            this.lblin.AutoSize = true;
            this.lblin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblin.ForeColor = System.Drawing.Color.White;
            this.lblin.Location = new System.Drawing.Point(27, 123);
            this.lblin.Name = "lblin";
            this.lblin.Size = new System.Drawing.Size(63, 19);
            this.lblin.TabIndex = 33;
            this.lblin.Text = "Entrada:";
            // 
            // lblPlacas1
            // 
            this.lblPlacas1.AutoSize = true;
            this.lblPlacas1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacas1.ForeColor = System.Drawing.Color.White;
            this.lblPlacas1.Location = new System.Drawing.Point(27, 18);
            this.lblPlacas1.Name = "lblPlacas1";
            this.lblPlacas1.Size = new System.Drawing.Size(55, 19);
            this.lblPlacas1.TabIndex = 28;
            this.lblPlacas1.Text = "Placas:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.White;
            this.lblColor.Location = new System.Drawing.Point(27, 96);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(47, 19);
            this.lblColor.TabIndex = 31;
            this.lblColor.Text = "Color:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(85, 192);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 51);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "&";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblModelo2
            // 
            this.lblModelo2.AutoSize = true;
            this.lblModelo2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo2.ForeColor = System.Drawing.Color.White;
            this.lblModelo2.Location = new System.Drawing.Point(27, 70);
            this.lblModelo2.Name = "lblModelo2";
            this.lblModelo2.Size = new System.Drawing.Size(62, 19);
            this.lblModelo2.TabIndex = 30;
            this.lblModelo2.Text = "Modelo:";
            // 
            // txtplacas2
            // 
            this.txtplacas2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplacas2.Location = new System.Drawing.Point(93, 15);
            this.txtplacas2.Name = "txtplacas2";
            this.txtplacas2.Size = new System.Drawing.Size(100, 25);
            this.txtplacas2.TabIndex = 23;
            // 
            // lblMarca2
            // 
            this.lblMarca2.AutoSize = true;
            this.lblMarca2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca2.ForeColor = System.Drawing.Color.White;
            this.lblMarca2.Location = new System.Drawing.Point(27, 44);
            this.lblMarca2.Name = "lblMarca2";
            this.lblMarca2.Size = new System.Drawing.Size(54, 19);
            this.lblMarca2.TabIndex = 29;
            this.lblMarca2.Text = "Marca:";
            // 
            // txtmarca2
            // 
            this.txtmarca2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmarca2.Location = new System.Drawing.Point(93, 41);
            this.txtmarca2.Name = "txtmarca2";
            this.txtmarca2.Size = new System.Drawing.Size(100, 25);
            this.txtmarca2.TabIndex = 24;
            // 
            // txtmodelo2
            // 
            this.txtmodelo2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodelo2.Location = new System.Drawing.Point(93, 67);
            this.txtmodelo2.Name = "txtmodelo2";
            this.txtmodelo2.Size = new System.Drawing.Size(100, 25);
            this.txtmodelo2.TabIndex = 26;
            // 
            // txtcolor2
            // 
            this.txtcolor2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcolor2.Location = new System.Drawing.Point(93, 93);
            this.txtcolor2.Name = "txtcolor2";
            this.txtcolor2.Size = new System.Drawing.Size(100, 25);
            this.txtcolor2.TabIndex = 27;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(499, 420);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 51);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "&";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(291, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Entrada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(173, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Salida:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(497, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Ganancias";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(517, 284);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(34, 13);
            this.lblHora.TabIndex = 41;
            this.lblHora.Text = "Hora";
            // 
            // lblpuntos1
            // 
            this.lblpuntos1.AutoSize = true;
            this.lblpuntos1.BackColor = System.Drawing.Color.Transparent;
            this.lblpuntos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpuntos1.ForeColor = System.Drawing.Color.White;
            this.lblpuntos1.Location = new System.Drawing.Point(583, 284);
            this.lblpuntos1.Name = "lblpuntos1";
            this.lblpuntos1.Size = new System.Drawing.Size(11, 13);
            this.lblpuntos1.TabIndex = 42;
            this.lblpuntos1.Text = ":";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.BackColor = System.Drawing.Color.Transparent;
            this.lblMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutos.ForeColor = System.Drawing.Color.White;
            this.lblMinutos.Location = new System.Drawing.Point(557, 284);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(27, 13);
            this.lblMinutos.TabIndex = 44;
            this.lblMinutos.Text = "Min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(551, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = ":";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.BackColor = System.Drawing.Color.Transparent;
            this.lblSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.ForeColor = System.Drawing.Color.White;
            this.lblSegundos.Location = new System.Drawing.Point(591, 284);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(29, 13);
            this.lblSegundos.TabIndex = 46;
            this.lblSegundos.Text = "Seg";
            // 
            // lblSegI
            // 
            this.lblSegI.AutoSize = true;
            this.lblSegI.BackColor = System.Drawing.Color.Transparent;
            this.lblSegI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegI.ForeColor = System.Drawing.Color.White;
            this.lblSegI.Location = new System.Drawing.Point(343, 354);
            this.lblSegI.Name = "lblSegI";
            this.lblSegI.Size = new System.Drawing.Size(29, 13);
            this.lblSegI.TabIndex = 51;
            this.lblSegI.Text = "Seg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(300, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = ":";
            // 
            // lblMinI
            // 
            this.lblMinI.AutoSize = true;
            this.lblMinI.BackColor = System.Drawing.Color.Transparent;
            this.lblMinI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinI.ForeColor = System.Drawing.Color.White;
            this.lblMinI.Location = new System.Drawing.Point(309, 354);
            this.lblMinI.Name = "lblMinI";
            this.lblMinI.Size = new System.Drawing.Size(27, 13);
            this.lblMinI.TabIndex = 49;
            this.lblMinI.Text = "Min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(335, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = ":";
            // 
            // lblHoraI
            // 
            this.lblHoraI.AutoSize = true;
            this.lblHoraI.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraI.ForeColor = System.Drawing.Color.White;
            this.lblHoraI.Location = new System.Drawing.Point(269, 354);
            this.lblHoraI.Name = "lblHoraI";
            this.lblHoraI.Size = new System.Drawing.Size(34, 13);
            this.lblHoraI.TabIndex = 47;
            this.lblHoraI.Text = "Hora";
            // 
            // lblSegS
            // 
            this.lblSegS.AutoSize = true;
            this.lblSegS.BackColor = System.Drawing.Color.Transparent;
            this.lblSegS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegS.ForeColor = System.Drawing.Color.White;
            this.lblSegS.Location = new System.Drawing.Point(343, 380);
            this.lblSegS.Name = "lblSegS";
            this.lblSegS.Size = new System.Drawing.Size(29, 13);
            this.lblSegS.TabIndex = 56;
            this.lblSegS.Text = "Seg";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(301, 380);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = ":";
            // 
            // lblMinS
            // 
            this.lblMinS.AutoSize = true;
            this.lblMinS.BackColor = System.Drawing.Color.Transparent;
            this.lblMinS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinS.ForeColor = System.Drawing.Color.White;
            this.lblMinS.Location = new System.Drawing.Point(309, 380);
            this.lblMinS.Name = "lblMinS";
            this.lblMinS.Size = new System.Drawing.Size(27, 13);
            this.lblMinS.TabIndex = 54;
            this.lblMinS.Text = "Min";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(335, 380);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = ":";
            // 
            // lblHoraS
            // 
            this.lblHoraS.AutoSize = true;
            this.lblHoraS.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraS.ForeColor = System.Drawing.Color.White;
            this.lblHoraS.Location = new System.Drawing.Point(269, 380);
            this.lblHoraS.Name = "lblHoraS";
            this.lblHoraS.Size = new System.Drawing.Size(34, 13);
            this.lblHoraS.TabIndex = 52;
            this.lblHoraS.Text = "Hora";
            // 
            // Estacionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(646, 494);
            this.Controls.Add(this.lblSegS);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblMinS);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblHoraS);
            this.Controls.Add(this.lblSegI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMinI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHoraI);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.lblpuntos1);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlsalida);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblMTotal);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvParking);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Estacionamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estacionamiento";
            this.Load += new System.EventHandler(this.Estacionamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParking)).EndInit();
            this.pnlsalida.ResumeLayout(false);
            this.pnlsalida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParking;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblMTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Panel pnlsalida;
        private System.Windows.Forms.Label lblPlacas1;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblModelo2;
        private System.Windows.Forms.TextBox txtplacas2;
        private System.Windows.Forms.Label lblMarca2;
        private System.Windows.Forms.TextBox txtmarca2;
        private System.Windows.Forms.TextBox txtmodelo2;
        private System.Windows.Forms.TextBox txtcolor2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblpuntos1;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Label lblout;
        private System.Windows.Forms.Label lblin;
        private System.Windows.Forms.Label lblSegI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMinI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHoraI;
        private System.Windows.Forms.Label lblSegS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMinS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblHoraS;
    }
}