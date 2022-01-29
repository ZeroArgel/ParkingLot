namespace ParkingLot
{
    partial class ParkingLot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParkingLot));
            this.DgvParking = new System.Windows.Forms.DataGridView();
            this.BtnNew = new System.Windows.Forms.Button();
            this.lblMTotal = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.PnlExit = new System.Windows.Forms.Panel();
            this.BtnCancelCarSelected = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvParking)).BeginInit();
            this.PnlExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvParking
            // 
            this.DgvParking.AllowUserToAddRows = false;
            this.DgvParking.AllowUserToDeleteRows = false;
            this.DgvParking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvParking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvParking.Location = new System.Drawing.Point(12, 22);
            this.DgvParking.Name = "DgvParking";
            this.DgvParking.ReadOnly = true;
            this.DgvParking.RowHeadersWidth = 51;
            this.DgvParking.Size = new System.Drawing.Size(115, 461);
            this.DgvParking.TabIndex = 0;
            this.DgvParking.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvParking_CellDoubleClick);
            // 
            // BtnNew
            // 
            this.BtnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNew.BackgroundImage")));
            this.BtnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNew.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.Location = new System.Drawing.Point(178, 139);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(121, 51);
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
            this.lblMTotal.Location = new System.Drawing.Point(506, 50);
            this.lblMTotal.Name = "lblMTotal";
            this.lblMTotal.Size = new System.Drawing.Size(54, 20);
            this.lblMTotal.TabIndex = 33;
            this.lblMTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(566, 50);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(61, 20);
            this.TxtTotal.TabIndex = 34;
            // 
            // pnlsalida
            // 
            this.PnlExit.BackColor = System.Drawing.Color.Transparent;
            this.PnlExit.Controls.Add(this.BtnCancelCarSelected);
            this.PnlExit.Controls.Add(this.lblPay);
            this.PnlExit.Controls.Add(this.txtPay);
            this.PnlExit.Controls.Add(this.lblSegS);
            this.PnlExit.Controls.Add(this.lblout);
            this.PnlExit.Controls.Add(this.label11);
            this.PnlExit.Controls.Add(this.lblin);
            this.PnlExit.Controls.Add(this.lblPlacas1);
            this.PnlExit.Controls.Add(this.lblMinS);
            this.PnlExit.Controls.Add(this.label13);
            this.PnlExit.Controls.Add(this.lblColor);
            this.PnlExit.Controls.Add(this.lblSegI);
            this.PnlExit.Controls.Add(this.BtnPay);
            this.PnlExit.Controls.Add(this.label2);
            this.PnlExit.Controls.Add(this.lblHoraS);
            this.PnlExit.Controls.Add(this.lblMinI);
            this.PnlExit.Controls.Add(this.lblModelo2);
            this.PnlExit.Controls.Add(this.label4);
            this.PnlExit.Controls.Add(this.txtplacas2);
            this.PnlExit.Controls.Add(this.lblMarca2);
            this.PnlExit.Controls.Add(this.txtmarca2);
            this.PnlExit.Controls.Add(this.txtmodelo2);
            this.PnlExit.Controls.Add(this.lblHoraI);
            this.PnlExit.Controls.Add(this.txtcolor2);
            this.PnlExit.Location = new System.Drawing.Point(176, 228);
            this.PnlExit.Name = "PnlExit";
            this.PnlExit.Size = new System.Drawing.Size(291, 289);
            this.PnlExit.TabIndex = 33;
            // 
            // BtnCancelCarSelected
            // 
            this.BtnCancelCarSelected.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCancelCarSelected.BackgroundImage")));
            this.BtnCancelCarSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCancelCarSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelCarSelected.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelCarSelected.Location = new System.Drawing.Point(215, 18);
            this.BtnCancelCarSelected.Name = "BtnCancelCarSelected";
            this.BtnCancelCarSelected.Size = new System.Drawing.Size(61, 28);
            this.BtnCancelCarSelected.TabIndex = 47;
            this.BtnCancelCarSelected.Text = "&";
            this.BtnCancelCarSelected.UseVisualStyleBackColor = true;
            this.BtnCancelCarSelected.Click += new System.EventHandler(this.BtnCancelCarSelected_Click);
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay.ForeColor = System.Drawing.Color.White;
            this.lblPay.Location = new System.Drawing.Point(27, 119);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(63, 19);
            this.lblPay.TabIndex = 58;
            this.lblPay.Text = "A Pagar:";
            // 
            // txtPay
            // 
            this.txtPay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPay.Location = new System.Drawing.Point(93, 119);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(100, 25);
            this.txtPay.TabIndex = 57;
            // 
            // lblSegS
            // 
            this.lblSegS.AutoSize = true;
            this.lblSegS.BackColor = System.Drawing.Color.Transparent;
            this.lblSegS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegS.ForeColor = System.Drawing.Color.White;
            this.lblSegS.Location = new System.Drawing.Point(165, 182);
            this.lblSegS.Name = "lblSegS";
            this.lblSegS.Size = new System.Drawing.Size(29, 13);
            this.lblSegS.TabIndex = 56;
            this.lblSegS.Text = "Seg";
            // 
            // lblout
            // 
            this.lblout.AutoSize = true;
            this.lblout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblout.ForeColor = System.Drawing.Color.White;
            this.lblout.Location = new System.Drawing.Point(16, 178);
            this.lblout.Name = "lblout";
            this.lblout.Size = new System.Drawing.Size(52, 19);
            this.lblout.TabIndex = 35;
            this.lblout.Text = "Salida:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(123, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = ":";
            // 
            // lblin
            // 
            this.lblin.AutoSize = true;
            this.lblin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblin.ForeColor = System.Drawing.Color.White;
            this.lblin.Location = new System.Drawing.Point(16, 152);
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
            // lblMinS
            // 
            this.lblMinS.AutoSize = true;
            this.lblMinS.BackColor = System.Drawing.Color.Transparent;
            this.lblMinS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinS.ForeColor = System.Drawing.Color.White;
            this.lblMinS.Location = new System.Drawing.Point(131, 182);
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
            this.label13.Location = new System.Drawing.Point(158, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = ":";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.White;
            this.lblColor.Location = new System.Drawing.Point(27, 93);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(47, 19);
            this.lblColor.TabIndex = 31;
            this.lblColor.Text = "Color:";
            // 
            // lblSegI
            // 
            this.lblSegI.AutoSize = true;
            this.lblSegI.BackColor = System.Drawing.Color.Transparent;
            this.lblSegI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegI.ForeColor = System.Drawing.Color.White;
            this.lblSegI.Location = new System.Drawing.Point(165, 156);
            this.lblSegI.Name = "lblSegI";
            this.lblSegI.Size = new System.Drawing.Size(29, 13);
            this.lblSegI.TabIndex = 51;
            this.lblSegI.Text = "Seg";
            // 
            // BtnPay
            // 
            this.BtnPay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPay.BackgroundImage")));
            this.BtnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPay.Location = new System.Drawing.Point(85, 227);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(121, 51);
            this.BtnPay.TabIndex = 7;
            this.BtnPay.Text = "&";
            this.BtnPay.UseVisualStyleBackColor = true;
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(122, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = ":";
            // 
            // lblHoraS
            // 
            this.lblHoraS.AutoSize = true;
            this.lblHoraS.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraS.ForeColor = System.Drawing.Color.White;
            this.lblHoraS.Location = new System.Drawing.Point(91, 182);
            this.lblHoraS.Name = "lblHoraS";
            this.lblHoraS.Size = new System.Drawing.Size(34, 13);
            this.lblHoraS.TabIndex = 52;
            this.lblHoraS.Text = "Hora";
            // 
            // lblMinI
            // 
            this.lblMinI.AutoSize = true;
            this.lblMinI.BackColor = System.Drawing.Color.Transparent;
            this.lblMinI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinI.ForeColor = System.Drawing.Color.White;
            this.lblMinI.Location = new System.Drawing.Point(131, 156);
            this.lblMinI.Name = "lblMinI";
            this.lblMinI.Size = new System.Drawing.Size(27, 13);
            this.lblMinI.TabIndex = 49;
            this.lblMinI.Text = "Min";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(158, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = ":";
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
            // lblHoraI
            // 
            this.lblHoraI.AutoSize = true;
            this.lblHoraI.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraI.ForeColor = System.Drawing.Color.White;
            this.lblHoraI.Location = new System.Drawing.Point(91, 156);
            this.lblHoraI.Name = "lblHoraI";
            this.lblHoraI.Size = new System.Drawing.Size(34, 13);
            this.lblHoraI.TabIndex = 47;
            this.lblHoraI.Text = "Hora";
            // 
            // txtcolor2
            // 
            this.txtcolor2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcolor2.Location = new System.Drawing.Point(93, 93);
            this.txtcolor2.Name = "txtcolor2";
            this.txtcolor2.Size = new System.Drawing.Size(100, 25);
            this.txtcolor2.TabIndex = 27;
            // 
            // BtnClose
            // 
            this.BtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.BackgroundImage")));
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClose.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(515, 466);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(121, 51);
            this.BtnClose.TabIndex = 8;
            this.BtnClose.Text = "&";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(178, 103);
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
            this.label7.Location = new System.Drawing.Point(524, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Ganancias";
            // 
            // ParkingLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(646, 528);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PnlExit);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.lblMTotal);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.DgvParking);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParkingLot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estacionamiento";
            ((System.ComponentModel.ISupportInitialize)(this.DgvParking)).EndInit();
            this.PnlExit.ResumeLayout(false);
            this.PnlExit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvParking;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Label lblMTotal;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Panel PnlExit;
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
        private System.Windows.Forms.Button BtnCancelCarSelected;
    }
}