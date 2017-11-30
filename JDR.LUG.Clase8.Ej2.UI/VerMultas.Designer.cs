namespace JDR.LUG.Clase8.Ej2.UI
{
    partial class VerMultas
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
            this.dgvMultas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Multas";
            // 
            // dgvMultas
            // 
            this.dgvMultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMultas.Location = new System.Drawing.Point(16, 51);
            this.dgvMultas.Name = "dgvMultas";
            this.dgvMultas.RowTemplate.Height = 24;
            this.dgvMultas.Size = new System.Drawing.Size(688, 192);
            this.dgvMultas.TabIndex = 1;
            // 
            // VerMultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 314);
            this.Controls.Add(this.dgvMultas);
            this.Controls.Add(this.label1);
            this.Name = "VerMultas";
            this.Text = "VerMultas";
            this.Load += new System.EventHandler(this.VerMultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMultas;
    }
}