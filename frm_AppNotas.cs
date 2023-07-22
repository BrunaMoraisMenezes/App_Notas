using System;
using System.IO;
using System.Windows.Forms;

namespace AppNotas
{
    public partial class frm_AppNotas : Form
    {
        public frm_AppNotas()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPrimeiraNota.Text = "";
            txtSegundaNota.Text = "";
            txtTerceiraNota.Text = "";
            txtQuartaNota.Text = "";
            lblMaiorNota.Visible = false;
            lblMenorNota.Visible = false;
            lblMedia.Visible = false;
            lblSomaNotasPares.Visible = false;
            lblSomaNotasImpares.Visible = false;
            lblQtdMaioresQueSete.Visible = false;
            lblSituacao.Visible = false;
        }

        public void Mostrar()
        {
            lblMaiorNota.Visible = true;
            lblMenorNota.Visible = true;
            lblMedia.Visible = true;
            lblSomaNotasPares.Visible = true;
            lblSomaNotasImpares.Visible = true;
            lblQtdMaioresQueSete.Visible = true;
            lblSituacao.Visible = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvarNotas_Click(object sender, EventArgs e)
        {
            string arquivo = @"C:\Users\Bruna\AppNotas.txt";

            try
            {
                if(!File.Exists(arquivo))
                {
                    using(StreamWriter streamWriter = File.CreateText(arquivo))
                    {
                        streamWriter.WriteLine($"{txtPrimeiraNota.Text},{txtSegundaNota.Text},{txtTerceiraNota.Text},{txtQuartaNota.Text}");
                    }
                    MessageBox.Show("Arquivo criado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Preencha todos os campos corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double primeiraNota = double.Parse(txtPrimeiraNota.Text);
                double segundaNota = double.Parse(txtSegundaNota.Text);
                double terceiraNota = double.Parse(txtTerceiraNota.Text);
                double quartaNota = double.Parse(txtQuartaNota.Text);

                Servicos servicos = new Servicos();
                lblMaiorNota.Text = servicos.MaiorNota(primeiraNota, segundaNota, terceiraNota, quartaNota).ToString();
                lblMenorNota.Text = servicos.MenorNota(primeiraNota, segundaNota, terceiraNota, quartaNota).ToString();
                lblMedia.Text = servicos.Media(primeiraNota, segundaNota, terceiraNota, quartaNota).ToString();
                lblSomaNotasPares.Text = servicos.SomaNotasPares(primeiraNota, segundaNota, terceiraNota, quartaNota).ToString();
                lblSomaNotasImpares.Text = servicos.SomaNotasImpares(primeiraNota, segundaNota, terceiraNota, quartaNota).ToString();
                lblQtdMaioresQueSete.Text = servicos.VerificaNotasMaioresQueSete(primeiraNota, segundaNota, terceiraNota, quartaNota).ToString();
                lblSituacao.Text = servicos.VerificaSituacaoAluno(primeiraNota, segundaNota, terceiraNota, quartaNota).ToString();
                Mostrar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnLerNotas_Click(object sender, EventArgs e)
        {
            try
            {
                using(StreamReader streamReader = new StreamReader(@"C:\Users\Bruna\AppNotas.txt"))
                {
                    string[] linhaArquivo = streamReader.ReadLine().Split(',');
                    txtPrimeiraNota.Text = linhaArquivo[0];
                    txtSegundaNota.Text = linhaArquivo[1];
                    txtTerceiraNota.Text = linhaArquivo[2];
                    txtQuartaNota.Text = linhaArquivo[3];
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Arquivo não localizado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível ler o arquivo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
