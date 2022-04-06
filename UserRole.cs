#region Header

#endregion

#region Using

#endregion

namespace SSTDataAccess
{
    public class UserRole : UserBase
    {
        #region Properties

        /// <summary>
        /// Role Id
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// Functionality user has access to
        /// </summary>
        public string Functionality { get; set; }

        #endregion
    }
}
