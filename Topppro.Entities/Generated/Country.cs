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
    public partial class Country
    {
        #region Primitive Properties
    
        public virtual int CountryId
        {
            get;
            set;
        }
    
        public virtual string Name
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
    
    	//[XmlElement("Distributors", typeof(Collection<Distributor>))]
        public virtual ICollection<Distributor> Distributors
        {
            get
            {
                if (_distributors == null)
                {
                    var newCollection = new FixupCollection<Distributor>();
                    newCollection.CollectionChanged += FixupDistributors;
                    _distributors = newCollection;
                }
                return _distributors;
            }
            set
            {
                if (!ReferenceEquals(_distributors, value))
                {
                    var previousValue = _distributors as FixupCollection<Distributor>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupDistributors;
                    }
                    _distributors = value;
                    var newValue = value as FixupCollection<Distributor>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupDistributors;
                    }
                }
            }
        }
    	//[XmlElement("Distributors", typeof(Collection<Distributor>))]
        private ICollection<Distributor> _distributors;

        #endregion
        #region Association Fixup
    
        private void FixupDistributors(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Distributor item in e.NewItems)
                {
                    item.Country = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Distributor item in e.OldItems)
                {
                    if (ReferenceEquals(item.Country, this))
                    {
                        item.Country = null;
                    }
                }
            }
        }

        #endregion
    }
}
