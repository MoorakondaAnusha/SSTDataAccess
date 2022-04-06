#region Header

#endregion

#region Using

using Newtonsoft.Json;

#endregion

namespace SSTDataAccess
{
    /// <summary>
    /// Model class for Import API
    /// </summary>
    public class ImportRecord
    {
        #region Properties

        /// <summary>
        /// Project Assets for Importing
        /// </summary>
        [JsonProperty("assets")]
        public Assets Assets { get; set; }

        #endregion
    }
    
    /// <summary>
    /// Project Assets for Importing
    /// </summary>
    public class Assets
    {
        #region Properties

        /// <summary>
        /// List of Word Alteration Records
        /// </summary>
        [JsonProperty("synonyms")]
        public WordAlteration[] WordAlterations { get; set; }

        /// <summary>
        /// List of QnA Records
        /// </summary>
        [JsonProperty("qnas")]
        public QnA[] QnAs { get; set; }

        #endregion
    }
}
