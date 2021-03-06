﻿using System;
using System.Linq;
using System.Runtime.Serialization;

namespace timw255.Sitefinity.CustomErrorPages.Web.Services.CustomErrorPageItems.ViewModels
{
    /// <summary>
    /// A view model for the customErrorPageItem properties.
    /// This view model is used by the services.
    /// </summary>
    [DataContract]
    public class CustomErrorPageItemPropertyViewModel
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [DataMember]
        public string Name
        {
            get;
            set;
        }
    }
}
