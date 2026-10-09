namespace Hospedaje
{
    partial class frmcotizador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblhuesped = new Label();
            lblnoches = new Label();
            lbltarifanoche = new Label();
            txthuesped = new TextBox();
            txttarifanoche = new TextBox();
            checkBox1 = new CheckBox();
            btncalcular = new Button();
            btnlimpiar = new Button();
            lblcotizacion = new Label();
            lblsubtotal = new Label();
            lbldescuento = new Label();
            lblitbis = new Label();
            lblservicios = new Label();
            lbltotal = new Label();
            lblresultadocotizacion = new Label();
            lblresultadosubtotal = new Label();
            lblresultadodescuento = new Label();
            lblresultadoitbis = new Label();
            lblresultadoservicio = new Label();
            lblresultadototal = new Label();
            btncopiar = new Button();
            nudNoches = new NumericUpDown();
            btnimperativo = new Button();
            lstresultados = new ListBox();
            btnFuncional = new Button();
            btnObjetos = new Button();
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            SuspendLayout();
            // 
            // lblhuesped
            // 
            lblhuesped.AutoSize = true;
            lblhuesped.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblhuesped.Location = new Point(12, 18);
            lblhuesped.Name = "lblhuesped";
            lblhuesped.Size = new Size(99, 28);
            lblhuesped.TabIndex = 0;
            lblhuesped.Text = "Huesped:";
            // 
            // lblnoches
            // 
            lblnoches.AutoSize = true;
            lblnoches.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnoches.Location = new Point(12, 78);
            lblnoches.Name = "lblnoches";
            lblnoches.Size = new Size(87, 28);
            lblnoches.TabIndex = 1;
            lblnoches.Text = "Noches:";
            // 
            // lbltarifanoche
            // 
            lbltarifanoche.AutoSize = true;
            lbltarifanoche.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltarifanoche.Location = new Point(12, 138);
            lbltarifanoche.Name = "lbltarifanoche";
            lbltarifanoche.Size = new Size(213, 28);
            lbltarifanoche.TabIndex = 2;
            lbltarifanoche.Text = "Tarifa / Noche (USD):";
            // 
            // txthuesped
            // 
            txthuesped.Location = new Point(117, 22);
            txthuesped.Name = "txthuesped";
            txthuesped.Size = new Size(213, 27);
            txthuesped.TabIndex = 3;
            // 
            // txttarifanoche
            // 
            txttarifanoche.Location = new Point(245, 138);
            txttarifanoche.Name = "txttarifanoche";
            txttarifanoche.Size = new Size(195, 27);
            txttarifanoche.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(85, 208);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(259, 32);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Temporada Alta (+25%)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(40, 269);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(154, 57);
            btncalcular.TabIndex = 8;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(245, 269);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(147, 57);
            btnlimpiar.TabIndex = 9;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // lblcotizacion
            // 
            lblcotizacion.AutoSize = true;
            lblcotizacion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcotizacion.Location = new Point(46, 681);
            lblcotizacion.Name = "lblcotizacion";
            lblcotizacion.Size = new Size(93, 23);
            lblcotizacion.TabIndex = 10;
            lblcotizacion.Text = "Cotizacion";
            // 
            // lblsubtotal
            // 
            lblsubtotal.AutoSize = true;
            lblsubtotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsubtotal.Location = new Point(60, 482);
            lblsubtotal.Name = "lblsubtotal";
            lblsubtotal.Size = new Size(79, 23);
            lblsubtotal.TabIndex = 11;
            lblsubtotal.Text = "Subtotal";
            // 
            // lbldescuento
            // 
            lbldescuento.AutoSize = true;
            lbldescuento.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldescuento.Location = new Point(48, 534);
            lbldescuento.Name = "lbldescuento";
            lbldescuento.Size = new Size(93, 23);
            lbldescuento.TabIndex = 12;
            lbldescuento.Text = "Descuento";
            // 
            // lblitbis
            // 
            lblitbis.AutoSize = true;
            lblitbis.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblitbis.Location = new Point(48, 584);
            lblitbis.Name = "lblitbis";
            lblitbis.Size = new Size(91, 23);
            lblitbis.TabIndex = 13;
            lblitbis.Text = "ITBIS 18%";
            // 
            // lblservicios
            // 
            lblservicios.AutoSize = true;
            lblservicios.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblservicios.Location = new Point(46, 631);
            lblservicios.Name = "lblservicios";
            lblservicios.Size = new Size(114, 23);
            lblservicios.TabIndex = 14;
            lblservicios.Text = "Servicio 10%";
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltotal.Location = new Point(40, 782);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(140, 31);
            lbltotal.TabIndex = 15;
            lbltotal.Text = "TOTAL USD:";
            // 
            // lblresultadocotizacion
            // 
            lblresultadocotizacion.AutoSize = true;
            lblresultadocotizacion.Location = new Point(222, 683);
            lblresultadocotizacion.Name = "lblresultadocotizacion";
            lblresultadocotizacion.Size = new Size(36, 20);
            lblresultadocotizacion.TabIndex = 16;
            lblresultadocotizacion.Text = "0.00";
            // 
            // lblresultadosubtotal
            // 
            lblresultadosubtotal.AutoSize = true;
            lblresultadosubtotal.Location = new Point(222, 484);
            lblresultadosubtotal.Name = "lblresultadosubtotal";
            lblresultadosubtotal.Size = new Size(36, 20);
            lblresultadosubtotal.TabIndex = 17;
            lblresultadosubtotal.Text = "0.00";
            // 
            // lblresultadodescuento
            // 
            lblresultadodescuento.AutoSize = true;
            lblresultadodescuento.Location = new Point(222, 537);
            lblresultadodescuento.Name = "lblresultadodescuento";
            lblresultadodescuento.Size = new Size(36, 20);
            lblresultadodescuento.TabIndex = 18;
            lblresultadodescuento.Text = "0.00";
            // 
            // lblresultadoitbis
            // 
            lblresultadoitbis.AutoSize = true;
            lblresultadoitbis.Location = new Point(222, 587);
            lblresultadoitbis.Name = "lblresultadoitbis";
            lblresultadoitbis.Size = new Size(36, 20);
            lblresultadoitbis.TabIndex = 19;
            lblresultadoitbis.Text = "0.00";
            // 
            // lblresultadoservicio
            // 
            lblresultadoservicio.AutoSize = true;
            lblresultadoservicio.Location = new Point(222, 634);
            lblresultadoservicio.Name = "lblresultadoservicio";
            lblresultadoservicio.Size = new Size(36, 20);
            lblresultadoservicio.TabIndex = 20;
            lblresultadoservicio.Text = "0.00";
            // 
            // lblresultadototal
            // 
            lblresultadototal.AutoSize = true;
            lblresultadototal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblresultadototal.ImageAlign = ContentAlignment.MiddleLeft;
            lblresultadototal.Location = new Point(250, 785);
            lblresultadototal.Name = "lblresultadototal";
            lblresultadototal.Size = new Size(53, 28);
            lblresultadototal.TabIndex = 21;
            lblresultadototal.Text = "0.00";
            // 
            // btncopiar
            // 
            btncopiar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncopiar.Location = new Point(492, 785);
            btncopiar.Name = "btncopiar";
            btncopiar.Size = new Size(344, 37);
            btncopiar.TabIndex = 22;
            btncopiar.Text = "Copiar para Whatsapp";
            btncopiar.UseVisualStyleBackColor = true;
            btncopiar.Click += btncopiar_Click;
            // 
            // nudNoches
            // 
            nudNoches.Location = new Point(117, 83);
            nudNoches.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudNoches.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNoches.Name = "nudNoches";
            nudNoches.Size = new Size(213, 27);
            nudNoches.TabIndex = 23;
            nudNoches.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnimperativo
            // 
            btnimperativo.Location = new Point(47, 372);
            btnimperativo.Name = "btnimperativo";
            btnimperativo.Size = new Size(94, 40);
            btnimperativo.TabIndex = 24;
            btnimperativo.Text = "Imperativo";
            btnimperativo.UseVisualStyleBackColor = true;
            btnimperativo.Click += btnimperativo_Click;
            // 
            // lstresultados
            // 
            lstresultados.FormattingEnabled = true;
            lstresultados.Location = new Point(492, 34);
            lstresultados.Name = "lstresultados";
            lstresultados.Size = new Size(344, 744);
            lstresultados.TabIndex = 25;
            // 
            // btnFuncional
            // 
            btnFuncional.Location = new Point(310, 372);
            btnFuncional.Name = "btnFuncional";
            btnFuncional.Size = new Size(95, 40);
            btnFuncional.TabIndex = 26;
            btnFuncional.Text = "Funcional";
            btnFuncional.UseVisualStyleBackColor = true;
            btnFuncional.Click += btnFuncional_Click_1;
            // 
            // btnObjetos
            // 
            btnObjetos.Location = new Point(177, 372);
            btnObjetos.Name = "btnObjetos";
            btnObjetos.Size = new Size(95, 40);
            btnObjetos.TabIndex = 27;
            btnObjetos.Text = "Objetos";
            btnObjetos.UseVisualStyleBackColor = true;
            btnObjetos.Click += btnObjetos_Click_1;
            // 
            // frmcotizador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 834);
            Controls.Add(btnObjetos);
            Controls.Add(btnFuncional);
            Controls.Add(lstresultados);
            Controls.Add(btnimperativo);
            Controls.Add(nudNoches);
            Controls.Add(btncopiar);
            Controls.Add(lblresultadototal);
            Controls.Add(lblresultadoservicio);
            Controls.Add(lblresultadoitbis);
            Controls.Add(lblresultadodescuento);
            Controls.Add(lblresultadosubtotal);
            Controls.Add(lblresultadocotizacion);
            Controls.Add(lbltotal);
            Controls.Add(lblservicios);
            Controls.Add(lblitbis);
            Controls.Add(lbldescuento);
            Controls.Add(lblsubtotal);
            Controls.Add(lblcotizacion);
            Controls.Add(btnlimpiar);
            Controls.Add(btncalcular);
            Controls.Add(checkBox1);
            Controls.Add(txttarifanoche);
            Controls.Add(txthuesped);
            Controls.Add(lbltarifanoche);
            Controls.Add(lblnoches);
            Controls.Add(lblhuesped);
            Name = "frmcotizador";
            Text = "Cotizador Villa Coral - Frankeny Castillo - 2025-0794";
            ((System.ComponentModel.ISupportInitialize)nudNoches).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblhuesped;
        private Label lblnoches;
        private Label lbltarifanoche;
        private TextBox txthuesped;
        private TextBox txttarifanoche;
        private CheckBox checkBox1;
        private Button btncalcular;
        private Button btnlimpiar;
        private Label lblcotizacion;
        private Label lblsubtotal;
        private Label lbldescuento;
        private Label lblitbis;
        private Label lblservicios;
        private Label lbltotal;
        private Label lblresultadocotizacion;
        private Label lblresultadosubtotal;
        private Label lblresultadodescuento;
        private Label lblresultadoitbis;
        private Label lblresultadoservicio;
        private Label lblresultadototal;
        private Button btncopiar;
        private NumericUpDown nudNoches;
        private Button btnimperativo;
        private ListBox lstresultados;
        private Button btnFuncional;
        private Button btnObjetos;
    }
}
