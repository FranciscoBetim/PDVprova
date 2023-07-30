using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PDVprova.ViewModels
{
    public class EventoPropriedades : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void PropriedadeModificada([CallerMemberName]string Nome = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Nome));      
        }
    }
}
