using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperNetCore.OrigemDTO
{
    public class DetalhesOrder
    {
        public string OrderNumero { get; set; }

        public int OrderQuantidade { get; set; }

        public string OrderStatus { get; set; }

        public Produto[] produtos { get; set; }
    }
}
