using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PDV
{
    public partial class frmPrincipal : Form
    {
        List<Produto> lista = new List<Produto>();

        Produto produto = new Produto();
        public double totalcompra = 0;
        public double troco = 0;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            int codProduto = Convert.ToInt16(txtCodigo.Text);

            Produto prodBusca = produto.buscaPorCodigo(codProduto);

            if(prodBusca != null)
            {
                lblDescricao.Text = prodBusca.Descricao;
                txtPrecoUni.Text = prodBusca.PrecoUnitario.ToString();
                txtQuantidade.Text = Convert.ToString(prodBusca.Quantidade);
            }
        }

        private void preencherDGV()
        {
            dgvProduto.Rows.Clear();
            double soma = 0;
            for(int i = 0; i < lista.Count; i++)
            {
                string[] nova_linha = new string[]
                {
                    Convert.ToString(lista[i].Codigo),
                    Convert.ToString(lista[i].Quantidade),
                    Convert.ToString(lista[i].PrecoUnitario),
                    (lista[i].Quantidade * lista[i].PrecoUnitario).ToString()                    
                    
                };

                soma += lista[i].Quantidade * lista[i].PrecoUnitario;
                dgvProduto.Rows.Add(nova_linha);
            }
            txtTotal.Text = soma.ToString();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto produtoincluir = new Produto();
           
            produtoincluir.Codigo = Convert.ToInt32(txtCodigo.Text);
            produtoincluir.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            produtoincluir.PrecoUnitario = Convert.ToDouble(txtPrecoUni.Text);

            lista.Add(produtoincluir);
            preencherDGV();
            limparconteudo();
           
        }

     
        public void limparconteudo()
        {
            txtCodigo.Text = "";
            txtQuantidade.Text = "";
            txtPrecoUni.Text = "";
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

            double valorrecebido = Convert.ToDouble(txtValorRecebido.Text);
            double valortotal = Convert.ToDouble(txtTotal.Text);

            double troco = valorrecebido - valortotal;

            txtTroco.Text = troco.ToString();


        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int indiceLinha = dgvProduto.CurrentRow.Index;
            lista.RemoveAt(indiceLinha);
            limparconteudo();
            dgvProduto.Rows.Clear();
            preencherDGV();
        }
    }
}
