using Oasp4net.DataAccessLayer.Offermanagement;
using Oasp4net.DataAccessLayer.Offermanagement.Model;
using Oasp4net.DataAccessLayer.Salesmanagement;
using Oasp4net.DataAccessLayer.Salesmanagement.Model;
using Oasp4net.DataAccessLayer.Tablemanagement.Model;
using Oasp4net.ServiceLayer.Api.Model.OfferManagement;
using Oasp4net.ServiceLayer.Api.Model.SalesManagement;
using Oasp4net.ServiceLayer.Api.Model.TableManagement;

namespace Oasp4net.ServiceLayer.Api.Mapper
{
    /// <summary>
    /// Initialize the Automapper
    /// </summary>
    public class MapperIntializer
    {
        public static void ConfigureMapper()
        {
            ///Product 
            AutoMapper.Mapper.CreateMap<Product, ProductEntity>().ReverseMap();
            // Restauranttable
            AutoMapper.Mapper.CreateMap<RestaurantTable, RestaurantTableEntity>().ReverseMap();
            // Offer
            AutoMapper.Mapper.CreateMap<Offer, OfferEntity>().ForMember(dest => dest.Description, opt => opt.MapFrom(src => ((src.Meal != null) ? src.Meal.Description : src.Drink.Description)));

            //Order
            AutoMapper.Mapper.CreateMap<Order, OrderEntity>().ReverseMap();
            //Order Position
            AutoMapper.Mapper.CreateMap<OrderPosition, OrderPositionEntity>().ReverseMap();

            // CompositeOrder
            AutoMapper.Mapper.CreateMap<CompositeOrder, CompositeOrderEntity>().ForMember(dest => dest.OrderEntity, opt => opt.MapFrom(src => src.Order)).
                ForMember(dest => dest.OrderPositionEntities, opt => opt.MapFrom(src => src.OrderPositions));

            AutoMapper.Mapper.CreateMap<CompositeOrderEntity, CompositeOrder>().ForMember(dest => dest.Order, opt => opt.MapFrom(src => src.OrderEntity)).
                ForMember(dest => dest.OrderPositions, opt => opt.MapFrom(src => src.OrderPositionEntities));

        }
    }
}
