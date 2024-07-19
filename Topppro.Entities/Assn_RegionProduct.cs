using xFNet.Common.Extensions;
using xFNet.Entities;

namespace Topppro.Entities
{
    public partial class Assn_RegionProduct : Entity
    {
        public override object Id
        {
            get
            {
                return AssnRegionProductId;
            }
            set
            {
                AssnRegionProductId = value.To<int>();
            }
        }
    }
}
