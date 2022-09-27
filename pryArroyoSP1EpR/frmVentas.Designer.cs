namespace pryArroyoSP1EpR
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.lblTipoFactura = new System.Windows.Forms.Label();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.lblIDVendedor = new System.Windows.Forms.Label();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lstTipoFactura = new System.Windows.Forms.ComboBox();
            this.mtbNumeroFactura = new System.Windows.Forms.MaskedTextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.mtbIDCliente = new System.Windows.Forms.MaskedTextBox();
            this.mtbIDVendedor = new System.Windows.Forms.MaskedTextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBorrar.Location = new System.Drawing.Point(240, 329);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(90, 28);
            this.cmdBorrar.TabIndex = 18;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGrabar.Location = new System.Drawing.Point(359, 329);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(90, 28);
            this.cmdGrabar.TabIndex = 16;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = true;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFactura.Location = new System.Drawing.Point(12, 79);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(124, 20);
            this.lblNumeroFactura.TabIndex = 14;
            this.lblNumeroFactura.Text = "Numero Factura";
            // 
            // lblTipoFactura
            // 
            this.lblTipoFactura.AutoSize = true;
            this.lblTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFactura.Location = new System.Drawing.Point(12, 34);
            this.lblTipoFactura.Name = "lblTipoFactura";
            this.lblTipoFactura.Size = new System.Drawing.Size(98, 20);
            this.lblTipoFactura.TabIndex = 13;
            this.lblTipoFactura.Text = "Tipo Factura";
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.AutoSize = true;
            this.lblFechaEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEmision.Location = new System.Drawing.Point(12, 124);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(136, 20);
            this.lblFechaEmision.TabIndex = 19;
            this.lblFechaEmision.Text = "Fecha de Emision";
            // 
            // lblIDVendedor
            // 
            this.lblIDVendedor.AutoSize = true;
            this.lblIDVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDVendedor.Location = new System.Drawing.Point(12, 214);
            this.lblIDVendedor.Name = "lblIDVendedor";
            this.lblIDVendedor.Size = new System.Drawing.Size(100, 20);
            this.lblIDVendedor.TabIndex = 20;
            this.lblIDVendedor.Text = "ID Vendedor";
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCliente.Location = new System.Drawing.Point(12, 169);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(79, 20);
            this.lblIDCliente.TabIndex = 21;
            this.lblIDCliente.Text = "ID Cliente";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(12, 259);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(54, 20);
            this.lblMonto.TabIndex = 22;
            this.lblMonto.Text = "Monto";
            // 
            // lstTipoFactura
            // 
            this.lstTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTipoFactura.FormattingEnabled = true;
            this.lstTipoFactura.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.lstTipoFactura.Location = new System.Drawing.Point(167, 26);
            this.lstTipoFactura.Name = "lstTipoFactura";
            this.lstTipoFactura.Size = new System.Drawing.Size(61, 28);
            this.lstTipoFactura.TabIndex = 23;
            // 
            // mtbNumeroFactura
            // 
            this.mtbNumeroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNumeroFactura.Location = new System.Drawing.Point(167, 73);
            this.mtbNumeroFactura.Mask = "9-999-9";
            this.mtbNumeroFactura.Name = "mtbNumeroFactura";
            this.mtbNumeroFactura.Size = new System.Drawing.Size(61, 26);
            this.mtbNumeroFactura.TabIndex = 24;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(167, 118);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(282, 26);
            this.dtpFecha.TabIndex = 25;
            // 
            // mtbIDCliente
            // 
            this.mtbIDCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbIDCliente.Location = new System.Drawing.Point(167, 163);
            this.mtbIDCliente.Mask = "999";
            this.mtbIDCliente.Name = "mtbIDCliente";
            this.mtbIDCliente.Size = new System.Drawing.Size(40, 26);
            this.mtbIDCliente.TabIndex = 26;
            this.mtbIDCliente.ValidatingType = typeof(int);
            // 
            // mtbIDVendedor
            // 
            this.mtbIDVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbIDVendedor.Location = new System.Drawing.Point(167, 208);
            this.mtbIDVendedor.Mask = "999";
            this.mtbIDVendedor.Name = "mtbIDVendedor";
            this.mtbIDVendedor.Size = new System.Drawing.Size(40, 26);
            this.mtbIDVendedor.TabIndex = 27;
            this.mtbIDVendedor.ValidatingType = typeof(int);
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(167, 253);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(88, 26);
            this.txtMonto.TabIndex = 28;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 369);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.mtbIDVendedor);
            this.Controls.Add(this.mtbIDCliente);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.mtbNumeroFactura);
            this.Controls.Add(this.lstTipoFactura);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblIDCliente);
            this.Controls.Add(this.lblIDVendedor);
            this.Controls.Add(this.lblFechaEmision);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.lblNumeroFactura);
            this.Controls.Add(this.lblTipoFactura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga Ventas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.Label lblTipoFactura;
        private System.Windows.Forms.Label lblFechaEmision;
        private System.Windows.Forms.Label lblIDVendedor;
        private System.Windows.Forms.Label lblIDCliente;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.ComboBox lstTipoFactura;
        private System.Windows.Forms.MaskedTextBox mtbNumeroFactura;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.MaskedTextBox mtbIDCliente;
        private System.Windows.Forms.MaskedTextBox mtbIDVendedor;
        private System.Windows.Forms.TextBox txtMonto;
    }
}