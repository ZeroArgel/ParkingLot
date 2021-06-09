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
            this.BtnNew = new System.Windows.Forms.Button();
            this.lblMTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.pnlsalida = new System.Windows.Forms.Panel();
            this.BtnCancelCarSelect = new System.Windows.Forms.Button();
            this.lblPay = new System.Windows.Forms.Label();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.lblSegS = new System.Windows.Forms.Label();
            this.lblout = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblin = new System.Windows.Forms.Label();
            this.lblPlacas1 = new System.Windows.Forms.Label();
            this.lblMinS = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblSegI = new System.Windows.Forms.Label();
            this.BtnPay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHoraS = new System.Windows.Forms.Label();
            this.lblMinI = new System.Windows.Forms.Label();
            this.lblModelo2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtplacas2 = new System.Windows.Forms.TextBox();
            this.lblMarca2 = new System.Windows.Forms.Label();
            this.txtmarca2 = new System.Windows.Forms.TextBox();
            this.txtmodelo2 = new System.Windows.Forms.TextBox();
            this.lblHoraI = new System.Windows.Forms.Label();
            this.txtcolor2 = new System.Windows.Forms.TextBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.dgvParking.Location = new System.Drawing.Point(16, 27);
            this.dgvParking.Margin = new System.Windows.Forms.Padding(4);
            this.dgvParking.Name = "dgvParking";
            this.dgvParking.ReadOnly = true;
            this.dgvParking.RowHeadersWidth = 51;
            this.dgvParking.Size = new System.Drawing.Size(153, 567);
            this.dgvParking.TabIndex = 0;
            this.dgvParking.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvParking_CellDoubleClick);
            // 
            // BtnNew
            // 
            this.BtnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNew.BackgroundImage")));
            this.BtnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNew.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.Location = new System.Drawing.Point(238, 171);
            this.BtnNew.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(161, 63);
            this.BtnNew.TabIndex = 1;
            this.BtnNew.Text = "&";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // lblMTotal
            // 
            this.lblMTotal.AutoSize = true;
            this.lblMTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblMTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMTotal.ForeColor = System.Drawing.Color.White;
            this.lblMTotal.Location = new System.Drawing.Point(674, 61);
            this.lblMTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMTotal.Name = "lblMTotal";
            this.lblMTotal.Size = new System.Drawing.Size(68, 25);
            this.lblMTotal.TabIndex = 33;
            this.lblMTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(755, 61);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(80, 22);
            this.txtTotal.TabIndex = 34;
            // 
            // pnlsalida
            // 
            this.pnlsalida.BackColor = System.Drawing.Color.Transparent;
            this.pnlsalida.Controls.Add(this.BtnCancelCarSelect);
            this.pnlsalida.Controls.Add(this.lblPay);
            this.pnlsalida.Controls.Add(this.txtPay);
            this.pnlsalida.Controls.Add(this.lblSegS);
            this.pnlsalida.Controls.Add(this.lblout);
            this.pnlsalida.Controls.Add(this.label11);
            this.pnlsalida.Controls.Add(this.lblin);
            this.pnlsalida.Controls.Add(this.lblPlacas1);
            this.pnlsalida.Controls.Add(this.lblMinS);
            this.pnlsalida.Controls.Add(this.label13);
            this.pnlsalida.Controls.Add(this.lblColor);
            this.pnlsalida.Controls.Add(this.lblSegI);
            this.pnlsalida.Controls.Add(this.BtnPay);
            this.pnlsalida.Controls.Add(this.label2);
            this.pnlsalida.Controls.Add(this.lblHoraS);
            this.pnlsalida.Controls.Add(this.lblMinI);
            this.pnlsalida.Controls.Add(this.lblModelo2);
            this.pnlsalida.Controls.Add(this.label4);
            this.pnlsalida.Controls.Add(this.txtplacas2);
            this.pnlsalida.Controls.Add(this.lblMarca2);
            this.pnlsalida.Controls.Add(this.txtmarca2);
            this.pnlsalida.Controls.Add(this.txtmodelo2);
            this.pnlsalida.Controls.Add(this.lblHoraI);
            this.pnlsalida.Controls.Add(this.txtcolor2);
            this.pnlsalida.Location = new System.Drawing.Point(235, 281);
            this.pnlsalida.Margin = new System.Windows.Forms.Padding(4);
            this.pnlsalida.Name = "pnlsalida";
            this.pnlsalida.Size = new System.Drawing.Size(388, 356);
            this.pnlsalida.TabIndex = 33;
            // 
            // BtnCancelCarSelect
            // 
            this.BtnCancelCarSelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCancelCarSelect.BackgroundImage")));
            this.BtnCancelCarSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCancelCarSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelCarSelect.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelCarSelect.Location = new System.Drawing.Point(287, 22);
            this.BtnCancelCarSelect.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelCarSelect.Name = "BtnCancelCarSelect";
            this.BtnCancelCarSelect.Size = new System.Drawing.Size(81, 35);
            this.BtnCancelCarSelect.TabIndex = 47;
            this.BtnCancelCarSelect.Text = "&";
            this.BtnCancelCarSelect.UseVisualStyleBackColor = true;
            this.BtnCancelCarSelect.Click += new System.EventHandler(this.BtnCancelCarSelect_Click);
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay.ForeColor = System.Drawing.Color.White;
            this.lblPay.Location = new System.Drawing.Point(36, 146);
            this.lblPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(78, 24);
            this.lblPay.TabIndex = 58;
            this.lblPay.Text = "A Pagar:";
            // 
            // txtPay
            // 
            this.txtPay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPay.Location = new System.Drawing.Point(124, 146);
            this.txtPay.Margin = new System.Windows.Forms.Padding(4);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(132, 29);
            this.txtPay.TabIndex = 57;
            // 
            // lblSegS
            // 
            this.lblSegS.AutoSize = true;
            this.lblSegS.BackColor = System.Drawing.Color.Transparent;
            this.lblSegS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegS.ForeColor = System.Drawing.Color.White;
            this.lblSegS.Location = new System.Drawing.Point(220, 224);
            this.lblSegS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSegS.Name = "lblSegS";
            this.lblSegS.Size = new System.Drawing.Size(36, 17);
            this.lblSegS.TabIndex = 56;
            this.lblSegS.Text = "Seg";
            // 
            // lblout
            // 
            this.lblout.AutoSize = true;
            this.lblout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblout.ForeColor = System.Drawing.Color.White;
            this.lblout.Location = new System.Drawing.Point(21, 219);
            this.lblout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblout.Name = "lblout";
            this.lblout.Size = new System.Drawing.Size(65, 24);
            this.lblout.TabIndex = 35;
            this.lblout.Text = "Salida:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(164, 224);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 17);
            this.label11.TabIndex = 55;
            this.label11.Text = ":";
            // 
            // lblin
            // 
            this.lblin.AutoSize = true;
            this.lblin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblin.ForeColor = System.Drawing.Color.White;
            this.lblin.Location = new System.Drawing.Point(21, 187);
            this.lblin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblin.Name = "lblin";
            this.lblin.Size = new System.Drawing.Size(81, 24);
            this.lblin.TabIndex = 33;
            this.lblin.Text = "Entrada:";
            // 
            // lblPlacas1
            // 
            this.lblPlacas1.AutoSize = true;
            this.lblPlacas1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacas1.ForeColor = System.Drawing.Color.White;
            this.lblPlacas1.Location = new System.Drawing.Point(36, 22);
            this.lblPlacas1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlacas1.Name = "lblPlacas1";
            this.lblPlacas1.Size = new System.Drawing.Size(66, 24);
            this.lblPlacas1.TabIndex = 28;
            this.lblPlacas1.Text = "Placas:";
            // 
            // lblMinS
            // 
            this.lblMinS.AutoSize = true;
            this.lblMinS.BackColor = System.Drawing.Color.Transparent;
            this.lblMinS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinS.ForeColor = System.Drawing.Color.White;
            this.lblMinS.Location = new System.Drawing.Point(175, 224);
            this.lblMinS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinS.Name = "lblMinS";
            this.lblMinS.Size = new System.Drawing.Size(33, 17);
            this.lblMinS.TabIndex = 54;
            this.lblMinS.Text = "Min";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(210, 224);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 17);
            this.label13.TabIndex = 53;
            this.label13.Text = ":";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.White;
            this.lblColor.Location = new System.Drawing.Point(36, 114);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(60, 24);
            this.lblColor.TabIndex = 31;
            this.lblColor.Text = "Color:";
            // 
            // lblSegI
            // 
            this.lblSegI.AutoSize = true;
            this.lblSegI.BackColor = System.Drawing.Color.Transparent;
            this.lblSegI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegI.ForeColor = System.Drawing.Color.White;
            this.lblSegI.Location = new System.Drawing.Point(220, 192);
            this.lblSegI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSegI.Name = "lblSegI";
            this.lblSegI.Size = new System.Drawing.Size(36, 17);
            this.lblSegI.TabIndex = 51;
            this.lblSegI.Text = "Seg";
            // 
            // BtnPay
            // 
            this.BtnPay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPay.BackgroundImage")));
            this.BtnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPay.Location = new System.Drawing.Point(113, 279);
            this.BtnPay.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(161, 63);
            this.BtnPay.TabIndex = 7;
            this.BtnPay.Text = "&";
            this.BtnPay.UseVisualStyleBackColor = true;
            this.BtnPay.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(163, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = ":";
            // 
            // lblHoraS
            // 
            this.lblHoraS.AutoSize = true;
            this.lblHoraS.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraS.ForeColor = System.Drawing.Color.White;
            this.lblHoraS.Location = new System.Drawing.Point(121, 224);
            this.lblHoraS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraS.Name = "lblHoraS";
            this.lblHoraS.Size = new System.Drawing.Size(43, 17);
            this.lblHoraS.TabIndex = 52;
            this.lblHoraS.Text = "Hora";
            // 
            // lblMinI
            // 
            this.lblMinI.AutoSize = true;
            this.lblMinI.BackColor = System.Drawing.Color.Transparent;
            this.lblMinI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinI.ForeColor = System.Drawing.Color.White;
            this.lblMinI.Location = new System.Drawing.Point(175, 192);
            this.lblMinI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinI.Name = "lblMinI";
            this.lblMinI.Size = new System.Drawing.Size(33, 17);
            this.lblMinI.TabIndex = 49;
            this.lblMinI.Text = "Min";
            // 
            // lblModelo2
            // 
            this.lblModelo2.AutoSize = true;
            this.lblModelo2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo2.ForeColor = System.Drawing.Color.White;
            this.lblModelo2.Location = new System.Drawing.Point(36, 86);
            this.lblModelo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModelo2.Name = "lblModelo2";
            this.lblModelo2.Size = new System.Drawing.Size(80, 24);
            this.lblModelo2.TabIndex = 30;
            this.lblModelo2.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(210, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = ":";
            // 
            // txtplacas2
            // 
            this.txtplacas2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplacas2.Location = new System.Drawing.Point(124, 18);
            this.txtplacas2.Margin = new System.Windows.Forms.Padding(4);
            this.txtplacas2.Name = "txtplacas2";
            this.txtplacas2.Size = new System.Drawing.Size(132, 29);
            this.txtplacas2.TabIndex = 23;
            // 
            // lblMarca2
            // 
            this.lblMarca2.AutoSize = true;
            this.lblMarca2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca2.ForeColor = System.Drawing.Color.White;
            this.lblMarca2.Location = new System.Drawing.Point(36, 54);
            this.lblMarca2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca2.Name = "lblMarca2";
            this.lblMarca2.Size = new System.Drawing.Size(67, 24);
            this.lblMarca2.TabIndex = 29;
            this.lblMarca2.Text = "Marca:";
            // 
            // txtmarca2
            // 
            this.txtmarca2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmarca2.Location = new System.Drawing.Point(124, 50);
            this.txtmarca2.Margin = new System.Windows.Forms.Padding(4);
            this.txtmarca2.Name = "txtmarca2";
            this.txtmarca2.Size = new System.Drawing.Size(132, 29);
            this.txtmarca2.TabIndex = 24;
            // 
            // txtmodelo2
            // 
            this.txtmodelo2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodelo2.Location = new System.Drawing.Point(124, 82);
            this.txtmodelo2.Margin = new System.Windows.Forms.Padding(4);
            this.txtmodelo2.Name = "txtmodelo2";
            this.txtmodelo2.Size = new System.Drawing.Size(132, 29);
            this.txtmodelo2.TabIndex = 26;
            // 
            // lblHoraI
            // 
            this.lblHoraI.AutoSize = true;
            this.lblHoraI.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraI.ForeColor = System.Drawing.Color.White;
            this.lblHoraI.Location = new System.Drawing.Point(121, 192);
            this.lblHoraI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraI.Name = "lblHoraI";
            this.lblHoraI.Size = new System.Drawing.Size(43, 17);
            this.lblHoraI.TabIndex = 47;
            this.lblHoraI.Text = "Hora";
            // 
            // txtcolor2
            // 
            this.txtcolor2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcolor2.Location = new System.Drawing.Point(124, 114);
            this.txtcolor2.Margin = new System.Windows.Forms.Padding(4);
            this.txtcolor2.Name = "txtcolor2";
            this.txtcolor2.Size = new System.Drawing.Size(132, 29);
            this.txtcolor2.TabIndex = 27;
            // 
            // BtnClose
            // 
            this.BtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.BackgroundImage")));
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClose.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(687, 574);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(161, 63);
            this.BtnClose.TabIndex = 8;
            this.BtnClose.Text = "&";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(237, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Entrada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(231, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "Salida:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(698, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = "Ganancias";
            // 
            // Estacionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 650);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlsalida);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblMTotal);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.dgvParking);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Estacionamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estacionamiento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParking)).EndInit();
            this.pnlsalida.ResumeLayout(false);
            this.pnlsalida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParking;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Label lblMTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Panel pnlsalida;
        private System.Windows.Forms.Label lblPlacas1;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button BtnPay;
        private System.Windows.Forms.Label lblModelo2;
        private System.Windows.Forms.TextBox txtplacas2;
        private System.Windows.Forms.Label lblMarca2;
        private System.Windows.Forms.TextBox txtmarca2;
        private System.Windows.Forms.TextBox txtmodelo2;
        private System.Windows.Forms.TextBox txtcolor2;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Button BtnCancelCarSelect;
    }
}