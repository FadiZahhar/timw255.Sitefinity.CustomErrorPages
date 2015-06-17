using System;
using System.Linq;
using Telerik.Sitefinity.Data;
using timw255.Sitefinity.CustomErrorPages.Models;

namespace timw255.Sitefinity.CustomErrorPages
{
    public abstract class CustomErrorPagesDataProvider : DataProviderBase
    {
        #region Public and overriden methods
        /// <summary>
        /// Gets the known types.
        /// </summary>
        public override Type[] GetKnownTypes()
        {
            if (knownTypes == null)
            {
                knownTypes = new Type[]
                {
                    typeof(CustomErrorPageItem)
                };
            }
            return knownTypes;
        }

        /// <summary>
        /// Gets the root key.
        /// </summary>
        /// <value>The root key.</value>
        public override string RootKey
        {
            get
            {
                return "CustomErrorPagesDataProvider";
            }
        }
        #endregion

        #region Abstract methods
        /// <summary>
        /// Creates a new CustomErrorPageItem and returns it.
        /// </summary>
        /// <returns>The new CustomErrorPageItem.</returns>
        public abstract CustomErrorPageItem CreateCustomErrorPageItem();

        /// <summary>
        /// Gets a CustomErrorPageItem by a specified ID.
        /// </summary>
        /// <param name="id">The ID.</param>
        /// <returns>The CustomErrorPageItem.</returns>
        public abstract CustomErrorPageItem GetCustomErrorPageItem(Guid id);

        /// <summary>
        /// Gets a query of all the CustomErrorPageItem items.
        /// </summary>
        /// <returns>The CustomErrorPageItem items.</returns>
        public abstract IQueryable<CustomErrorPageItem> GetCustomErrorPageItems();

        /// <summary>
        /// Updates the CustomErrorPageItem.
        /// </summary>
        /// <param name="entity">The CustomErrorPageItem entity.</param>
        public abstract void UpdateCustomErrorPageItem(CustomErrorPageItem entity);

        /// <summary>
        /// Deletes the CustomErrorPageItem.
        /// </summary>
        /// <param name="entity">The CustomErrorPageItem entity.</param>
        public abstract void DeleteCustomErrorPageItem(CustomErrorPageItem entity);
        #endregion

        #region Private fields and constants
        private static Type[] knownTypes;
        #endregion
    }
}