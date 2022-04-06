#region Header

#endregion

#region Using

using Newtonsoft.Json;

#endregion

namespace SSTDataAccess
{
    /// <summary>
    /// Model class for ListDeployments API
    /// </summary>
    public class DeploymentRecords
    {
        #region Properties

        /// <summary>
        /// List all deployments of a project
        /// </summary>
        [JsonProperty("value")]
        public DeploymentRecord[] Deployments { get; set; }

        #endregion
    }

    /// <summary>
    /// Project deployment details
    /// </summary>
    public class DeploymentRecord : LastDeployedAuditBase
    {
        #region Properties

        /// <summary>
        /// Name of the deployment
        /// </summary>
        [JsonProperty("deploymentName")]
        public string DeploymentName { get; set; }

        #endregion
    }
}
