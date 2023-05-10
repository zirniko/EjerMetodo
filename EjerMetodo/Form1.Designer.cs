namespace EjerMetodo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEmpanada = new System.Windows.Forms.Label();
            this.chbEmpanada = new System.Windows.Forms.CheckBox();
            this.lblChilenito = new System.Windows.Forms.Label();
            this.chbChilenito = new System.Windows.Forms.CheckBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtCantidadEmpanada = new System.Windows.Forms.TextBox();
            this.lblCantidadEmp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadChilenito = new System.Windows.Forms.TextBox();
            this.pnlEmpanda = new System.Windows.Forms.Panel();
            this.pnlChilenito = new System.Windows.Forms.Panel();
            this.btnTotal = new System.Windows.Forms.Button();
            this.lblValorEmp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlEmpanda.SuspendLayout();
            this.pnlChilenito.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(188, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(101, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Panaderia";
            // 
            // lblEmpanada
            // 
            this.lblEmpanada.AutoSize = true;
            this.lblEmpanada.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpanada.Location = new System.Drawing.Point(12, 59);
            this.lblEmpanada.Name = "lblEmpanada";
            this.lblEmpanada.Size = new System.Drawing.Size(118, 25);
            this.lblEmpanada.TabIndex = 1;
            this.lblEmpanada.Text = "Empanadas:";
            // 
            // chbEmpanada
            // 
            this.chbEmpanada.AutoSize = true;
            this.chbEmpanada.Location = new System.Drawing.Point(132, 68);
            this.chbEmpanada.Name = "chbEmpanada";
            this.chbEmpanada.Size = new System.Drawing.Size(15, 14);
            this.chbEmpanada.TabIndex = 2;
            this.chbEmpanada.UseVisualStyleBackColor = true;
            this.chbEmpanada.CheckedChanged += new System.EventHandler(this.chbEmpanada_CheckedChanged);
            // 
            // lblChilenito
            // 
            this.lblChilenito.AutoSize = true;
            this.lblChilenito.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChilenito.Location = new System.Drawing.Point(12, 139);
            this.lblChilenito.Name = "lblChilenito";
            this.lblChilenito.Size = new System.Drawing.Size(104, 25);
            this.lblChilenito.TabIndex = 3;
            this.lblChilenito.Text = "Chilenitos:";
            // 
            // chbChilenito
            // 
            this.chbChilenito.AutoSize = true;
            this.chbChilenito.Location = new System.Drawing.Point(132, 148);
            this.chbChilenito.Name = "chbChilenito";
            this.chbChilenito.Size = new System.Drawing.Size(15, 14);
            this.chbChilenito.TabIndex = 4;
            this.chbChilenito.UseVisualStyleBackColor = true;
            this.chbChilenito.CheckedChanged += new System.EventHandler(this.chbChilenito_CheckedChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(12, 197);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(241, 25);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Sólo se vende por docena";
            // 
            // txtCantidadEmpanada
            // 
            this.txtCantidadEmpanada.Location = new System.Drawing.Point(139, 13);
            this.txtCantidadEmpanada.Name = "txtCantidadEmpanada";
            this.txtCantidadEmpanada.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadEmpanada.TabIndex = 6;
            // 
            // lblCantidadEmp
            // 
            this.lblCantidadEmp.AutoSize = true;
            this.lblCantidadEmp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadEmp.Location = new System.Drawing.Point(3, 13);
            this.lblCantidadEmp.Name = "lblCantidadEmp";
            this.lblCantidadEmp.Size = new System.Drawing.Size(97, 25);
            this.lblCantidadEmp.TabIndex = 7;
            this.lblCantidadEmp.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cantidad:";
            // 
            // txtCantidadChilenito
            // 
            this.txtCantidadChilenito.Location = new System.Drawing.Point(149, 10);
            this.txtCantidadChilenito.Name = "txtCantidadChilenito";
            this.txtCantidadChilenito.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadChilenito.TabIndex = 8;
            // 
            // pnlEmpanda
            // 
            this.pnlEmpanda.Controls.Add(this.lblCantidadEmp);
            this.pnlEmpanda.Controls.Add(this.txtCantidadEmpanada);
            this.pnlEmpanda.Location = new System.Drawing.Point(176, 50);
            this.pnlEmpanda.Name = "pnlEmpanda";
            this.pnlEmpanda.Size = new System.Drawing.Size(280, 45);
            this.pnlEmpanda.TabIndex = 10;
            this.pnlEmpanda.Visible = false;
            // 
            // pnlChilenito
            // 
            this.pnlChilenito.Controls.Add(this.label1);
            this.pnlChilenito.Controls.Add(this.txtCantidadChilenito);
            this.pnlChilenito.Location = new System.Drawing.Point(178, 129);
            this.pnlChilenito.Name = "pnlChilenito";
            this.pnlChilenito.Size = new System.Drawing.Size(278, 44);
            this.pnlChilenito.TabIndex = 11;
            this.pnlChilenito.Visible = false;
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.Location = new System.Drawing.Point(17, 249);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(113, 33);
            this.btnTotal.TabIndex = 12;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lblValorEmp
            // 
            this.lblValorEmp.AutoSize = true;
            this.lblValorEmp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorEmp.Location = new System.Drawing.Point(14, 97);
            this.lblValorEmp.Name = "lblValorEmp";
            this.lblValorEmp.Size = new System.Drawing.Size(133, 17);
            this.lblValorEmp.TabIndex = 13;
            this.lblValorEmp.Text = "(cada docena 12000)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "(cada docena 2500)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 327);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblValorEmp);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.pnlChilenito);
            this.Controls.Add(this.pnlEmpanda);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.chbChilenito);
            this.Controls.Add(this.lblChilenito);
            this.Controls.Add(this.chbEmpanada);
            this.Controls.Add(this.lblEmpanada);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlEmpanda.ResumeLayout(false);
            this.pnlEmpanda.PerformLayout();
            this.pnlChilenito.ResumeLayout(false);
            this.pnlChilenito.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEmpanada;
        private System.Windows.Forms.CheckBox chbEmpanada;
        private System.Windows.Forms.Label lblChilenito;
        private System.Windows.Forms.CheckBox chbChilenito;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtCantidadEmpanada;
        private System.Windows.Forms.Label lblCantidadEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidadChilenito;
        private System.Windows.Forms.Panel pnlEmpanda;
        private System.Windows.Forms.Panel pnlChilenito;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label lblValorEmp;
        private System.Windows.Forms.Label label2;
    }
}

