#region Header

#endregion

#region Using

using Newtonsoft.Json;

#endregion

namespace SSTDataAccess
{
    public class SourceQnABase
    {
        #region Properties

        /// <summary>
        /// Unique source identifier. 
        /// Name of the file if it's a 'file' source; otherwise, the complete URL if it's a 'url' source - SourceRecord
        /// Source from which QnA was indexed - QnaRecord
        /// </summary>
        [JsonProperty("source")]
        public string SourceName { get; set; }

        /// <summary>
        /// Represents the source last modified date-time - SourceRecord
        /// Date-time when the QnA was last updated - QnARecord
        /// </summary>
        [JsonProperty("lastUpdatedDateTime")]
        public string LastUpdatedDateTime { get; set; }

        #endregion
    }
}
