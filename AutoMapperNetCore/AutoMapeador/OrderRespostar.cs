using AutoMapper;
using AutoMapperNetCore.DestinoDTO;
using AutoMapperNetCore.OrigemDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperNetCore.AutoMapeador
{
    public class OrderRespostar
    {
        private IMapper _autoMapper;

        public OrderRespostar(IMapper autoMapper)
        {
            _autoMapper = autoMapper ?? throw new ArgumentNullException(nameof(autoMapper));
        }


        public void OrderDetalhesRespostar(DetalhesOrder detalhesOrder)
        {
            var mapperConfig = new MapperConfiguration(s =>
            {
                s.CreateMap<DetalhesOrder, DetalhesCliente>();
                           //Origem -----> Destino
            });
            _autoMapper = mapperConfig.CreateMapper();

            var ClienteOrderStatus = _autoMapper.Map<DetalhesOrder, DetalhesCliente>(detalhesOrder);
        }
    }
}
