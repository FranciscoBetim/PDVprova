using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using PDVprova.Models;
using PDVprova.NovaPasta;
using PDVprova.Views;

namespace PDVprova.ViewModels
{
    public class CadastroProdutosViewModel : EventoPropriedades
    {
        public CadastroProdutosViewModel(CadastroProduto CADview)
        {
            DadosCadastro = new Produto();
            Cadastro = new ProdutosBL();
            this.CADview = CADview;
            listaProdutosCAD = new ListView();
            ListaProdutosCAD.ItemsSource = Cadastro.BuscaTodosProdutos();
        }
        
        private readonly CadastroProduto CADview;
        public Comando ComandoCadastrar => new Comando(execute    => Cadastrar(),
                                                       canExecute => PodeCadastrar());
        public Comando ComandoExcluir   => new Comando(execute    => Excluir(),
                                                       canExecute => PodeExcluir());
        public  Produto DadosCadastro { get; set; }
        private ProdutosBL Cadastro { get;}

        private ListView listaProdutosCAD;
        public ListView ListaProdutosCAD
        {
            get => listaProdutosCAD;
            set
            {
                listaProdutosCAD = value;
                PropriedadeModificada();
            }
        }
        
        private bool PodeCadastrar()
        {
            return true;
        }
        private void Cadastrar()
        {
            DadosCadastro.ValorTotal = 0;
            DadosCadastro.Quantidade = 0;
            DadosCadastro.Desconto   = 0;
            DadosCadastro.Id = 0;
            Cadastro.AddProduto(DadosCadastro);
            ListaProdutosCAD.ItemsSource = Cadastro.BuscaTodosProdutos();
        }
        private bool PodeExcluir()
        {
            return true;
        }
        private void Excluir()
        {
            MessageBox.Show("Excluido!");
        }
    }
}
