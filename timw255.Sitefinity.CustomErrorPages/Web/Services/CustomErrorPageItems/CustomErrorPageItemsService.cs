using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using Telerik.Sitefinity.Data.Linq.Dynamic;
using Telerik.Sitefinity.Web.Services;
using timw255.Sitefinity.CustomErrorPages.Models;
using timw255.Sitefinity.CustomErrorPages.Web.Services.CustomErrorPageItems.ViewModels;

namespace timw255.Sitefinity.CustomErrorPages.Web.Services.CustomErrorPageItems
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true, InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class CustomErrorPageItemsService : ICustomErrorPageItemsService
    {
        #region ICustomErrorPageItems
        /// <inheritdoc/>
        public CollectionContext<CustomErrorPageItemViewModel> GetCustomErrorPageItems(string provider, string sortExpression, int skip, int take, string filter)
        {
            ServiceUtility.DisableCache();
            return this.GetCustomErrorPageItemsInternal(provider, sortExpression, skip, take, filter);
        }

        /// <inheritdoc/>
        public CollectionContext<CustomErrorPageItemViewModel> GetCustomErrorPageItemsInXml(string provider, string sortExpression, int skip, int take, string filter)
        {
            ServiceUtility.DisableCache();
            return this.GetCustomErrorPageItemsInternal(provider, sortExpression, skip, take, filter);
        }

        /// <inheritdoc/>
        public ItemContext<CustomErrorPageItemViewModel> SaveCustomErrorPageItem(ItemContext<CustomErrorPageItemViewModel> context, string customErrorPageItemId, string provider)
        {
            ServiceUtility.DisableCache();
            return this.SaveCustomErrorPageItemInternal(context, customErrorPageItemId, provider);
        }

        /// <inheritdoc/>
        public ItemContext<CustomErrorPageItemViewModel> SaveCustomErrorPageItemInXml(ItemContext<CustomErrorPageItemViewModel> context, string customErrorPageItemId, string provider)
        {
            ServiceUtility.DisableCache();
            return this.SaveCustomErrorPageItemInternal(context, customErrorPageItemId, provider);
        }

        /// <inheritdoc/>
        public bool DeleteCustomErrorPageItem(string customErrorPageItemId, string provider)
        {
            ServiceUtility.DisableCache();
            return this.DeleteCustomErrorPageItemInternal(customErrorPageItemId, provider);
        }

        /// <inheritdoc/>
        public bool DeleteCustomErrorPageItemInXml(string customErrorPageItemId, string provider)
        {
            ServiceUtility.DisableCache();
            return this.DeleteCustomErrorPageItemInternal(customErrorPageItemId, provider);
        }

        /// <inheritdoc/>
        public bool BatchDeleteCustomErrorPageItems(string[] ids, string provider)
        {
            ServiceUtility.DisableCache();
            return this.BatchDeleteCustomErrorPageItemsInternal(ids, provider);
        }

        /// <inheritdoc/>
        public bool BatchDeleteCustomErrorPageItemsInXml(string[] ids, string provider)
        {
            ServiceUtility.DisableCache();
            return this.BatchDeleteCustomErrorPageItemsInternal(ids, provider);
        }

        /// <inheritdoc/>
        public ItemContext<CustomErrorPageItemViewModel> GetCustomErrorPageItem(string customErrorPageItemId)
        {
            ServiceUtility.DisableCache();
            return this.GetCustomErrorPageItemInternal(customErrorPageItemId);
        }

        /// <inheritdoc/>
        public ItemContext<CustomErrorPageItemViewModel> GetCustomErrorPageItemInXml(string customErrorPageItemId)
        {
            ServiceUtility.DisableCache();
            return this.GetCustomErrorPageItemInternal(customErrorPageItemId);
        }

        /// <inheritdoc/>
        public CollectionContext<CustomErrorPageItemPropertyViewModel> GetProperties()
        {
            ServiceUtility.DisableCache();
            return this.GetPropertiesInternal();
        }
        #endregion

        #region Non-public methods
        /// <summary>
        /// Gets the customErrorPageItems internal.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="sortExpression">The sort expression.</param>
        /// <param name="skip">The skip.</param>
        /// <param name="take">The take.</param>
        /// <param name="filter">The filter.</param>
        /// <returns></returns>
        private CollectionContext<CustomErrorPageItemViewModel> GetCustomErrorPageItemsInternal(string provider, string sortExpression, int skip, int take, string filter)
        {
            var manager = CustomErrorPagesManager.GetManager(provider);
            var customErrorPageItems = manager.GetCustomErrorPageItems();

            var totalCount = customErrorPageItems.Count();

            if (!string.IsNullOrEmpty(sortExpression))
                customErrorPageItems = customErrorPageItems.OrderBy(sortExpression);

            if (!string.IsNullOrEmpty(filter))
                customErrorPageItems = customErrorPageItems.Where(filter);

            if (skip > 0)
                customErrorPageItems = customErrorPageItems.Skip(skip);

            if (take > 0)
                customErrorPageItems = customErrorPageItems.Take(take);

            var customErrorPageItemsList = new List<CustomErrorPageItemViewModel>();

            foreach (var customErrorPageItem in customErrorPageItems)
            {
                var customErrorPageItemViewModel = new CustomErrorPageItemViewModel();
                CustomErrorPageItemsViewModelTranslator.ToViewModel(customErrorPageItem, customErrorPageItemViewModel, manager);
                customErrorPageItemsList.Add(customErrorPageItemViewModel);
            }

            return new CollectionContext<CustomErrorPageItemViewModel>(customErrorPageItemsList) { TotalCount = totalCount };
        }

        /// <summary>
        /// Saves the customErrorPageItem internal.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="customErrorPageItemId">The customErrorPageItem id.</param>
        /// <param name="provider">The provider.</param>
        /// <returns></returns>
        private ItemContext<CustomErrorPageItemViewModel> SaveCustomErrorPageItemInternal(ItemContext<CustomErrorPageItemViewModel> context, string customErrorPageItemId, string provider)
        {
            var manager = CustomErrorPagesManager.GetManager(provider);
            var id = new Guid(customErrorPageItemId);

            CustomErrorPageItem customErrorPageItem = null;

            if (id == Guid.Empty)
                customErrorPageItem = manager.CreateCustomErrorPageItem();
            else
                customErrorPageItem = manager.GetCustomErrorPageItem(id);

            CustomErrorPageItemsViewModelTranslator.ToModel(context.Item, customErrorPageItem, manager);

            if (id != Guid.Empty)
                manager.UpdateCustomErrorPageItem(customErrorPageItem);

            manager.SaveChanges();
            CustomErrorPageItemsViewModelTranslator.ToViewModel(customErrorPageItem, context.Item, manager);
            return context;
        }

        /// <summary>
        /// Deletes the customErrorPageItem internal.
        /// </summary>
        /// <param name="customErrorPageItemId">The customErrorPageItem id.</param>
        /// <param name="provider">The provider.</param>
        /// <returns></returns>
        private bool DeleteCustomErrorPageItemInternal(string customErrorPageItemId, string provider)
        {
            var manager = CustomErrorPagesManager.GetManager(provider);
            manager.DeleteCustomErrorPageItem(manager.GetCustomErrorPageItem(new Guid(customErrorPageItemId)));
            manager.SaveChanges();

            return true;
        }

        /// <summary>
        /// Batches the delete customErrorPageItems internal.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <param name="provider">The provider.</param>
        /// <returns></returns>
        private bool BatchDeleteCustomErrorPageItemsInternal(string[] ids, string provider)
        {
            var manager = CustomErrorPagesManager.GetManager(provider);
            foreach (var stringId in ids)
            {
                var customErrorPageItemId = new Guid(stringId);
                manager.DeleteCustomErrorPageItem(manager.GetCustomErrorPageItem(customErrorPageItemId));
            }
            manager.SaveChanges();

            return true;
        }

        /// <summary>
        /// Gets the customErrorPageItem internal.
        /// </summary>
        /// <param name="customErrorPageItemId">The customErrorPageItem id.</param>
        /// <returns></returns>
        private ItemContext<CustomErrorPageItemViewModel> GetCustomErrorPageItemInternal(string customErrorPageItemId)
        {
            var customErrorPageItemIdGuid = new Guid(customErrorPageItemId);
            var manager = CustomErrorPagesManager.GetManager();

            var customErrorPageItem = manager.GetCustomErrorPageItem(customErrorPageItemIdGuid);
            var customErrorPageItemViewModel = new CustomErrorPageItemViewModel();
            CustomErrorPageItemsViewModelTranslator.ToViewModel(customErrorPageItem, customErrorPageItemViewModel, manager);

            return new ItemContext<CustomErrorPageItemViewModel>()
            {
                Item = customErrorPageItemViewModel
            };
        }

        /// <summary>
        /// Gets the properties internal.
        /// </summary>
        /// <returns></returns>
        private CollectionContext<CustomErrorPageItemPropertyViewModel> GetPropertiesInternal()
        {
            List<CustomErrorPageItemPropertyViewModel> properties = new List<CustomErrorPageItemPropertyViewModel>();
            foreach (var property in typeof(timw255.Sitefinity.CustomErrorPages.Models.CustomErrorPageItem).GetProperties())
            {
                if (!this.systemProperties.Contains(property.Name))
                {
                    properties.Add(new CustomErrorPageItemPropertyViewModel() { Name = property.Name });
                }
            }
            return new CollectionContext<CustomErrorPageItemPropertyViewModel>(properties) { TotalCount = properties.Count() };
        }
        #endregion

        #region Non-public Fields
        private readonly IEnumerable<string> systemProperties = new List<string>()
        {
            "Id", "Transaction", "ApplicationName", "Provider",
        };
        #endregion
    }
}