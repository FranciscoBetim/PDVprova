using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDVprova.Models;
namespace PDVprova.ViewModels
{
    public class CadastroProdutosViewModel : EventoPropriedades
    {
        private readonly Produto _prod;
        
        private ProdutosBL Cadastro { get;}
        
        public CadastroProdutosViewModel()
        {
            Cadastro = new ProdutosBL(); 
        }

    }
}
