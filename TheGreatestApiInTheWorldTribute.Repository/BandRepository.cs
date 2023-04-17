using TheGreatestApiInTheWorldTribute.Contracts;
using TheGreatestApiInTheWorldTribute.Entities.Models;

namespace TheGreatestApiInTheWorldTribute.Repository
{
    public class BandRepository : RepositoryBase<Band>, IBandRepository
    {
        public BandRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
