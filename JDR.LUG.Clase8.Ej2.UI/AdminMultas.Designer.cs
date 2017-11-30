namespace JDR.LUG.Clase8.Ej2.UI
{
    partial class AdminMultas
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
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTiposMulta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.btnGenerarMulta = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lugar";
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(127, 10);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(270, 22);
            this.txtLugar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo de multa";
            // 
            // cbTiposMulta
            // 
            this.cbTiposMulta.FormattingEnabled = true;
            this.cbTiposMulta.Location = new System.Drawing.Point(127, 42);
            this.cbTiposMulta.Name = "cbTiposMulta";
            this.cbTiposMulta.Size = new System.Drawing.Size(270, 24);
            this.cbTiposMulta.TabIndex = 2;
            this.cbTiposMulta.SelectedIndexChanged += new System.EventHandler(this.cbTiposMulta_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Monto a pagar";
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Location = new System.Drawing.Point(127, 76);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(91, 22);
            this.txtMonto.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Patente";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(127, 110);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(91, 22);
            this.txtPatente.TabIndex = 1;
            // 
            // btnGenerarMulta
            // 
            this.btnGenerarMulta.Location = new System.Drawing.Point(16, 153);
            this.btnGenerarMulta.Name = "btnGenerarMulta";
            this.btnGenerarMulta.Size = new System.Drawing.Size(121, 31);
            this.btnGenerarMulta.TabIndex = 3;
            this.btnGenerarMulta.Text = "Generar multa";
            this.btnGenerarMulta.UseVisualStyleBackColor = true;
            this.btnGenerarMulta.Click += new System.EventHandler(this.btnGenerarMulta_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(16, 212);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 17);
            this.lblResultado.TabIndex = 4;
            // 
            // AdminMultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 279);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnGenerarMulta);
            this.Controls.Add(this.cbTiposMulta);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "AdminMultas";
            this.Text = "AdminMultas";
            this.Load += new System.EventHandler(this.AdminMultas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTiposMulta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Button btnGenerarMulta;
        private System.Windows.Forms.Label lblResultado;
    }
}