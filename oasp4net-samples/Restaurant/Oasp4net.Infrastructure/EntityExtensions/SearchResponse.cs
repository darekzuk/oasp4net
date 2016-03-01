
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Oasp4net.Infrastructure.EntityExtensions
{
    /// <summary>
    /// Represents a search response with paging information
    /// </summary>
    public class SearchResponse<T>
    {
        /// <summary>
        /// Get and set paging information
        /// </summary>
        [JsonProperty(PropertyName = "pagination")]
        public Pagination Pagination { get; set; }

        /// <summary>
        /// Set and get the Result
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public IList<T> Result { get; set; }
    }
}
