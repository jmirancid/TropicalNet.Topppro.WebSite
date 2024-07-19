using xFNet.Common.Extensions;
using xFNet.Entities;

namespace Topppro.Entities
{
    public partial class Region : Entity
    {
        public override object Id
        {
            get
            {
                return RegionId;
            }
            set
            {
                RegionId = value.To<int>();
            }
        }
    }

    public enum Region_Enum
    {
        am = 1,
        eu = 2,
        ai = 3
    }
}
