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
    public partial class Cat_Ser_Pack_Assn
    {
        #region Primitive Properties
    
        public virtual int CategoryId
        {
            get { return _categoryId; }
            set
            {
                if (_categoryId != value)
                {
                    if (Cat_Ser_Assn != null && Cat_Ser_Assn.CategoryId != value)
                    {
                        Cat_Ser_Assn = null;
                    }
                    if (Category != null && Category.CategoryId != value)
                    {
                        Category = null;
                    }
                    _categoryId = value;
                }
            }
        }
        private int _categoryId;
    
        public virtual int SerieId
        {
            get { return _serieId; }
            set
            {
                if (_serieId != value)
                {
                    if (Cat_Ser_Assn != null && Cat_Ser_Assn.SerieId != value)
                    {
                        Cat_Ser_Assn = null;
                    }
                    if (Serie != null && Serie.SerieId != value)
                    {
                        Serie = null;
                    }
                    _serieId = value;
                }
            }
        }
        private int _serieId;
    
        public virtual int PackageId
        {
            get { return _packageId; }
            set
            {
                if (_packageId != value)
                {
                    if (Package != null && Package.PackageId != value)
                    {
                        Package = null;
                    }
                    _packageId = value;
                }
            }
        }
        private int _packageId;
    
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
    
        public virtual Cat_Ser_Assn Cat_Ser_Assn
        {
            get { return _cat_Ser_Assn; }
            set
            {
                if (!ReferenceEquals(_cat_Ser_Assn, value))
                {
                    var previousValue = _cat_Ser_Assn;
                    _cat_Ser_Assn = value;
                    FixupCat_Ser_Assn(previousValue);
                }
            }
        }
        private Cat_Ser_Assn _cat_Ser_Assn;
    
        public virtual Category Category
        {
            get { return _category; }
            set
            {
                if (!ReferenceEquals(_category, value))
                {
                    var previousValue = _category;
                    _category = value;
                    FixupCategory(previousValue);
                }
            }
        }
        private Category _category;
    
        public virtual Package Package
        {
            get { return _package; }
            set
            {
                if (!ReferenceEquals(_package, value))
                {
                    var previousValue = _package;
                    _package = value;
                    FixupPackage(previousValue);
                }
            }
        }
        private Package _package;
    
        public virtual Serie Serie
        {
            get { return _serie; }
            set
            {
                if (!ReferenceEquals(_serie, value))
                {
                    var previousValue = _serie;
                    _serie = value;
                    FixupSerie(previousValue);
                }
            }
        }
        private Serie _serie;

        #endregion
        #region Association Fixup
    
        private void FixupCat_Ser_Assn(Cat_Ser_Assn previousValue)
        {
            if (previousValue != null && previousValue.Cat_Ser_Pack_Assn.Contains(this))
            {
                previousValue.Cat_Ser_Pack_Assn.Remove(this);
            }
    
            if (Cat_Ser_Assn != null)
            {
                if (!Cat_Ser_Assn.Cat_Ser_Pack_Assn.Contains(this))
                {
                    Cat_Ser_Assn.Cat_Ser_Pack_Assn.Add(this);
                }
                if (CategoryId != Cat_Ser_Assn.CategoryId)
                {
                    CategoryId = Cat_Ser_Assn.CategoryId;
                }
                if (SerieId != Cat_Ser_Assn.SerieId)
                {
                    SerieId = Cat_Ser_Assn.SerieId;
                }
            }
        }
    
        private void FixupCategory(Category previousValue)
        {
            if (previousValue != null && previousValue.Cat_Ser_Pack_Assn.Contains(this))
            {
                previousValue.Cat_Ser_Pack_Assn.Remove(this);
            }
    
            if (Category != null)
            {
                if (!Category.Cat_Ser_Pack_Assn.Contains(this))
                {
                    Category.Cat_Ser_Pack_Assn.Add(this);
                }
                if (CategoryId != Category.CategoryId)
                {
                    CategoryId = Category.CategoryId;
                }
            }
        }
    
        private void FixupPackage(Package previousValue)
        {
            if (previousValue != null && previousValue.Cat_Ser_Pack_Assn.Contains(this))
            {
                previousValue.Cat_Ser_Pack_Assn.Remove(this);
            }
    
            if (Package != null)
            {
                if (!Package.Cat_Ser_Pack_Assn.Contains(this))
                {
                    Package.Cat_Ser_Pack_Assn.Add(this);
                }
                if (PackageId != Package.PackageId)
                {
                    PackageId = Package.PackageId;
                }
            }
        }
    
        private void FixupSerie(Serie previousValue)
        {
            if (previousValue != null && previousValue.Cat_Ser_Pack_Assn.Contains(this))
            {
                previousValue.Cat_Ser_Pack_Assn.Remove(this);
            }
    
            if (Serie != null)
            {
                if (!Serie.Cat_Ser_Pack_Assn.Contains(this))
                {
                    Serie.Cat_Ser_Pack_Assn.Add(this);
                }
                if (SerieId != Serie.SerieId)
                {
                    SerieId = Serie.SerieId;
                }
            }
        }

        #endregion
    }
}
