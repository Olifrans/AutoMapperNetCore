using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperNetCore.DestinoDTO
{
    public class DetalhesCliente
    {
        public int Id { get; set; }

        public string ClienteNome { get; set; }

        public string OrderNumero { get; set; }

        public int OrderQuantidade { get; set; }

        public string OrderStatus { get; set; }

        public string ProdutoNome { get; set; }
    }
}
