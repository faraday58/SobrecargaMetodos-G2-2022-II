
namespace SobrecargaMetodos_G2_2022_II
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
            this.txtbOperando1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbOperando2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSuma = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbOperando1
            // 
            this.txtbOperando1.Location = new System.Drawing.Point(92, 133);
            this.txtbOperando1.Name = "txtbOperando1";
            this.txtbOperando1.Size = new System.Drawing.Size(125, 31);
            this.txtbOperando1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(273, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "+";
            // 
            // txtbOperando2
            // 
            this.txtbOperando2.Location = new System.Drawing.Point(380, 133);
            this.txtbOperando2.Name = "txtbOperando2";
            this.txtbOperando2.Size = new System.Drawing.Size(125, 31);
            this.txtbOperando2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(547, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "=";
            // 
            // lbSuma
            // 
            this.lbSuma.Location = new System.Drawing.Point(662, 136);
            this.lbSuma.Name = "lbSuma";
            this.lbSuma.Size = new System.Drawing.Size(70, 25);
            this.lbSuma.TabIndex = 0;
            this.lbSuma.Text = "0";
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(197, 233);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(209, 80);
            this.btnSuma.TabIndex = 1;
            this.btnSuma.Text = "Sumar";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 543);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.lbSuma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbOperando2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbOperando1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbOperando1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbOperando2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSuma;
        private System.Windows.Forms.Button btnSuma;
    }
}

