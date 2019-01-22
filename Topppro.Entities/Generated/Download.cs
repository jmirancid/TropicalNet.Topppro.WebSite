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
    public partial class Download
    {
        #region Primitive Properties
    
        public virtual int DownloadId
        {
            get;
            set;
        }
    
        public virtual int ProductId
        {
            get { return _productId; }
            set
            {
                if (_productId != value)
                {
                    if (Product != null && Product.ProductId != value)
                    {
                        Product = null;
                    }
                    _productId = value;
                }
            }
        }
        private int _productId;
    
        public virtual string Resource
        {
            get;
            set;
        }
    
        public virtual Nullable<int> Priority
        {
            get;
            set;
        }
    
        public virtual bool Enabled
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
    	//[XmlElement("Assn_DownloadCulture", typeof(Collection<Assn_DownloadCulture>))]
        public virtual ICollection<Assn_DownloadCulture> Assn_DownloadCulture
        {
            get
            {
                if (_assn_DownloadCulture == null)
                {
                    var newCollection = new FixupCollection<Assn_DownloadCulture>();
                    newCollection.CollectionChanged += FixupAssn_DownloadCulture;
                    _assn_DownloadCulture = newCollection;
                }
                return _assn_DownloadCulture;
            }
            set
            {
                if (!ReferenceEquals(_assn_DownloadCulture, value))
                {
                    var previousValue = _assn_DownloadCulture as FixupCollection<Assn_DownloadCulture>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupAssn_DownloadCulture;
                    }
                    _assn_DownloadCulture = value;
                    var newValue = value as FixupCollection<Assn_DownloadCulture>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupAssn_DownloadCulture;
                    }
                }
            }
        }
    	//[XmlElement("Assn_DownloadCulture", typeof(Collection<Assn_DownloadCulture>))]
        private ICollection<Assn_DownloadCulture> _assn_DownloadCulture;
    
        public virtual Product Product
        {
            get { return _product; }
            set
            {
                if (!ReferenceEquals(_product, value))
                {
                    var previousValue = _product;
                    _product = value;
                    FixupProduct(previousValue);
                }
            }
        }
        private Product _product;

        #endregion
        #region Association Fixup
    
        private void FixupProduct(Product previousValue)
        {
            if (previousValue != null && previousValue.Download.Contains(this))
            {
                previousValue.Download.Remove(this);
            }
    
            if (Product != null)
            {
                if (!Product.Download.Contains(this))
                {
                    Product.Download.Add(this);
                }
                if (ProductId != Product.ProductId)
                {
                    ProductId = Product.ProductId;
                }
            }
        }
    
        private void FixupAssn_DownloadCulture(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Assn_DownloadCulture item in e.NewItems)
                {
                    item.Download = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Assn_DownloadCulture item in e.OldItems)
                {
                    if (ReferenceEquals(item.Download, this))
                    {
                        item.Download = null;
                    }
                }
            }
        }

        #endregion
    }
}
