#region Header

#endregion

#region Using

using Newtonsoft.Json;

#endregion

namespace SSTDataAccess
{
    public class LastDeployedAuditBase
    {
        #region Properties

        /// <summary>
        /// Represents the last deployment date-time
        /// </summary>
        [JsonProperty("lastDeployedDateTime")]
        public string LastDeployedDateTime { get; set; }

        #endregion
    }
}
