using PDVprova.NovaPasta;
using PDVprova.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PDVprova.ViewModels
{
    public class PontoDeVendaViewModel : EventoPropriedades
    {
        private readonly PontoDeVenda PDVview;

        public Comando ComandoRegistrar        => new Comando(execute    => RegistrarProduto(),
                                                              canExecute => PodeRegistrarProduto());
        public Comando ComandoDesconto         => new Comando(execute    => AbrirTelaDesconto(),
                                                              canExecute => PodeAbrirTelaDesconto());
        public Comando ComandoMudarPreco       => new Comando(execute    => AbrirTelaMudarPreco(),
                                                              canExecute => PodeAbrirTelaMudarPreco());
        public Comando ComandoCadastrarProduto => new Comando(execute    => AbrirTelaCadastro(), 
                                                              canExecute => PodeAbrirTelaCadastro());
        public Comando ComandoVoltar           => new Comando(execute    => Voltar(),
                                                              canExecute => PodeVoltar());
        private Visibility visibilityTelaCadastro;
        public Visibility VisibilidadeTelaCadastro
        {
            get => visibilityTelaCadastro;
            set 
            {
                visibilityTelaCadastro = value;
                PropriedadeModificada();
            }
        }
        public PontoDeVendaViewModel(PontoDeVenda PDVview)
        {
            this.PDVview = PDVview;
            VisibilidadeTelaCadastro = Visibility.Hidden;
        }
        private bool PodeVoltar()
        {
            return true;
        }
        private void Voltar()
        {
            if(VisibilidadeTelaCadastro == Visibility.Visible)
            {
                VisibilidadeTelaCadastro = Visibility.Hidden;
            }
        }
        private bool PodeAbrirTelaCadastro()
        {
            return true;
        }
        private void AbrirTelaCadastro()
        {
            VisibilidadeTelaCadastro = Visibility.Visible;
        }
        private bool PodeAbrirTelaMudarPreco()
        {
            return true;
        }
        private void AbrirTelaMudarPreco()
        {

        }
        private bool PodeAbrirTelaDesconto()
        {
            return true;
        }
        private void AbrirTelaDesconto()
        {

        }
        private bool PodeRegistrarProduto()
        {
            return true;
        }
        private void RegistrarProduto()
        {

        }
    }
}
