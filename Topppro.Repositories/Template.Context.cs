﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Topppro.Repositories
{
    using Topppro.Entities;
    using Attribute = Topppro.Entities.Attribute;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ToppproEntities : DbContext
    {
        public ToppproEntities()
            : base("name=ToppproEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Assn_CategorySerie> Assn_CategorySerie { get; set; }
        public virtual DbSet<Assn_CategorySerieProduct> Assn_CategorySerieProduct { get; set; }
        public virtual DbSet<Attribute> Attribute { get; set; }
        public virtual DbSet<Bullet> Bullet { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Culture> Culture { get; set; }
        public virtual DbSet<Distributor> Distributor { get; set; }
        public virtual DbSet<Download> Download { get; set; }
        public virtual DbSet<Model> Model { get; set; }
        public virtual DbSet<Package> Package { get; set; }
        public virtual DbSet<Platform> Platform { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Serie> Serie { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Assn_ProductRegion> Assn_ProductRegion { get; set; }
    
        public virtual int Assn_CategorySerie_Insert(Nullable<int> categoryId, Nullable<int> serieId, Nullable<int> priority, ObjectParameter id)
        {
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("CategoryId", categoryId) :
                new ObjectParameter("CategoryId", typeof(int));
    
            var serieIdParameter = serieId.HasValue ?
                new ObjectParameter("SerieId", serieId) :
                new ObjectParameter("SerieId", typeof(int));
    
            var priorityParameter = priority.HasValue ?
                new ObjectParameter("Priority", priority) :
                new ObjectParameter("Priority", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Assn_CategorySerie_Insert", categoryIdParameter, serieIdParameter, priorityParameter, id);
        }
    
        public virtual int Assn_CategorySerie_Reorder(Nullable<int> assnCategorySerieId, Nullable<int> priority)
        {
            var assnCategorySerieIdParameter = assnCategorySerieId.HasValue ?
                new ObjectParameter("AssnCategorySerieId", assnCategorySerieId) :
                new ObjectParameter("AssnCategorySerieId", typeof(int));
    
            var priorityParameter = priority.HasValue ?
                new ObjectParameter("Priority", priority) :
                new ObjectParameter("Priority", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Assn_CategorySerie_Reorder", assnCategorySerieIdParameter, priorityParameter);
        }
    
        public virtual int Assn_CategorySerieProduct_Insert(Nullable<int> assnCategorySerieId, Nullable<int> productId, Nullable<int> priority, ObjectParameter id)
        {
            var assnCategorySerieIdParameter = assnCategorySerieId.HasValue ?
                new ObjectParameter("AssnCategorySerieId", assnCategorySerieId) :
                new ObjectParameter("AssnCategorySerieId", typeof(int));
    
            var productIdParameter = productId.HasValue ?
                new ObjectParameter("ProductId", productId) :
                new ObjectParameter("ProductId", typeof(int));
    
            var priorityParameter = priority.HasValue ?
                new ObjectParameter("Priority", priority) :
                new ObjectParameter("Priority", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Assn_CategorySerieProduct_Insert", assnCategorySerieIdParameter, productIdParameter, priorityParameter, id);
        }
    
        public virtual int Assn_CategorySerieProduct_Reorder(Nullable<int> assnCategorySerieProductId, Nullable<int> priority)
        {
            var assnCategorySerieProductIdParameter = assnCategorySerieProductId.HasValue ?
                new ObjectParameter("AssnCategorySerieProductId", assnCategorySerieProductId) :
                new ObjectParameter("AssnCategorySerieProductId", typeof(int));
    
            var priorityParameter = priority.HasValue ?
                new ObjectParameter("Priority", priority) :
                new ObjectParameter("Priority", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Assn_CategorySerieProduct_Reorder", assnCategorySerieProductIdParameter, priorityParameter);
        }
    }
}
