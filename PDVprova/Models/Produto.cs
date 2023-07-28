using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVprova.Models
{
    public class Produto 
    {
        public string Codigo        { get; private set; }
        public string DescrProduto  { get; private set; }
        public int    Quantidade    { get; private set; }
        public float  ValorUnitario { get; private set; }
        public float  Desconto      { get; private set; }
        public float  ValorTotal    { get; private set; }
        public float  PrecoCusto    { get; private set; }
        public int    Estoque       { get; private set; }
        public Produto(string codigo, string descrProduto, int quantidade, float valorUnitario, float desconto, float valorTotal, float precodecusto, int estoque)
        {
            Codigo        = codigo;
            DescrProduto  = descrProduto;
            Quantidade    = quantidade;
            ValorUnitario = valorUnitario;
            Desconto      = desconto;
            ValorTotal    = valorTotal;
            PrecoCusto    = precodecusto;
            Estoque       = estoque;
        }
        public bool Set_Produto(Produto produto)
        {
            bool retorno = false;
            if(produto != null)
            {
                Codigo        = produto.Codigo;
                DescrProduto  = produto.DescrProduto;
                Quantidade    = produto.Quantidade;
                ValorUnitario = produto.ValorUnitario;
                Desconto      = produto.Desconto;
                ValorTotal    = produto.ValorTotal;
                PrecoCusto    = produto.PrecoCusto;
                Estoque       = produto.Estoque;
            }
            return retorno;
        }
        public bool Set_Codigo(string codigo)
        {
            bool retorno = false;
            if (codigo != null)
            {
                Codigo = codigo;
            }
            return retorno;
        }
        public bool Set_DescrProduto(string descrproduto)
        {
            bool retorno = false;
            if (descrproduto != null)
            {
                DescrProduto = descrproduto;
            }
            return retorno;
        }
        public void Set_Quantidade(int quantidade)
        {
            Quantidade = quantidade;
        }
        public void Set_ValorUnitario(float valorunitario)
        {
            ValorUnitario = valorunitario;
        }
        public void Set_Desconto(float desconto)
        {
            Desconto = desconto;
        }
        public void Set_ValorTotal(float valortotal)
        {
            ValorTotal = valortotal;
        }
        public void Set_PrecoCusto(float precodecusto)
        {
            PrecoCusto = precodecusto;
        }
        public void Set_Estoque(int estoque)
        {
            Estoque = estoque;
        }

    }
}
