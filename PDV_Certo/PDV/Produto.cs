using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDV
{
    class Produto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public double PrecoUnitario { get; set; }
        public int Quantidade { get; set; }

        public Produto()
        {

        }

        public Produto(int Codigo, string Descricao, double PrecoUnitario, int Quantidade)
        {
            this.Codigo = Codigo;
            this.Descricao = Descricao;
            this.PrecoUnitario = PrecoUnitario;
            this.Quantidade = Quantidade;
        }

        private List<Produto> getProdutos()
        {
            List<Produto> listaProdutos = new List<Produto>();
            listaProdutos.Add(new Produto(1, "Mamão", 7.50, 1));
            listaProdutos.Add(new Produto(2, "Pera", 10.20, 1));
            listaProdutos.Add(new Produto(3, "Batata", 4.35, 1));
            listaProdutos.Add(new Produto(4, "Cenoura", 6.10, 1));
            listaProdutos.Add(new Produto(5, "Limão", 2.50, 1));
            listaProdutos.Add(new Produto(6, "Alho", 4.30, 1));
            listaProdutos.Add(new Produto(7, "Alface", 3.10, 1));
            listaProdutos.Add(new Produto(8, "Maça", 7.40, 1));
            listaProdutos.Add(new Produto(9, "Acelga", 6.10, 1));
            listaProdutos.Add(new Produto(10, "Maracuja", 8.60, 1));

            return listaProdutos;
        }

        public Produto buscaPorCodigo(int codigo)
        {
            Produto produtoBusca = null;
            foreach(var produto in getProdutos())
            {
                if(produto.Codigo == codigo)
                {
                    produtoBusca = produto;
                    break;
                }
            }
            return produtoBusca;
        }


    }




}
