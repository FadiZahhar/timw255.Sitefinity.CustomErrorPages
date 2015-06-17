using System;
using System.Linq;
using Telerik.Sitefinity.Data;
using Telerik.Sitefinity.Data.Decorators;
using timw255.Sitefinity.CustomErrorPages.Data.EntityFramework.Decorators;

namespace timw255.Sitefinity.CustomErrorPages.Data.EntityFramework
{
    [DataProviderDecorator(typeof(CustomErrorPagesEFDataProviderDecorator))]
    public interface ICustomErrorPagesEFDataProvider : IDataProviderBase
    {
        #region Methods
        /// <summary>
        /// Gets or sets the provider context.
        /// </summary>
        /// <value>The provider context.</value>
        CustomErrorPagesEFDataProviderContext ProviderContext { get; set; }

        /// <summary>
        /// Gets the db context.
        /// </summary>
        /// <value>The db context.</value>
        CustomErrorPagesEFDbContext Context { get; }
        #endregion
    }
}
