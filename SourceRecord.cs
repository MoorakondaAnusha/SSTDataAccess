#region Header

#endregion

#region Using

using Newtonsoft.Json;

#endregion

namespace SSTDataAccess
{
    /// <summary>
    /// Supported source types
    /// </summary>
    public class SourceKind
    {
        public static string File = "file";
        public static string Url = "url";
    }

    /// <summary>
    /// Content structure type for sources
    /// </summary>
    public class SourceContentStructureKind
    {
        public static string Unstructured = "unstructured";
    }

    /// <summary>
    /// Model class for GetSources API
    /// </summary>
    public class SourceRecords
    {
        /// <summary>
        /// list of all source records
        /// </summary>
        [JsonProperty("value")]
        public Source[] Sources { get; set; }
    }

    /// <summary>
    /// Model class for UpdateSources API
    /// </summary>
    public class SourceRecord : OperationBase
    {
        /// <summary>
        /// Update source record
        /// </summary>
        [JsonProperty("value")]
        public Source Source { get; set; }
    }

    /// <summary>
    /// Source record (also Model class for GetSources API)
    /// </summary>
    public class Source : SourceQnABase
    {
        /// <summary>
        /// Friendly name of the Source
        /// </summary>
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// URI location for the file or url
        /// </summary>
        [JsonProperty("sourceUri")]
        public string SourceUri { get; set; }

        /// <summary>
        /// Supported source types (refer "SourceKind" class for the same)
        /// </summary>
        [JsonProperty("sourceKind")]
        public string SourceKind { get; set; }

        /// <summary>
        /// Content structure type for sources(refer "SourceContentStructureKind" class for the same)
        /// </summary>
        [JsonProperty("contentStructureKind")]
        public string ContentStructureKind { get; set; }
    }
}
