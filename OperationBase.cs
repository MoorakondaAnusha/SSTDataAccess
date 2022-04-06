#region Header

#endregion

#region Using

using Newtonsoft.Json;

#endregion

namespace SSTDataAccess
{
    public class OperationBase
    {
        #region Properties

        /// <summary>
        /// Update operation type for assets
        /// </summary>
        [JsonProperty("op")]
        public string Operation { get; set; }

        #endregion
    }
}
