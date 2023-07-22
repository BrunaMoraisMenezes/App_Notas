
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvarNotas = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLerNotas = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtPrimeiraNota = new System.Windows.Forms.TextBox();
            this.txtSegundaNota = new System.Windows.Forms.TextBox();
            this.txtTerceiraNota = new System.Windows.Forms.TextBox();
            this.txtQuartaNota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMenorNota = new System.Windows.Forms.Label();
            this.lblMaiorNota = new System.Windows.Forms.Label();
            this.lblSomaNotasPares = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblSomaNotasImpares = new System.Windows.Forms.Label();
            this.lblQtdMaioresQueSete = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Primeira Nota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Segunda Nota:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Terceira Nota:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quarta Nota:";
            // 
            // btnSalvarNotas
            // 
            this.btnSalvarNotas.Location = new System.Drawing.Point(35, 299);
            this.btnSalvarNotas.Name = "btnSalvarNotas";
            this.btnSalvarNotas.Size = new System.Drawing.Size(115, 44);
            this.btnSalvarNotas.TabIndex = 8;
            this.btnSalvarNotas.Text = "Salvar Notas";
            this.btnSalvarNotas.UseVisualStyleBackColor = true;
            this.btnSalvarNotas.Click += new System.EventHandler(this.btnSalvarNotas_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(471, 299);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 44);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(629, 299);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(115, 44);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLerNotas
            // 
            this.btnLerNotas.Location = new System.Drawing.Point(183, 299);
            this.btnLerNotas.Name = "btnLerNotas";
            this.btnLerNotas.Size = new System.Drawing.Size(115, 44);
            this.btnLerNotas.TabIndex = 17;
            this.btnLerNotas.Text = "Ler Notas";
            this.btnLerNotas.UseVisualStyleBackColor = true;
            this.btnLerNotas.Click += new System.EventHandler(this.btnLerNotas_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(332, 299);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(115, 44);
            this.btnCalcular.TabIndex = 18;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtPrimeiraNota
            // 
            this.txtPrimeiraNota.Location = new System.Drawing.Point(128, 27);
            this.txtPrimeiraNota.Name = "txtPrimeiraNota";
            this.txtPrimeiraNota.Size = new System.Drawing.Size(171, 20);
            this.txtPrimeiraNota.TabIndex = 33;
            // 
            // txtSegundaNota
            // 
            this.txtSegundaNota.Location = new System.Drawing.Point(128, 77);
            this.txtSegundaNota.Name = "txtSegundaNota";
            this.txtSegundaNota.Size = new System.Drawing.Size(171, 20);
            this.txtSegundaNota.TabIndex = 34;
            // 
            // txtTerceiraNota
            // 
            this.txtTerceiraNota.Location = new System.Drawing.Point(128, 133);
            this.txtTerceiraNota.Name = "txtTerceiraNota";
            this.txtTerceiraNota.Size = new System.Drawing.Size(171, 20);
            this.txtTerceiraNota.TabIndex = 35;
            // 
            // txtQuartaNota
            // 
            this.txtQuartaNota.Location = new System.Drawing.Point(128, 187);
            this.txtQuartaNota.Name = "txtQuartaNota";
            this.txtQuartaNota.Size = new System.Drawing.Size(171, 20);
            this.txtQuartaNota.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Maior Nota:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblQtdMaioresQueSete);
            this.groupBox1.Controls.Add(this.lblSomaNotasImpares);
            this.groupBox1.Controls.Add(this.lblMedia);
            this.groupBox1.Controls.Add(this.lblSituacao);
            this.groupBox1.Controls.Add(this.lblSomaNotasPares);
            this.groupBox1.Controls.Add(this.lblMaiorNota);
            this.groupBox1.Controls.Add(this.lblMenorNota);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(387, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 221);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // lblMenorNota
            // 
            this.lblMenorNota.AutoSize = true;
            this.lblMenorNota.Location = new System.Drawing.Point(272, 57);
            this.lblMenorNota.Name = "lblMenorNota";
            this.lblMenorNota.Size = new System.Drawing.Size(35, 13);
            this.lblMenorNota.TabIndex = 38;
            this.lblMenorNota.Text = "label6";
            this.lblMenorNota.Visible = false;
            // 
            // lblMaiorNota
            // 
            this.lblMaiorNota.AutoSize = true;
            this.lblMaiorNota.Location = new System.Drawing.Point(272, 30);
            this.lblMaiorNota.Name = "lblMaiorNota";
            this.lblMaiorNota.Size = new System.Drawing.Size(35, 13);
            this.lblMaiorNota.TabIndex = 39;
            this.lblMaiorNota.Text = "label7";
            this.lblMaiorNota.Visible = false;
            // 
            // lblSomaNotasPares
            // 
            this.lblSomaNotasPares.AutoSize = true;
            this.lblSomaNotasPares.Location = new System.Drawing.Point(272, 112);
            this.lblSomaNotasPares.Name = "lblSomaNotasPares";
            this.lblSomaNotasPares.Size = new System.Drawing.Size(35, 13);
            this.lblSomaNotasPares.TabIndex = 40;
            this.lblSomaNotasPares.Text = "label8";
            this.lblSomaNotasPares.Visible = false;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(272, 197);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(35, 13);
            this.lblSituacao.TabIndex = 41;
            this.lblSituacao.Text = "label9";
            this.lblSituacao.Visible = false;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(272, 87);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(41, 13);
            this.lblMedia.TabIndex = 42;
            this.lblMedia.Text = "label10";
            this.lblMedia.Visible = false;
            // 
            // lblSomaNotasImpares
            // 
            this.lblSomaNotasImpares.AutoSize = true;
            this.lblSomaNotasImpares.Location = new System.Drawing.Point(272, 139);
            this.lblSomaNotasImpares.Name = "lblSomaNotasImpares";
            this.lblSomaNotasImpares.Size = new System.Drawing.Size(41, 13);
            this.lblSomaNotasImpares.TabIndex = 43;
            this.lblSomaNotasImpares.Text = "label11";
            this.lblSomaNotasImpares.Visible = false;
            // 
            // lblQtdMaioresQueSete
            // 
            this.lblQtdMaioresQueSete.AutoSize = true;
            this.lblQtdMaioresQueSete.Location = new System.Drawing.Point(272, 167);
            this.lblQtdMaioresQueSete.Name = "lblQtdMaioresQueSete";
            this.lblQtdMaioresQueSete.Size = new System.Drawing.Size(41, 13);
            this.lblQtdMaioresQueSete.TabIndex = 44;
            this.lblQtdMaioresQueSete.Text = "label12";
            this.lblQtdMaioresQueSete.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Menor Nota:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 46;
            this.label14.Text = "Média:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 13);
            this.label15.TabIndex = 47;
            this.label15.Text = "Soma das notas pares:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 13);
            this.label16.TabIndex = 48;
            this.label16.Text = "Soma das notas ímpares:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 167);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(178, 13);
            this.label17.TabIndex = 49;
            this.label17.Text = "Quantidade de notas maiores que 7:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 197);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 13);
            this.label18.TabIndex = 50;
            this.label18.Text = "Situação do aluno:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtQuartaNota);
            this.groupBox2.Controls.Add(this.txtTerceiraNota);
            this.groupBox2.Controls.Add(this.txtSegundaNota);
            this.groupBox2.Controls.Add(this.txtPrimeiraNota);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(26, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 220);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(313, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 29);
            this.label6.TabIndex = 40;
            this.label6.Text = "App Notas";
            // 
            // frm_AppNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 363);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLerNotas);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvarNotas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AppNotas";
            this.Text = "Notas:";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvarNotas;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLerNotas;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtPrimeiraNota;
        private System.Windows.Forms.TextBox txtSegundaNota;
        private System.Windows.Forms.TextBox txtTerceiraNota;
        private System.Windows.Forms.TextBox txtQuartaNota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblQtdMaioresQueSete;
        private System.Windows.Forms.Label lblSomaNotasImpares;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblSomaNotasPares;
        private System.Windows.Forms.Label lblMaiorNota;
        private System.Windows.Forms.Label lblMenorNota;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
    }
}

