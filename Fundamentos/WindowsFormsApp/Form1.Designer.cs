namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnValores = new System.Windows.Forms.Button();
            this.lbByteMin = new System.Windows.Forms.Label();
            this.lbByteMax = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(274, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fundamentos C#";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnValores
            // 
            this.btnValores.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValores.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnValores.Location = new System.Drawing.Point(334, 396);
            this.btnValores.Name = "btnValores";
            this.btnValores.Size = new System.Drawing.Size(175, 60);
            this.btnValores.TabIndex = 1;
            this.btnValores.Text = "Mostrar Valores";
            this.btnValores.UseVisualStyleBackColor = false;
            this.btnValores.Click += new System.EventHandler(this.btnValores_Click);
            // 
            // lbByteMin
            // 
            this.lbByteMin.AutoSize = true;
            this.lbByteMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbByteMin.Location = new System.Drawing.Point(73, 170);
            this.lbByteMin.Name = "lbByteMin";
            this.lbByteMin.Size = new System.Drawing.Size(39, 20);
            this.lbByteMin.TabIndex = 2;
            this.lbByteMin.Text = "*****";
            // 
            // lbByteMax
            // 
            this.lbByteMax.AutoSize = true;
            this.lbByteMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbByteMax.Location = new System.Drawing.Point(72, 198);
            this.lbByteMax.Name = "lbByteMax";
            this.lbByteMax.Size = new System.Drawing.Size(39, 20);
            this.lbByteMax.TabIndex = 3;
            this.lbByteMax.Text = "*****";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(70, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipos Numéricos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 496);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbByteMax);
            this.Controls.Add(this.lbByteMin);
            this.Controls.Add(this.btnValores);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValores;
        private System.Windows.Forms.Label lbByteMin;
        private System.Windows.Forms.Label lbByteMax;
        private System.Windows.Forms.Label label4;
    }
}

