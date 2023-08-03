using PDVprova.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PDVprova.Views
{
    /// <summary>
    /// Interação lógica para PontoDeVenda.xam
    /// </summary>
    public partial class PontoDeVenda : UserControl
    {
        
        public PontoDeVenda()
        {
            InitializeComponent();
            DataContext = new PontoDeVendaViewModel(this);
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /* List<User> items = new List<User>();
             items.Add(new User() { Name = "John Doe", Age = 42, Mail = "john@doe-family.com" });
             items.Add(new User() { Name = "Jane Doe", Age = 39, Mail = "jane@doe-family.com" });
             items.Add(new User() { Name = "Sammy Doe", Age = 7, Mail = "sammy.doe@gmail.com" });
             ListaProdutos.ItemsSource = items;*/
        }
    }
}
