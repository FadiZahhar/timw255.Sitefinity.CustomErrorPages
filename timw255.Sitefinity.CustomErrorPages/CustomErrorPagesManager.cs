using System;
using System.Linq;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Data;
using timw255.Sitefinity.CustomErrorPages.Configuration;
using timw255.Sitefinity.CustomErrorPages.Models;

namespace timw255.Sitefinity.CustomErrorPages
{
    public class CustomErrorPagesManager : ManagerBase<CustomErrorPagesDataProvider>
    {
        #region Construction
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomErrorPagesManager" /> class.
        /// </summary>
        public CustomErrorPagesManager()
            : this(null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomErrorPagesManager" /> class.
        /// </summary>
        /// <param name="providerName">Name of the provider.</param>
        public CustomErrorPagesManager(string providerName)
            : base(providerName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomErrorPagesManager" /> class.
        /// </summary>
        /// <param name="providerName">Name of the provider.</param>
        /// <param name="transactionName">Name of the transaction.</param>
        public CustomErrorPagesManager(string providerName, string transactionName)
            : base(providerName, transactionName)
        {
        }
        #endregion

        #region Public and overriden methods
        /// <summary>
        /// Gets the default provider delegate.
        /// </summary>
        /// <value>The default provider delegate.</value>
        protected override GetDefaultProvider DefaultProviderDelegate
        {
            get
            {
                return () => Config.Get<CustomErrorPagesConfig>().DefaultProvider;
            }
        }

        /// <summary>
        /// Gets the name of the module.
        /// </summary>
        /// <value>The name of the module.</value>
        public override string ModuleName
        {
            get
            {
                return CustomErrorPagesModule.ModuleName;
            }
        }

        /// <summary>
        /// Gets the providers settings.
        /// </summary>
        /// <value>The providers settings.</value>
        protected override ConfigElementDictionary<string, DataProviderSettings> ProvidersSettings
        {
            get
            {
                return Config.Get<CustomErrorPagesConfig>().Providers;
            }
        }

        /// <summary>
        /// Get an instance of the timw255.Sitefinity.CustomErrorPages manager using the default provider.
        /// </summary>
        /// <returns>Instance of the timw255.Sitefinity.CustomErrorPages manager</returns>
        public static CustomErrorPagesManager GetManager()
        {
            return ManagerBase<CustomErrorPagesDataProvider>.GetManager<CustomErrorPagesManager>();
        }

        /// <summary>
        /// Get an instance of the timw255.Sitefinity.CustomErrorPages manager by explicitly specifying the required provider to use
        /// </summary>
        /// <param name="providerName">Name of the provider to use, or null/empty string to use the default provider.</param>
        /// <returns>Instance of the timw255.Sitefinity.CustomErrorPages manager</returns>
        public static CustomErrorPagesManager GetManager(string providerName)
        {
            return ManagerBase<CustomErrorPagesDataProvider>.GetManager<CustomErrorPagesManager>(providerName);
        }

        /// <summary>
        /// Get an instance of the timw255.Sitefinity.CustomErrorPages manager by explicitly specifying the required provider to use
        /// </summary>
        /// <param name="providerName">Name of the provider to use, or null/empty string to use the default provider.</param>
        /// <param name="transactionName">Name of the transaction.</param>
        /// <returns>Instance of the timw255.Sitefinity.CustomErrorPages manager</returns>
        public static CustomErrorPagesManager GetManager(string providerName, string transactionName)
        {
            return ManagerBase<CustomErrorPagesDataProvider>.GetManager<CustomErrorPagesManager>(providerName, transactionName);
        }

        /// <summary>
        /// Creates a CustomErrorPageItem.
        /// </summary>
        /// <returns>The created CustomErrorPageItem.</returns>
        public CustomErrorPageItem CreateCustomErrorPageItem()
        {
            return this.Provider.CreateCustomErrorPageItem();
        }

        /// <summary>
        /// Updates the CustomErrorPageItem.
        /// </summary>
        /// <param name="entity">The CustomErrorPageItem entity.</param>
        public void UpdateCustomErrorPageItem(CustomErrorPageItem entity)
        {
            this.Provider.UpdateCustomErrorPageItem(entity);
        }

        /// <summary>
        /// Deletes the CustomErrorPageItem.
        /// </summary>
        /// <param name="entity">The CustomErrorPageItem entity.</param>
        public void DeleteCustomErrorPageItem(CustomErrorPageItem entity)
        {
            this.Provider.DeleteCustomErrorPageItem(entity);
        }

        /// <summary>
        /// Gets the CustomErrorPageItem by a specified ID.
        /// </summary>
        /// <param name="id">The ID.</param>
        /// <returns>The CustomErrorPageItem.</returns>
        public CustomErrorPageItem GetCustomErrorPageItem(Guid id)
        {
            return this.Provider.GetCustomErrorPageItem(id);
        }

        /// <summary>
        /// Gets a query of all the CustomErrorPageItem items.
        /// </summary>
        /// <returns>The CustomErrorPageItem items.</returns>
        public IQueryable<CustomErrorPageItem> GetCustomErrorPageItems()
        {
            return this.Provider.GetCustomErrorPageItems();
        }
        #endregion
    }
}