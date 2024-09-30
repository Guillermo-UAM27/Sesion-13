namespace Burbuja
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumbers = new System.Windows.Forms.TextBox();
            this.BtnAgg = new System.Windows.Forms.Button();
            this.lbNumerbs = new System.Windows.Forms.ListBox();
            this.btOrdenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un #:";
            // 
            // tbNumbers
            // 
            this.tbNumbers.Location = new System.Drawing.Point(163, 58);
            this.tbNumbers.Name = "tbNumbers";
            this.tbNumbers.Size = new System.Drawing.Size(274, 22);
            this.tbNumbers.TabIndex = 1;
            // 
            // BtnAgg
            // 
            this.BtnAgg.Location = new System.Drawing.Point(478, 58);
            this.BtnAgg.Name = "BtnAgg";
            this.BtnAgg.Size = new System.Drawing.Size(75, 23);
            this.BtnAgg.TabIndex = 2;
            this.BtnAgg.Text = "Add";
            this.BtnAgg.UseVisualStyleBackColor = true;
            this.BtnAgg.Click += new System.EventHandler(this.BtnAgg_Click);
            // 
            // lbNumerbs
            // 
            this.lbNumerbs.FormattingEnabled = true;
            this.lbNumerbs.ItemHeight = 16;
            this.lbNumerbs.Location = new System.Drawing.Point(163, 101);
            this.lbNumerbs.Name = "lbNumerbs";
            this.lbNumerbs.Size = new System.Drawing.Size(295, 308);
            this.lbNumerbs.TabIndex = 3;
            // 
            // btOrdenar
            // 
            this.btOrdenar.Location = new System.Drawing.Point(464, 374);
            this.btOrdenar.Name = "btOrdenar";
            this.btOrdenar.Size = new System.Drawing.Size(76, 35);
            this.btOrdenar.TabIndex = 4;
            this.btOrdenar.Text = "Ordenar";
            this.btOrdenar.UseVisualStyleBackColor = true;
            this.btOrdenar.Click += new System.EventHandler(this.btOrdenar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.btOrdenar);
            this.Controls.Add(this.lbNumerbs);
            this.Controls.Add(this.BtnAgg);
            this.Controls.Add(this.tbNumbers);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumbers;
        private System.Windows.Forms.Button BtnAgg;
        private System.Windows.Forms.ListBox lbNumerbs;
        private System.Windows.Forms.Button btOrdenar;
    }
}

