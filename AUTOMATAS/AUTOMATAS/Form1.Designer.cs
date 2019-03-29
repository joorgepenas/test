namespace AUTOMATAS
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
            this.btnfio = new System.Windows.Forms.Button();
            this.lblResul = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfio
            // 
            this.btnfio.Location = new System.Drawing.Point(271, 106);
            this.btnfio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnfio.Name = "btnfio";
            this.btnfio.Size = new System.Drawing.Size(165, 53);
            this.btnfio.TabIndex = 9;
            this.btnfio.Text = "FIORELLA";
            this.btnfio.UseVisualStyleBackColor = true;
            this.btnfio.Click += new System.EventHandler(this.btnfio_Click);
            // 
            // lblResul
            // 
            this.lblResul.AutoSize = true;
            this.lblResul.Location = new System.Drawing.Point(95, 123);
            this.lblResul.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(76, 16);
            this.lblResul.TabIndex = 8;
            this.lblResul.Text = "Resultado :";
            this.lblResul.Visible = false;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(254, 49);
            this.txt1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(157, 22);
            this.txt1.TabIndex = 7;
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_key);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "INGRESA UN NÚMERO:";
            // 
            // btncal
            // 
            this.btncal.Location = new System.Drawing.Point(35, 106);
            this.btncal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(213, 53);
            this.btncal.TabIndex = 5;
            this.btncal.Text = "Calcular";
            this.btncal.UseVisualStyleBackColor = true;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 199);
            this.Controls.Add(this.btnfio);
            this.Controls.Add(this.lblResul);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfio;
        private System.Windows.Forms.Label lblResul;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncal;
    }
}

