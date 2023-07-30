using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVprova.Models
{
    public class Produto 
    {
        public int Id            { get; set ; }
        public int Codigo        { get; set; }
        public string DescrProduto  { get; set; }
        public int    Quantidade    { get; set; }
        public float  ValorUnitario { get; set; }
        public float  Desconto      { get; set; }
        public float  ValorTotal    { get; set; }
        public float  PrecoCusto    { get; set; }
        public int    Estoque       { get; set; }

    }
}
