using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oasp4net.ServiceLayer.Api.Model.SalesManagement;
using Oasp4net.DataAccessLayer.Salesmanagement;
using Oasp4net.DataAccessLayer.Salesmanagement.Model;

namespace Oasp4net.ServiceLayer.Tests.Mapper
{
    [TestClass]
    public class AutoMapperConfigurationTest
    {
        [TestMethod]
        public void MapAndReverseMapCompositeOrderCompositeOrderEntity()
        {

            AutoMapper.Mapper.CreateMap<Order, OrderEntity>().ReverseMap();
            AutoMapper.Mapper.CreateMap<OrderPosition, OrderPositionEntity>().ReverseMap();
            AutoMapper.Mapper.CreateMap<CompositeOrder, CompositeOrderEntity>().ForMember(dest => dest.OrderEntity, opt => opt.MapFrom(src => src.Order)).
                ForMember(dest => dest.OrderPositionEntities, opt => opt.MapFrom(src => src.OrderPositions));

            AutoMapper.Mapper.CreateMap<CompositeOrderEntity, CompositeOrder>().ForMember(dest => dest.Order, opt => opt.MapFrom(src => src.OrderEntity)).
                ForMember(dest => dest.OrderPositions, opt => opt.MapFrom(src => src.OrderPositionEntities));


            AutoMapper.Mapper.AssertConfigurationIsValid();
        }

        [TestMethod]
        public void MapAndReverseMapOrderOrderEntity()
        {
            AutoMapper.Mapper.CreateMap<Order, OrderEntity>().ReverseMap();

            AutoMapper.Mapper.AssertConfigurationIsValid();
        }


        [TestMethod]
        public void MapAndReverseMapOrderPositionOrderPositionEntity()
        {
            AutoMapper.Mapper.CreateMap<OrderPosition, OrderPositionEntity>().ReverseMap();

            AutoMapper.Mapper.AssertConfigurationIsValid();
        }
    }
}
