

using Newtonsoft.Json;

namespace Oasp4net.Infrastructure.EntityExtensions
{
    /// <summary>
    /// Pagination information
    /// </summary>    
    public class Pagination
    {
        private int total = 0;

        /// <summary>
        /// Get and set the size
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public int Size { get; set; }

        /// <summary>
        /// Get and set the page
        /// </summary>
        [JsonProperty(PropertyName = "page")]
        public int Page { get; set; }
        
        /// <summary>
        /// Get and set the total
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public int Total
        {
            get
            {
                return total;
            }
            set
            {
                if (Skip > value)
                {
                    Size = value;
                    Page = 0;
                }
                total = value;
            }
        }

        /// <summary>
        /// Gets the number of data to skip
        /// </summary>
        [JsonIgnore]
        public int Skip
        {
            get
            {
                return Page <= 0 ? 0 : (Page - 1) * Size;
            }            
        }
    }
}
