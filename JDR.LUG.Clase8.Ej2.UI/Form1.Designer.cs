namespace JDR.LUG.Clase8.Ej2.UI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeMultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarMultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMToolStripMenuItem,
            this.multasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aBMToolStripMenuItem
            // 
            this.aBMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposDeMultaToolStripMenuItem});
            this.aBMToolStripMenuItem.Name = "aBMToolStripMenuItem";
            this.aBMToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.aBMToolStripMenuItem.Text = "ABM";
            // 
            // tiposDeMultaToolStripMenuItem
            // 
            this.tiposDeMultaToolStripMenuItem.Name = "tiposDeMultaToolStripMenuItem";
            this.tiposDeMultaToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.tiposDeMultaToolStripMenuItem.Text = "Tipos de multa";
            this.tiposDeMultaToolStripMenuItem.Click += new System.EventHandler(this.tiposDeMultaToolStripMenuItem_Click);
            // 
            // multasToolStripMenuItem
            // 
            this.multasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarMultasToolStripMenuItem,
            this.verMultasToolStripMenuItem});
            this.multasToolStripMenuItem.Name = "multasToolStripMenuItem";
            this.multasToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.multasToolStripMenuItem.Text = "Multas";
            // 
            // administrarMultasToolStripMenuItem
            // 
            this.administrarMultasToolStripMenuItem.Name = "administrarMultasToolStripMenuItem";
            this.administrarMultasToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.administrarMultasToolStripMenuItem.Text = "Administrar multas";
            this.administrarMultasToolStripMenuItem.Click += new System.EventHandler(this.administrarMultasToolStripMenuItem_Click);
            // 
            // verMultasToolStripMenuItem
            // 
            this.verMultasToolStripMenuItem.Name = "verMultasToolStripMenuItem";
            this.verMultasToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.verMultasToolStripMenuItem.Text = "Ver multas";
            this.verMultasToolStripMenuItem.Click += new System.EventHandler(this.verMultasToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 494);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeMultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarMultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMultasToolStripMenuItem;
    }
}

