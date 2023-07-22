using System;

namespace AppNotas
{
    class Servicos
    {
        public double MaiorNota(double primeiraNota, double segundaNota, double terceiraNota, double quartaNota)
        {
            double[] notas = { primeiraNota, segundaNota, terceiraNota, quartaNota };
            double maior = 0;

            foreach (double item in notas)
                if(item >= maior)
                    maior = item;

            return maior;
        }

        public double MenorNota(double primeiraNota, double segundaNota, double terceiraNota, double quartaNota)
        {
            double[] notas = { primeiraNota, segundaNota, terceiraNota, quartaNota };
            double menor = 0;

            foreach (double item in notas)
                if (item <= item)
                    menor = item;

            return menor;
        }

        public double Media(double primeiraNota, double segundaNota, double terceiraNota, double quartaNota)
        {
            double media = (primeiraNota + segundaNota + terceiraNota + quartaNota) / 4;
            return media;
        }

        public double SomaNotasPares(double primeiraNota, double segundaNota, double terceiraNota, double quartaNota)
        {
            double[] notas = { primeiraNota, segundaNota, terceiraNota, quartaNota };
            double total = 0;

            foreach (double item in notas)
                if (item % 2 == 0)
                    total += item;

            return total;
        }

        public double SomaNotasImpares(double primeiraNota, double segundaNota, double terceiraNota, double quartaNota)
        {
            double[] notas = { primeiraNota, segundaNota, terceiraNota, quartaNota };
            double total = 0;

            foreach (double item in notas)
                if (item % 2 != 0)
                    total += item;

            return total;
        }

        public int VerificaNotasMaioresQueSete(double primeiraNota, double segundaNota, double terceiraNota, double quartaNota)
        {
            double[] notas = { primeiraNota, segundaNota, terceiraNota, quartaNota };
            int quantidade = 0;

            foreach (double item in notas)
                quantidade++;

            return quantidade;
        }
        public string VerificaSituacaoAluno(double primeiraNota, double segundaNota, double terceiraNota, double quartaNota)
        {
            string situacao;
            if (Media(primeiraNota, segundaNota, terceiraNota, quartaNota) >= 6)
                situacao = "Aprovado";
            else
                situacao = "Reprovado";

            return situacao;
        }
    }
}
