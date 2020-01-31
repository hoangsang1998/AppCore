using AppCore.Data.Enums;
using AppCore.Data.Interfaces;
using AppCore.Infrastucture.SharedKernel;
using System;
using System.Collections.Generic;

namespace AppCore.Data.Entities
{
    public class ProductCategory : DomainEntity<int>, IHasSeoMetaData, ISwichable, ISortable, IDateTracking
    {
        public ProductCategory()
        {
            Products = new List<Product>();
        }


        public string Name { get; set; }

        public string Description { get; set; }

        public int? ParentId { get; set; }

        public int? HomeOrder { get; set; }

        public string Image { get; set; }

        public bool? HomeFlag { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModyfied { get; set; }
        public int SortOrder { get; set; }
        public Status Status { get; set; }
        public string SeoPageTitle { get; set; }
        public string SeoAlias { get; set; }
        public string SeoKeyWords { get; set; }
        public string SeoDecription { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}