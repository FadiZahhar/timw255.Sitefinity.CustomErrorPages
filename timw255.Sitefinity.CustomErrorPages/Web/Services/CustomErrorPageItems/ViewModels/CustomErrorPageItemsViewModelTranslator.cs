using System;
using System.Linq;
using timw255.Sitefinity.CustomErrorPages.Models;

namespace timw255.Sitefinity.CustomErrorPages.Web.Services.CustomErrorPageItems.ViewModels
{
    /// <summary>
    /// Provides methods for translating view models to models and vice versa for the CustomErrorPages module.
    /// </summary>
    public static class CustomErrorPageItemsViewModelTranslator
    {
        #region CustomErrorPageItem
        /// <summary>
        /// Translates CustomErrorPageItem view model to CustomErrorPageItem model.
        /// </summary>
        /// <param name="source">
        /// An instance of the <see cref="CustomErrorPageItemViewModel"/>.
        /// </param>
        /// <param name="target">
        /// An instance of the <see cref="CustomErrorPageItem"/>.
        /// </param>
        public static void ToModel(CustomErrorPageItemViewModel source, CustomErrorPageItem target, CustomErrorPagesManager manager)
        {
            target.StatusCode = source.StatusCode;
            target.PageId = source.PageId;
        }

        /// <summary>
        /// Translates CustomErrorPageItem to CustomErrorPageItem view model.
        /// </summary>
        /// <param name="source">
        /// An instance of the <see cref="CustomErrorPageItem"/>.
        /// </param>
        /// <param name="target">
        /// An instance of the <see cref="CustomErrorPageItemViewModel"/>.
        /// </param>
        public static void ToViewModel(CustomErrorPageItem source, CustomErrorPageItemViewModel target, CustomErrorPagesManager manager)
        {
            target.Id = source.Id;
            target.LastModified = source.LastModified;
            target.DateCreated = source.DateCreated;

            target.StatusCode = source.StatusCode;
            target.PageId = source.PageId;
        }
        #endregion
    }
}
