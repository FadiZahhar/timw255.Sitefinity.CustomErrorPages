using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using Telerik.Sitefinity.Utilities.MS.ServiceModel.Web;
using Telerik.Sitefinity.Web.Services;
using timw255.Sitefinity.CustomErrorPages.Web.Services.CustomErrorPageItems.ViewModels;

namespace timw255.Sitefinity.CustomErrorPages.Web.Services.CustomErrorPageItems
{
    /// <summary>
    /// Provides contracts for loading and manipulating CustomErrorPages data items (e.g. customErrorPageItems)
    /// </summary>
    [ServiceContract]
    public interface ICustomErrorPageItemsService
    {
        /// <summary>
        /// Gets all customErrorPageItems for the given provider. The results are returned in JSON format.
        /// </summary>
        /// <param name="provider">Name of the provider from which the customErrorPageItems ought to be retrieved.</param>
        /// <param name="sortExpression">Sort expression used to order the customErrorPageItems.</param>
        /// <param name="skip">Number of customErrorPageItems to skip in result set. (used for paging)</param>
        /// <param name="take">Number of customErrorPageItems to take in the result set. (used for paging)</param>
        /// <param name="filter">Dynamic LINQ expression used to filter the wanted result set.</param>
        /// <returns>
        /// Collection context object of <see cref="CustomErrorPageItemViewModel"/> objects.
        /// </returns>
        [WebHelp(Comment = "Gets all customErrorPageItems of the CustomErrorPages module for the given provider. The results are returned in JSON format.")]
        [WebGet(UriTemplate = "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        CollectionContext<CustomErrorPageItemViewModel> GetCustomErrorPageItems(string provider, string sortExpression, int skip, int take, string filter);

        /// <summary>
        /// Gets all customErrorPageItems for the given provider. The results are returned in XML format.
        /// </summary>
        /// <param name="provider">Name of the provider from which the customErrorPageItems ought to be retrieved.</param>
        /// <param name="sortExpression">Sort expression used to order the customErrorPageItems.</param>
        /// <param name="skip">Number of customErrorPageItems to skip in result set. (used for paging)</param>
        /// <param name="take">Number of customErrorPageItems to take in the result set. (used for paging)</param>
        /// <param name="filter">Dynamic LINQ expression used to filter the wanted result set.</param>
        /// <returns>
        /// Collection context object of <see cref="CustomErrorPageItemViewModel"/> objects.
        /// </returns>
        [WebHelp(Comment = "Gets all customErrorPageItems of the CustomErrorPages module for the given provider. The results are returned in XML format.")]
        [WebGet(UriTemplate = "/xml/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", ResponseFormat = WebMessageFormat.Xml)]
        [OperationContract]
        CollectionContext<CustomErrorPageItemViewModel> GetCustomErrorPageItemsInXml(string provider, string sortExpression, int skip, int take, string filter);

        /// <summary>
        /// Gets the customErrorPageItem by it's id. The results are returned in JSON format.
        /// </summary>
        /// <param name="customErrorPageItemId">Id of the customErrorPageItem to be retrieved.</param>
        /// <returns>
        /// Item context object of <see cref="CustomErrorPageItemViewModel"/> objects.
        /// </returns>
        [WebHelp(Comment = "Gets the customErrorPageItem by it's id. The results are returned in JSON format.")]
        [WebGet(UriTemplate = "/{customErrorPageItemId}/", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        ItemContext<CustomErrorPageItemViewModel> GetCustomErrorPageItem(string customErrorPageItemId);

        /// <summary>
        /// Gets the customErrorPageItem by it's id. The results are returned in JSON format.
        /// </summary>
        /// <param name="customErrorPageItemId">Id of the customErrorPageItem to be retrieved.</param>
        /// <returns>
        /// Item context object of <see cref="CustomErrorPageItemViewModel"/> objects.
        /// </returns>
        [WebHelp(Comment = "Gets the customErrorPageItem by it's id. The results are returned in JSON format.")]
        [WebGet(UriTemplate = "/xml/{customErrorPageItemId}/", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        ItemContext<CustomErrorPageItemViewModel> GetCustomErrorPageItemInXml(string customErrorPageItemId);

        /// <summary>
        /// Saves a customErrorPageItem. If the customErrorPageItem with specified id exists that customErrorPageItem will be updated; otherwise new customErrorPageItem will be created.
        /// The saved customErrorPageItem is returned in JSON format.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="customErrorPageItemId">The customErrorPageItem id.</param>
        /// <param name="provider">The provider name through which the customErrorPageItem ought to be saved.</param>
        /// <returns>The saved customErrorPageItem.</returns>
        [WebHelp(Comment = "Saves a customErrorPageItem. If the customErrorPageItem with specified id exists that customErrorPageItem will be updated; otherwise new customErrorPageItem will be created. The saved customErrorPageItem is returned in JSON format.")]
        [WebInvoke(Method = "PUT", UriTemplate = "/{customErrorPageItemId}/?provider={provider}", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        ItemContext<CustomErrorPageItemViewModel> SaveCustomErrorPageItem(ItemContext<CustomErrorPageItemViewModel> context, string customErrorPageItemId, string provider);

        /// <summary>
        /// Saves a customErrorPageItem. If the customErrorPageItem with specified id exists that customErrorPageItem will be updated; otherwise new customErrorPageItem will be created.
        /// The saved customErrorPageItem is returned in XML format.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="customErrorPageItemId">The customErrorPageItem id.</param>
        /// <param name="provider">The provider name through which the customErrorPageItem ought to be saved.</param>
        /// <returns>The saved customErrorPageItem.</returns>
        [WebHelp(Comment = "Saves a customErrorPageItem. If the customErrorPageItem with specified id exists that customErrorPageItem will be updated; otherwise new customErrorPageItem will be created. The saved customErrorPageItem is returned in XML format.")]
        [WebInvoke(Method = "PUT", UriTemplate = "/xml/{customErrorPageItemId}/?provider={provider}", ResponseFormat = WebMessageFormat.Xml)]
        [OperationContract]
        ItemContext<CustomErrorPageItemViewModel> SaveCustomErrorPageItemInXml(ItemContext<CustomErrorPageItemViewModel> context, string customErrorPageItemId, string provider);

        /// <summary>
        /// Deletes the customErrorPageItem.
        /// </summary>
        /// <param name="customErrorPageItemId">The customErrorPageItem id.</param>
        /// <param name="provider">The provider.</param>
        [WebHelp(Comment = "Deletes the customErrorPageItem.")]
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/{customErrorPageItemId}/?provider={provider}", ResponseFormat = WebMessageFormat.Json)]
        bool DeleteCustomErrorPageItem(string customErrorPageItemId, string provider);

        /// <summary>
        /// Deletes the customErrorPageItem.
        /// </summary>
        /// <param name="customErrorPageItemId">The customErrorPageItem id.</param>
        /// <param name="provider">The provider.</param>
        [WebHelp(Comment = "Deletes the customErrorPageItem.")]
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/xml/{customErrorPageItemId}/?provider={provider}", ResponseFormat = WebMessageFormat.Xml)]
        bool DeleteCustomErrorPageItemInXml(string customErrorPageItemId, string provider);

        /// <summary>
        /// Deletes a collection of customErrorPageItems. Result is returned in JSON format.
        /// </summary>
        /// <param name="ids">An array of the ids of the customErrorPageItems to delete.</param>
        /// <param name="provider">The name of the customErrorPageItems provider.</param>
        /// <returns>True if all customErrorPageItems have been deleted; otherwise false.</returns>
        [WebHelp(Comment = "Deletes multiple customErrorPageItems.")]
        [WebInvoke(Method = "POST", UriTemplate = "/batch/?provider={provider}", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        bool BatchDeleteCustomErrorPageItems(string[] ids, string provider);

        /// <summary>
        /// Deletes a collection of customErrorPageItems. Result is returned in XML format.
        /// </summary>
        /// <param name="ids">An array of the ids of the customErrorPageItems to delete.</param>
        /// <param name="provider">The name of the customErrorPageItems provider.</param>
        /// <returns>True if all customErrorPageItems have been deleted; otherwise false.</returns>
        [WebHelp(Comment = "Deletes multiple customErrorPageItems.")]
        [WebInvoke(Method = "POST", UriTemplate = "/xml/batch/?provider={provider}", ResponseFormat = WebMessageFormat.Xml)]
        [OperationContract]
        bool BatchDeleteCustomErrorPageItemsInXml(string[] ids, string provider);

        /// <summary>
        /// Gets the properties for the model. The results are returned in JSON format.
        /// </summary>
        /// <returns>
        /// Collection context object of <see cref="CustomErrorPageItemPropertyViewModel"/> objects.
        /// </returns>
        [WebHelp(Comment = "Get customErrorPageItem properties.")]
        [WebGet(UriTemplate = "/model/properties/", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        CollectionContext<CustomErrorPageItemPropertyViewModel> GetProperties();

    }
}