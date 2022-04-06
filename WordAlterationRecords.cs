#region Header

#endregion

#region Using

using Newtonsoft.Json;

#endregion

namespace SSTDataAccess
{
    /// <summary>
    /// Model class for UpdateSynonyms and GetSynonyms APIs
    /// </summary>
    public class WordAlterationRecords
    {
        #region Properties

        /// <summary>
        /// List of Word Alteration Records
        /// </summary>
        [JsonProperty("value")]
        public WordAlteration[] WordAlterations { get; set; }

        #endregion
    }

    /// <summary>
    /// Word Alteration Record
    /// </summary>
    public class WordAlteration
    {
        #region Properties

        /// <summary>
        /// List of word alterations
        /// </summary>
        [JsonProperty("alterations")]
        public string[] Alterations { get; set; }

        #endregion
    }
}
