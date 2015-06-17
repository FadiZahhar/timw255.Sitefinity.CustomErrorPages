using System;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using timw255.Sitefinity.CustomErrorPages.Models;

namespace timw255.Sitefinity.CustomErrorPages.Data.EntityFramework.EntityConfigurations
{
    public class CustomErrorPageItemTypeConfiguration : EntityTypeConfiguration<CustomErrorPageItem>
    {
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomErrorPageItemTypeConfiguration" /> class.
        /// </summary>
        public CustomErrorPageItemTypeConfiguration()
        {
            this.ToTable("CustomErrorPages_CustomErrorPageItems");
            this.HasKey(x => x.Id);
            this.Property(x => x.StatusCode).IsRequired().HasMaxLength(255);
            this.Property(x => x.PageId).IsRequired();
            this.Property(x => x.LastModified);
            this.Property(x => x.DateCreated);
            this.Property(x => x.ApplicationName);
        }
        #endregion
    }
}