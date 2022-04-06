#region Header

#endregion

#region Using

using Newtonsoft.Json;

#endregion

namespace SSTDataAccess
{
    public class QnABase
    {
        #region Properties

        /// <summary>
        /// Unique ID of the QnA
        /// </summary>
        [JsonProperty("qnaId")]
        public int QnAId { get; set; }

        #endregion
    }
}
