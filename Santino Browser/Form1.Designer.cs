
namespace Santino_Browser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Ir = new System.Windows.Forms.Button();
            this.In = new System.Windows.Forms.Button();
            this.ac = new System.Windows.Forms.Button();
            this.ad = new System.Windows.Forms.Button();
            this.at = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Ir);
            this.panel1.Controls.Add(this.In);
            this.panel1.Controls.Add(this.ac);
            this.panel1.Controls.Add(this.ad);
            this.panel1.Controls.Add(this.at);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 53);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(471, 20);
            this.textBox1.TabIndex = 5;
            // 
            // Ir
            // 
            this.Ir.Location = new System.Drawing.Point(282, 13);
            this.Ir.Name = "Ir";
            this.Ir.Size = new System.Drawing.Size(29, 20);
            this.Ir.TabIndex = 4;
            this.Ir.Text = "Ir";
            this.Ir.UseVisualStyleBackColor = true;
            this.Ir.Click += new System.EventHandler(this.Ir_Click);
            // 
            // In
            // 
            this.In.Location = new System.Drawing.Point(128, 0);
            this.In.Name = "In";
            this.In.Size = new System.Drawing.Size(57, 53);
            this.In.TabIndex = 3;
            this.In.Text = "Inicio";
            this.In.UseVisualStyleBackColor = true;
            this.In.Click += new System.EventHandler(this.In_Click);
            // 
            // ac
            // 
            this.ac.Location = new System.Drawing.Point(191, 0);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(85, 53);
            this.ac.TabIndex = 2;
            this.ac.Text = "Actualizar";
            this.ac.UseVisualStyleBackColor = true;
            this.ac.Click += new System.EventHandler(this.ac_Click);
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(65, 0);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(57, 53);
            this.ad.TabIndex = 1;
            this.ad.Text = "Adelante";
            this.ad.UseVisualStyleBackColor = true;
            this.ad.Click += new System.EventHandler(this.ad_Click);
            // 
            // at
            // 
            this.at.Location = new System.Drawing.Point(4, 0);
            this.at.Name = "at";
            this.at.Size = new System.Drawing.Size(55, 53);
            this.at.TabIndex = 0;
            this.at.Text = "Atras";
            this.at.UseVisualStyleBackColor = true;
            this.at.Click += new System.EventHandler(this.at_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 53);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 397);
            this.webBrowser1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Santino Browser";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ad;
        private System.Windows.Forms.Button at;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Ir;
        private System.Windows.Forms.Button In;
        private System.Windows.Forms.Button ac;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

