using System;
using System.Runtime.Serialization;
using Telerik.Sitefinity.Localization;

namespace timw255.Sitefinity.CustomErrorPages.Web.Services.CustomErrorPageItems.ViewModels
{
    /// <summary>
    /// A view model for the CustomErrorPageItem class.
    /// This view model is used by the services.
    /// </summary>
    [DataContract]
    public class CustomErrorPageItemViewModel
    {
        #region Properties
        /// <summary>
        /// Gets the unique identity of the data item.
        /// </summary>
        /// <value>The id.</value>
        [DataMember]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the last modified.
        /// </summary>
        /// <value>The last modified.</value>
        [DataMember]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Gets or sets the date created.
        /// </summary>
        /// <value>The date created.</value>
        [DataMember]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the StatusCode.
        /// </summary>
        [DataMember]
        public string StatusCode { get; set; }

        /// <summary>
        /// Gets or sets the PageId.
        /// </summary>
        [DataMember]
        public Guid PageId { get; set; }

        #endregion

        #region Labels and messages
        /// <summary>
        /// Gets the localized text for "actions" label
        /// </summary>
        [DataMember]
        public string ActionsLabel
        {
            get
            {
                return Res.Get<CustomErrorPagesResources>().ActionsLabel;
            }
            set
            {
                // do nothing; serializer requirement
            }
        }

        /// <summary>
        /// Gets the localized text for the "delete" label
        /// </summary>
        [DataMember]
        public string DeleteLabel
        {
            get
            {
                return Res.Get<CustomErrorPagesResources>().DeleteLabel;
            }
            set
            {
                // do nothing; serializer requirement
            }
        }
        #endregion
    }
}