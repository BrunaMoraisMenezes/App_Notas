
namespace AppNotas
{
    partial class frm_AppNotas
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
            this.txtPrimeiraNota = new System.Windows.Forms.TextBox();
            this.txtSegundaNota = new System.Windows.Forms.TextBox();
            this.txtTerceiraNota = new System.Windows.Forms.TextBox();
            this.txtQuartaNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvarNotas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPrimeiraNota
            // 
            this.txtPrimeiraNota.Location = new System.Drawing.Point(217, 86);
            this.txtPrimeiraNota.Name = "txtPrimeiraNota";
            this.txtPrimeiraNota.Size = new System.Drawing.Size(135, 20);
            this.txtPrimeiraNota.TabIndex = 0;
            // 
            // txtSegundaNota
            // 
            this.txtSegundaNota.Location = new System.Drawing.Point(217, 140);
            this.txtSegundaNota.Name = "txtSegundaNota";
            this.txtSegundaNota.Size = new System.Drawing.Size(135, 20);
            this.txtSegundaNota.TabIndex = 1;
            // 
            // txtTerceiraNota
            // 
            this.txtTerceiraNota.Location = new System.Drawing.Point(217, 196);
            this.txtTerceiraNota.Name = "txtTerceiraNota";
            this.txtTerceiraNota.Size = new System.Drawing.Size(135, 20);
            this.txtTerceiraNota.TabIndex = 2;
            // 
            // txtQuartaNota
            // 
            this.txtQuartaNota.Location = new System.Drawing.Point(217, 250);
            this.txtQuartaNota.Name = "txtQuartaNota";
            this.txtQuartaNota.Size = new System.Drawing.Size(135, 20);
            this.txtQuartaNota.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Primeira Nota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Segunda Nota:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Terceira Nota:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quarta Nota:";
            // 
            // btnSalvarNotas
            // 
            this.btnSalvarNotas.Location = new System.Drawing.Point(179, 318);
            this.btnSalvarNotas.Name = "btnSalvarNotas";
            this.btnSalvarNotas.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarNotas.TabIndex = 8;
            this.btnSalvarNotas.Text = "Salvar Notas";
            this.btnSalvarNotas.UseVisualStyleBackColor = true;
            this.btnSalvarNotas.Click += new System.EventHandler(this.btnSalvarNotas_Click);
            // 
            // frm_AppNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 402);
            this.Controls.Add(this.btnSalvarNotas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuartaNota);
            this.Controls.Add(this.txtTerceiraNota);
            this.Controls.Add(this.txtSegundaNota);
            this.Controls.Add(this.txtPrimeiraNota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AppNotas";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrimeiraNota;
        private System.Windows.Forms.TextBox txtSegundaNota;
        private System.Windows.Forms.TextBox txtTerceiraNota;
        private System.Windows.Forms.TextBox txtQuartaNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvarNotas;
    }
}

