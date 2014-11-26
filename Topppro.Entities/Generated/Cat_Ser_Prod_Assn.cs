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
    public partial class Cat_Ser_Prod_Assn
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
    
        public virtual Nullable<int> Prority
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
            if (previousValue != null && previousValue.Cat_Ser_Prod_Assn.Contains(this))
            {
                previousValue.Cat_Ser_Prod_Assn.Remove(this);
            }
    
            if (Cat_Ser_Assn != null)
            {
                if (!Cat_Ser_Assn.Cat_Ser_Prod_Assn.Contains(this))
                {
                    Cat_Ser_Assn.Cat_Ser_Prod_Assn.Add(this);
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
            if (previousValue != null && previousValue.Cat_Ser_Prod_Assn.Contains(this))
            {
                previousValue.Cat_Ser_Prod_Assn.Remove(this);
            }
    
            if (Category != null)
            {
                if (!Category.Cat_Ser_Prod_Assn.Contains(this))
                {
                    Category.Cat_Ser_Prod_Assn.Add(this);
                }
                if (CategoryId != Category.CategoryId)
                {
                    CategoryId = Category.CategoryId;
                }
            }
        }
    
        private void FixupProduct(Product previousValue)
        {
            if (previousValue != null && previousValue.Cat_Ser_Prod_Assn.Contains(this))
            {
                previousValue.Cat_Ser_Prod_Assn.Remove(this);
            }
    
            if (Product != null)
            {
                if (!Product.Cat_Ser_Prod_Assn.Contains(this))
                {
                    Product.Cat_Ser_Prod_Assn.Add(this);
                }
                if (ProductId != Product.ProductId)
                {
                    ProductId = Product.ProductId;
                }
            }
        }
    
        private void FixupSerie(Serie previousValue)
        {
            if (previousValue != null && previousValue.Cat_Ser_Prod_Assn.Contains(this))
            {
                previousValue.Cat_Ser_Prod_Assn.Remove(this);
            }
    
            if (Serie != null)
            {
                if (!Serie.Cat_Ser_Prod_Assn.Contains(this))
                {
                    Serie.Cat_Ser_Prod_Assn.Add(this);
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
