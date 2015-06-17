using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using Telerik.Sitefinity.Abstractions;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Localization;
using Telerik.Sitefinity.Modules.GenericContent.Configuration;
using Telerik.Sitefinity.Web.Configuration;
using timw255.Sitefinity.CustomErrorPages.Data.EntityFramework;

namespace timw255.Sitefinity.CustomErrorPages.Configuration
{
    /// <summary>
    /// Represents the configuration section for CustomErrorPages module.
    /// </summary>
    [ObjectInfo(Title = "CustomErrorPages Config Title", Description = "CustomErrorPages Config Description")]
    public class CustomErrorPagesConfig : ModuleConfigBase
    {
        #region Public and overriden methods
        protected override void InitializeDefaultProviders(ConfigElementDictionary<string, DataProviderSettings> providers)
        {
            providers.Add(new DataProviderSettings(providers)
            {
                Name = "CustomErrorPagesEFDataProvider",
                Title = "Default Products",
                Description = "A provider that stores products data in database using Entity Framework.",
                ProviderType = typeof(CustomErrorPagesEFDataProvider),
                Parameters = new NameValueCollection() { { "applicationName", "/CustomErrorPages" } }
            });
        }

        /// <summary>
        /// Gets or sets the name of the default data provider. 
        /// </summary>
        [DescriptionResource(typeof(ConfigDescriptions), "DefaultProvider")]
        [ConfigurationProperty("defaultProvider", DefaultValue = "CustomErrorPagesEFDataProvider")]
        public override string DefaultProvider
        {
            get
            {
                return (string)this["defaultProvider"];
            }
            set
            {
                this["defaultProvider"] = value;
            }
        }
        #endregion
    }
}