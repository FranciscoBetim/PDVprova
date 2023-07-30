using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVprova.Models
{
    public class ProdutosBL
    {
        
        private Produto[] produtos = new[]
        {
            new Produto { Id = 1,
                          Codigo = 1,
                          DescrProduto = "coca cola",
                          Quantidade = 0,
                          ValorUnitario = 8.95f,
                          Desconto =0, 
                          ValorTotal=0, 
                          PrecoCusto = 4.5f,
                          Estoque = 3 
                         },
            new Produto { Id = 2,
                          Codigo = 11,
                          DescrProduto = "fanta",
                          Quantidade = 0,
                          ValorUnitario = 6.5f,
                          Desconto =0,
                          ValorTotal=0,
                          PrecoCusto = 3.5f,
                          Estoque = 2
                         },
            new Produto { Id = 3,
                          Codigo = 111,
                          DescrProduto = "pepsi",
                          Quantidade = 0,
                          ValorUnitario = 7.45f,
                          Desconto =0,
                          ValorTotal=0,
                          PrecoCusto = 4.0f,
                          Estoque = 1
                         },
        };
        public List<Produto> ProcuraProduto(int codigo)
        {
            List<Produto> procura = new List<Produto>();
            procura = produtos.Where(p => p.Codigo.Equals(codigo)).ToList();
            return procura;
        }
        public List<Produto> ProcuraProduto(string descricao)
        {
            List<Produto> procura = new List<Produto>();
            procura = produtos.Where(p => p.DescrProduto.Contains(descricao)).ToList();
            return procura;
        }
        public bool AddProduto(Produto produto)
        {
            //fazer verificacao de null para propriedades de produto
            this.produtos[this.produtos.Length] = produto;
            return true;
        }
    }
}
