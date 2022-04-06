#region Header

#endregion

#region Using

using Newtonsoft.Json;
using SSTDataAccess;

#endregion

namespace Models
{
    /// <summary>
    /// Model class for AddFeedback API( for Active Learing's Suggestions)
    /// </summary>
    public class FeedbackRecords
    {
        #region Properties

        /// <summary>
        /// A list of Feedback Records for Active Learning
        /// </summary>
        [JsonProperty("records")]
        public FeedbackRecord[] Records { get; set; }

        #endregion

    }

    /// <summary>
    /// Feedback Record for Active Learning
    /// </summary>
    public class FeedbackRecord :QnABase
    {
        #region Properties

        /// <summary>
        /// Unique identifier of the user
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// User suggested question for the QnA
        /// </summary>
        [JsonProperty("userQuestion")]
        public string UserQuestion { get; set; }

        #endregion
    }
}
