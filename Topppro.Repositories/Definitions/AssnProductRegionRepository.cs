using Topppro.Interfaces.Repositories;

namespace Topppro.Repositories.Definitions
{
    public class AssnProductRegionRepository
        : Repository<Topppro.Entities.Assn_ProductRegion>, IAssnProductRegionRepository
    {
        public AssnProductRegionRepository() { }

        public AssnProductRegionRepository(ToppproEntities context) :
            base(context)
        {

        }
    }
}
