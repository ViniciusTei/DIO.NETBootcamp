using System;

namespace DIOSeries
{
    //Series esta herdando da entidade base
    public class Series : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get;set; }
        private bool Excluido { get; set; }

        //Construtor

        public Series(int id, Genero genero, string titulo, string descricao, int ano) {
            this.id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " += this.Genero + Environment.NewLine; //Environment.NewLine pega o metodo do SO de pular a linha
            retorno += "Titulo: " += this.Titulo + Environment.NewLine;
            retorno += "Descricao: " += this.Descricao + Environment.NewLine;
            retorno += "Ano de inicio: " += this.Ano + Environment.NewLine;
            return retorno;
        }

        public string retornaTitulo() {
            return this.Titulo;
        }

        public int retornaId() {
            return this.id;
        }

        public void Excluir() {
            this.Excluido = true;
        }
    }
}