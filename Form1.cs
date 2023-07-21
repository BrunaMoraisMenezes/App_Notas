using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNotas
{
    public partial class frm_AppNotas : Form
    {
        public frm_AppNotas()
        {
            InitializeComponent();
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
                    Close();
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Preencha todos os campos corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
