using System;
using System.Collections.Specialized;
using System.Data.Entity;
using System.Linq;
using Telerik.Microsoft.Practices.Unity;
using Telerik.Sitefinity.Abstractions;
using Telerik.Sitefinity.Data.Decorators;
using timw255.Sitefinity.CustomErrorPages.Data.EntityFramework.Decorators;
using timw255.Sitefinity.CustomErrorPages.Models;


namespace timw255.Sitefinity.CustomErrorPages.Data.EntityFramework
{
    public class CustomErrorPagesEFDataProvider : CustomErrorPagesDataProvider, ICustomErrorPagesEFDataProvider
    {
        #region CustomErrorPagesDataProvider
        protected override void Initialize(string providerName, NameValueCollection config, Type managerType, bool initializeDecorator)
        {
            if (!ObjectFactory.IsTypeRegistered(typeof(CustomErrorPagesEFDataProviderDecorator)))
                ObjectFactory.Container.RegisterType<IDataProviderDecorator, CustomErrorPagesEFDataProviderDecorator>(typeof(CustomErrorPagesEFDataProviderDecorator).FullName);

            base.Initialize(providerName, config, managerType, initializeDecorator);
        }

        public override IQueryable<CustomErrorPageItem> GetCustomErrorPageItems()
        {
            return this.Context.CustomErrorPageItems.Where(p => p.ApplicationName == this.ApplicationName);
        }

        public override CustomErrorPageItem GetCustomErrorPageItem(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentException("Id cannot be Empty Guid");

            return this.Context.CustomErrorPageItems.Find(id);
        }

        public override CustomErrorPageItem CreateCustomErrorPageItem()
        {
            Guid id = Guid.NewGuid();
            var item = new CustomErrorPageItem(id, this.ApplicationName);

            return this.Context.CustomErrorPageItems.Add(item);
        }

        public override void UpdateCustomErrorPageItem(CustomErrorPageItem entity)
        {
            var context = this.Context;

            if (context.Entry(entity).State == EntityState.Detached)
                context.CustomErrorPageItems.Attach(entity);

            context.Entry(entity).State = EntityState.Modified;
            entity.LastModified = DateTime.UtcNow;
        }

        public override void DeleteCustomErrorPageItem(CustomErrorPageItem entity)
        {
            var context = this.Context;

            if (context.Entry(entity).State == EntityState.Detached)
                context.CustomErrorPageItems.Attach(entity);

            context.CustomErrorPageItems.Remove(entity);
        }
        #endregion

        #region ICustomErrorPagesEFDataProvider
        public CustomErrorPagesEFDataProviderContext ProviderContext { get; set; }

        public CustomErrorPagesEFDbContext Context
        {
            get
            {
                return (CustomErrorPagesEFDbContext)this.GetTransaction();
            }
        }
        #endregion
    }
}