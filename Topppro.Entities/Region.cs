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

    public enum Region_Enum : int
    {
        am = 1,     // America
        eu = 2,     // Europa
        ao = 3      // Asia
    }
}
