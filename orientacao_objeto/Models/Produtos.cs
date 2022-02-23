using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace orientacao_objeto.Models
{
    public class Produtos
    {
        public string produto { get; set; }
        public int ID { get; set; }
        public string descricao { get; set; }
        public int valor { get; set; }
    }
}
