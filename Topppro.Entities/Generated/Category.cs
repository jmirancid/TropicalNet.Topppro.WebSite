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
    public partial class Category
    {
        #region Primitive Properties
    
        public virtual int CategoryId
        {
            get;
            set;
        }
    
        public virtual string Name
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
    	//[XmlElement("Cat_Ser_Assn", typeof(Collection<Cat_Ser_Assn>))]
        public virtual ICollection<Cat_Ser_Assn> Cat_Ser_Assn
        {
            get
            {
                if (_cat_Ser_Assn == null)
                {
                    var newCollection = new FixupCollection<Cat_Ser_Assn>();
                    newCollection.CollectionChanged += FixupCat_Ser_Assn;
                    _cat_Ser_Assn = newCollection;
                }
                return _cat_Ser_Assn;
            }
            set
            {
                if (!ReferenceEquals(_cat_Ser_Assn, value))
                {
                    var previousValue = _cat_Ser_Assn as FixupCollection<Cat_Ser_Assn>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCat_Ser_Assn;
                    }
                    _cat_Ser_Assn = value;
                    var newValue = value as FixupCollection<Cat_Ser_Assn>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCat_Ser_Assn;
                    }
                }
            }
        }
    	//[XmlElement("Cat_Ser_Assn", typeof(Collection<Cat_Ser_Assn>))]
        private ICollection<Cat_Ser_Assn> _cat_Ser_Assn;
    
    	//[XmlElement("Cat_Ser_Pack_Assn", typeof(Collection<Cat_Ser_Pack_Assn>))]
        public virtual ICollection<Cat_Ser_Pack_Assn> Cat_Ser_Pack_Assn
        {
            get
            {
                if (_cat_Ser_Pack_Assn == null)
                {
                    var newCollection = new FixupCollection<Cat_Ser_Pack_Assn>();
                    newCollection.CollectionChanged += FixupCat_Ser_Pack_Assn;
                    _cat_Ser_Pack_Assn = newCollection;
                }
                return _cat_Ser_Pack_Assn;
            }
            set
            {
                if (!ReferenceEquals(_cat_Ser_Pack_Assn, value))
                {
                    var previousValue = _cat_Ser_Pack_Assn as FixupCollection<Cat_Ser_Pack_Assn>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCat_Ser_Pack_Assn;
                    }
                    _cat_Ser_Pack_Assn = value;
                    var newValue = value as FixupCollection<Cat_Ser_Pack_Assn>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCat_Ser_Pack_Assn;
                    }
                }
            }
        }
    	//[XmlElement("Cat_Ser_Pack_Assn", typeof(Collection<Cat_Ser_Pack_Assn>))]
        private ICollection<Cat_Ser_Pack_Assn> _cat_Ser_Pack_Assn;
    
    	//[XmlElement("Cat_Ser_Prod_Assn", typeof(Collection<Cat_Ser_Prod_Assn>))]
        public virtual ICollection<Cat_Ser_Prod_Assn> Cat_Ser_Prod_Assn
        {
            get
            {
                if (_cat_Ser_Prod_Assn == null)
                {
                    var newCollection = new FixupCollection<Cat_Ser_Prod_Assn>();
                    newCollection.CollectionChanged += FixupCat_Ser_Prod_Assn;
                    _cat_Ser_Prod_Assn = newCollection;
                }
                return _cat_Ser_Prod_Assn;
            }
            set
            {
                if (!ReferenceEquals(_cat_Ser_Prod_Assn, value))
                {
                    var previousValue = _cat_Ser_Prod_Assn as FixupCollection<Cat_Ser_Prod_Assn>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCat_Ser_Prod_Assn;
                    }
                    _cat_Ser_Prod_Assn = value;
                    var newValue = value as FixupCollection<Cat_Ser_Prod_Assn>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCat_Ser_Prod_Assn;
                    }
                }
            }
        }
    	//[XmlElement("Cat_Ser_Prod_Assn", typeof(Collection<Cat_Ser_Prod_Assn>))]
        private ICollection<Cat_Ser_Prod_Assn> _cat_Ser_Prod_Assn;

        #endregion
        #region Association Fixup
    
        private void FixupCat_Ser_Assn(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Cat_Ser_Assn item in e.NewItems)
                {
                    item.Category = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Cat_Ser_Assn item in e.OldItems)
                {
                    if (ReferenceEquals(item.Category, this))
                    {
                        item.Category = null;
                    }
                }
            }
        }
    
        private void FixupCat_Ser_Pack_Assn(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Cat_Ser_Pack_Assn item in e.NewItems)
                {
                    item.Category = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Cat_Ser_Pack_Assn item in e.OldItems)
                {
                    if (ReferenceEquals(item.Category, this))
                    {
                        item.Category = null;
                    }
                }
            }
        }
    
        private void FixupCat_Ser_Prod_Assn(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Cat_Ser_Prod_Assn item in e.NewItems)
                {
                    item.Category = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Cat_Ser_Prod_Assn item in e.OldItems)
                {
                    if (ReferenceEquals(item.Category, this))
                    {
                        item.Category = null;
                    }
                }
            }
        }

        #endregion
    }
}
