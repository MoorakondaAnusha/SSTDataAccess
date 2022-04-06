using Newtonsoft.Json;

namespace SSTDataAccess
{
    /// <summary>
    /// Operation Kind to differentiate between Add, Update and Delete QnA pairs
    /// </summary>
    public class OperationKind
    {
        public static string Add = "add";
        public static string Delete = "delete";
        public static string Replace = "replace";
    }

    /// <summary>
    /// Model class for UpdateQnAs API
    /// </summary>
    public class QnARecord: OperationBase
    {
        #region Properties

        /// <summary>
        /// QnA record
        /// </summary>
        [JsonProperty("value")]
        public QnA QnA { get; set; }

        #endregion
    }

    /// <summary>
    /// Model class for GetQnAs and QueryKB API
    /// </summary>
    public class QnARecords
    {
        #region Properties

        /// <summary>
        /// List of all QnAs
        /// </summary>
        [JsonProperty("value")]
        public QnA[] QnAs { get; set; }

        /// <summary>
        /// List of all QnAs
        /// </summary>
        [JsonProperty("answers")]
        public QnA[] QueryKBResult { set { QnAs = value; } }

        #endregion
    }

    /// <summary>
    /// QnA record
    /// </summary>
    public class QnA : SourceQnABase
    {
        #region Properties

        /// <summary>
        /// Unique ID for the QnA
        /// </summary>
        [JsonProperty("id")]
        public int QnAId { get; set; }

        /// <summary>
        /// Answer text
        /// </summary>
        [JsonProperty("answer")]
        public string Answer { get; set; }

        /// <summary>
        /// List of questions associated with the answer
        /// </summary>
        [JsonProperty("questions")]
        public string[] Question { get; set; }

        /// <summary>
        /// Metadata associated with the answer, useful to categorize or filter question answers
        /// </summary>
        [JsonProperty("metadata")]
        public object Metadata { get; set; }

        /// <summary>
        /// Context of a QnA
        /// </summary>
        [JsonProperty("dialog")]
        public QnADialog QnADialog { get; set; }

        /// <summary>
        /// Confidence Score
        /// </summary>
        [JsonProperty("confidenceScore")]
        public double ConfidenceScore { get; set; }

        /// <summary>
        /// Unable to find info about property in the internet
        /// </summary>
        [JsonProperty("isDocumentText")]
        public bool IsDocumentText { get; set; }

        /// <summary>
        /// List of Active Learning suggestions for the QnA
        /// </summary>
        [JsonProperty("activeLearningSuggestions")]
        public ActiveLearningSuggestions[] ActiveLearningSuggestions { get; set; }

        #endregion
    }

    /// <summary>
    /// List of Active Learning suggestions for the QnA
    /// </summary>
    public class ActiveLearningSuggestions
    {
        #region Properties

        /// <summary>
        /// Question chosen as the head of suggested questions cluster by Active Learning clustering algorithm
        /// </summary>
        [JsonProperty("clusterHead")]
        public string ClusterHead { get; set; }

        /// <summary>
        /// List of all suggested questions for the QnA
        /// </summary>
        [JsonProperty("suggestedQuestions")]
        public SuggestedQuestions[] SuggestedQuestions { get; set; }

        #endregion
    }

    /// <summary>
    /// Question suggested by the Active Learning feature.
    /// </summary>
    public class SuggestedQuestions
    {
        #region Properties

        /// <summary>
        /// The number of times the question was suggested automatically by the Active Learning algorithm
        /// </summary>
        [JsonProperty("autoSuggestedCount")]
        public int AutoSuggestedCount { get; set; }

        /// <summary>
        /// Question suggested by the Active Learning feature
        /// </summary>
        [JsonProperty("question")]
        public string Question { get; set; }

        /// <summary>
        /// The number of times the question was suggested explicitly by the user
        /// </summary>
        [JsonProperty("userSuggestedCount")]
        public int UserSuggestedCount { get; set; }

        #endregion
    }

    /// <summary>
    /// Metadata associated with the answer, useful to categorize or filter question answers
    /// </summary>
    public class Metadata
    {
        #region Properties

        /// <summary>
        /// Metadata Key
        /// </summary>
        [JsonProperty("name")]
        public string Key { get; set; }

        /// <summary>
        /// Metadata Value
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        #endregion
    }

    /// <summary>
    /// Dialog associated with QnA Record
    /// </summary>
    public class QnADialog
    {
        #region Properties

        /// <summary>
        /// To mark if a prompt is relevant only with a previous question or not. 
        /// If true, do not include this QnA as answer for queries without context; 
        /// otherwise, ignores context and includes this QnA in answers
        /// </summary>
        [JsonProperty("isContextOnly")]
        public bool IsContextOnly { get; set; }

        /// <summary>
        /// List of prompts associated with the answer
        /// </summary>
        [JsonProperty("prompts")]
        public QnAPrompt[] QnAPrompt { get; set; }

        #endregion
    }

    /// <summary>
    /// Prompt for an answer
    /// </summary>
    public class QnAPrompt : QnABase
    {
        #region Properties

        /// <summary>
        /// Index of the prompt. It is used for ordering of the prompts
        /// </summary>
        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Text displayed to represent a follow up question prompt
        /// </summary>
        [JsonProperty("displayText")]
        public string DisplayText { get; set; }

        #endregion
    }
}
