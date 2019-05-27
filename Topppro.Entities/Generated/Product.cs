//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Xml.Serialization;


namespace Topppro.Entities
{
    [Serializable]
    public partial class Product
    {
        #region Primitive Properties
    
        public virtual int ProductId
        {
            get;
            set;
        }
    
        public virtual int ModelId
        {
            get { return _modelId; }
            set
            {
                if (_modelId != value)
                {
                    if (Model != null && Model.ModelId != value)
                    {
                        Model = null;
                    }
                    _modelId = value;
                }
            }
        }
        private int _modelId;
    
        public virtual string Name
        {
            get;
            set;
        }
    
        public virtual string Folder
        {
            get;
            set;
        }
    
        public virtual string Manual
        {
            get;
            set;
        }
    
        public virtual bool Draft
        {
            get;
            set;
        }
    
        public virtual string Badge
        {
            get;
            set;
        }
    
        public virtual bool Software
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
    	//[XmlElement("Assn_CategorySerieProduct", typeof(Collection<Assn_CategorySerieProduct>))]
        public virtual ICollection<Assn_CategorySerieProduct> Assn_CategorySerieProduct
        {
            get
            {
                if (_assn_CategorySerieProduct == null)
                {
                    var newCollection = new FixupCollection<Assn_CategorySerieProduct>();
                    newCollection.CollectionChanged += FixupAssn_CategorySerieProduct;
                    _assn_CategorySerieProduct = newCollection;
                }
                return _assn_CategorySerieProduct;
            }
            set
            {
                if (!ReferenceEquals(_assn_CategorySerieProduct, value))
                {
                    var previousValue = _assn_CategorySerieProduct as FixupCollection<Assn_CategorySerieProduct>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupAssn_CategorySerieProduct;
                    }
                    _assn_CategorySerieProduct = value;
                    var newValue = value as FixupCollection<Assn_CategorySerieProduct>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupAssn_CategorySerieProduct;
                    }
                }
            }
        }
    	//[XmlElement("Assn_CategorySerieProduct", typeof(Collection<Assn_CategorySerieProduct>))]
        private ICollection<Assn_CategorySerieProduct> _assn_CategorySerieProduct;
    
        public virtual Model Model
        {
            get { return _model; }
            set
            {
                if (!ReferenceEquals(_model, value))
                {
                    var previousValue = _model;
                    _model = value;
                    FixupModel(previousValue);
                }
            }
        }
        private Model _model;
    
    	//[XmlElement("ChildInPackages", typeof(Collection<Package>))]
        public virtual ICollection<Package> ChildInPackages
        {
            get
            {
                if (_childInPackages == null)
                {
                    var newCollection = new FixupCollection<Package>();
                    newCollection.CollectionChanged += FixupChildInPackages;
                    _childInPackages = newCollection;
                }
                return _childInPackages;
            }
            set
            {
                if (!ReferenceEquals(_childInPackages, value))
                {
                    var previousValue = _childInPackages as FixupCollection<Package>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupChildInPackages;
                    }
                    _childInPackages = value;
                    var newValue = value as FixupCollection<Package>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupChildInPackages;
                    }
                }
            }
        }
    	//[XmlElement("ChildInPackages", typeof(Collection<Package>))]
        private ICollection<Package> _childInPackages;
    
    	//[XmlElement("ParentInPackages", typeof(Collection<Package>))]
        public virtual ICollection<Package> ParentInPackages
        {
            get
            {
                if (_parentInPackages == null)
                {
                    var newCollection = new FixupCollection<Package>();
                    newCollection.CollectionChanged += FixupParentInPackages;
                    _parentInPackages = newCollection;
                }
                return _parentInPackages;
            }
            set
            {
                if (!ReferenceEquals(_parentInPackages, value))
                {
                    var previousValue = _parentInPackages as FixupCollection<Package>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupParentInPackages;
                    }
                    _parentInPackages = value;
                    var newValue = value as FixupCollection<Package>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupParentInPackages;
                    }
                }
            }
        }
    	//[XmlElement("ParentInPackages", typeof(Collection<Package>))]
        private ICollection<Package> _parentInPackages;
    
    	//[XmlElement("Bullets", typeof(Collection<Bullet>))]
        public virtual ICollection<Bullet> Bullets
        {
            get
            {
                if (_bullets == null)
                {
                    var newCollection = new FixupCollection<Bullet>();
                    newCollection.CollectionChanged += FixupBullets;
                    _bullets = newCollection;
                }
                return _bullets;
            }
            set
            {
                if (!ReferenceEquals(_bullets, value))
                {
                    var previousValue = _bullets as FixupCollection<Bullet>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupBullets;
                    }
                    _bullets = value;
                    var newValue = value as FixupCollection<Bullet>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupBullets;
                    }
                }
            }
        }
    	//[XmlElement("Bullets", typeof(Collection<Bullet>))]
        private ICollection<Bullet> _bullets;
    
    	//[XmlElement("Attributes", typeof(Collection<Attribute>))]
        public virtual ICollection<Attribute> Attributes
        {
            get
            {
                if (_attributes == null)
                {
                    var newCollection = new FixupCollection<Attribute>();
                    newCollection.CollectionChanged += FixupAttributes;
                    _attributes = newCollection;
                }
                return _attributes;
            }
            set
            {
                if (!ReferenceEquals(_attributes, value))
                {
                    var previousValue = _attributes as FixupCollection<Attribute>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupAttributes;
                    }
                    _attributes = value;
                    var newValue = value as FixupCollection<Attribute>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupAttributes;
                    }
                }
            }
        }
    	//[XmlElement("Attributes", typeof(Collection<Attribute>))]
        private ICollection<Attribute> _attributes;
    
    	//[XmlElement("Downloads", typeof(Collection<Download>))]
        public virtual ICollection<Download> Downloads
        {
            get
            {
                if (_downloads == null)
                {
                    var newCollection = new FixupCollection<Download>();
                    newCollection.CollectionChanged += FixupDownloads;
                    _downloads = newCollection;
                }
                return _downloads;
            }
            set
            {
                if (!ReferenceEquals(_downloads, value))
                {
                    var previousValue = _downloads as FixupCollection<Download>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupDownloads;
                    }
                    _downloads = value;
                    var newValue = value as FixupCollection<Download>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupDownloads;
                    }
                }
            }
        }
    	//[XmlElement("Downloads", typeof(Collection<Download>))]
        private ICollection<Download> _downloads;

        #endregion
        #region Association Fixup
    
        private void FixupModel(Model previousValue)
        {
            if (previousValue != null && previousValue.Products.Contains(this))
            {
                previousValue.Products.Remove(this);
            }
    
            if (Model != null)
            {
                if (!Model.Products.Contains(this))
                {
                    Model.Products.Add(this);
                }
                if (ModelId != Model.ModelId)
                {
                    ModelId = Model.ModelId;
                }
            }
        }
    
        private void FixupAssn_CategorySerieProduct(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Assn_CategorySerieProduct item in e.NewItems)
                {
                    item.Product = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Assn_CategorySerieProduct item in e.OldItems)
                {
                    if (ReferenceEquals(item.Product, this))
                    {
                        item.Product = null;
                    }
                }
            }
        }
    
        private void FixupChildInPackages(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Package item in e.NewItems)
                {
                    item.ChildProduct = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Package item in e.OldItems)
                {
                    if (ReferenceEquals(item.ChildProduct, this))
                    {
                        item.ChildProduct = null;
                    }
                }
            }
        }
    
        private void FixupParentInPackages(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Package item in e.NewItems)
                {
                    item.ParentProduct = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Package item in e.OldItems)
                {
                    if (ReferenceEquals(item.ParentProduct, this))
                    {
                        item.ParentProduct = null;
                    }
                }
            }
        }
    
        private void FixupBullets(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Bullet item in e.NewItems)
                {
                    item.Product = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Bullet item in e.OldItems)
                {
                    if (ReferenceEquals(item.Product, this))
                    {
                        item.Product = null;
                    }
                }
            }
        }
    
        private void FixupAttributes(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Attribute item in e.NewItems)
                {
                    item.Product = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Attribute item in e.OldItems)
                {
                    if (ReferenceEquals(item.Product, this))
                    {
                        item.Product = null;
                    }
                }
            }
        }
    
        private void FixupDownloads(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Download item in e.NewItems)
                {
                    item.Product = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Download item in e.OldItems)
                {
                    if (ReferenceEquals(item.Product, this))
                    {
                        item.Product = null;
                    }
                }
            }
        }

        #endregion
    }
}
