using Topppro.Interfaces.Business;
using Topppro.Interfaces.Repositories;
using xFNet.Business;

namespace Topppro.Business.Definitions
{
    public class AssnProductRegionBusiness
        : Business<Topppro.Entities.Assn_ProductRegion, IAssnProductRegionRepository>, IAssnProductRegionBusiness
    {
        public AssnProductRegionBusiness() { }

        public AssnProductRegionBusiness(IAssnProductRegionRepository repository) :
            base(repository)
        {
        }
    }
}
