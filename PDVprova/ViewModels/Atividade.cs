using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVprova.ViewModels
{
    public class Atividade
    {
        public string desconto { get; set; }
        public Atividade(string desc) 
        {
            desconto = desc;
        }
        public void DarDesconto()
        {
            desconto = "22.2";
        }
    }
}
