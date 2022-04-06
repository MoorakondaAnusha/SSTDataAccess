#region Header

#endregion

#region Using

using Newtonsoft.Json;

#endregion

namespace SSTDataAccess
{
    /// <summary>
    /// Model class for GetAllProjects API
    /// </summary>
    public class ProjectRecords
    {
        #region Properties

        /// <summary>
        /// list of all projects
        /// </summary>
        [JsonProperty("value")]
        public ProjectRecord[] Projects { get; set; }

        #endregion
    }
    /// <summary>
    /// Model class for CreateProject and GetProjectDetails APIs
    /// </summary>
    public class ProjectRecord:LastDeployedAuditBase
    {
        #region Properties

        /// <summary>
        /// Name of the project
        /// </summary>
        [JsonProperty("projectName")]
        public string ProjectName { get; set; }

        /// <summary>
        /// Description of the project
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Language of the text records. This is BCP-47 representation of a language. 
        /// For example, use "en" for English; "es" for Spanish etc. If not set, use "en" for English as default.
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        /// Resource enabled for multiple languages across projects or not
        /// </summary>
        [JsonProperty("multilingualResource")]
        public bool MultilingualResource { get; set; }

        /// <summary>
        /// Resource enabled for multiple languages across projects or not
        /// </summary>
        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        /// <summary>
        /// Represents the project last modified date-time
        /// </summary>
        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        /// <summary>
        /// Configurable settings of the Project
        /// </summary>
        [JsonProperty("settings")]
        public ProjectSettings Settings { get; set; }

        #endregion
    }

    /// <summary>
    /// Configurable settings of the Project
    /// </summary>
    public class ProjectSettings
    {
        #region Properties

        /// <summary>
        /// Default Answer response when no good match is found in the knowledge base
        /// </summary>
        [JsonProperty("defaultAnswer")]
        public string DefaultAnswer { get; set; }

        #endregion
    }
}
