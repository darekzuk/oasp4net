
namespace Oasp4net.ServiceLayer.Api.Model.OfferManagement
{
    /// <summary>
    /// Product transport object
    /// </summary>
    public class ProductEntity : AbstractModelEntity
    {
        /// <summary>
        /// get and set the picture id
        /// </summary>
        public int PictureId { get; set; }

        /// <summary>
        /// get and set the id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Get and set the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Get and set the description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Get and set is alcoholic
        /// </summary>
        public bool IsAlcoholic { get; set; }
    }
}
