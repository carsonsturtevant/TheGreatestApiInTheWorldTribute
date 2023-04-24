using Microsoft.EntityFrameworkCore;
using TheGreatestApiInTheWorldTribute.Contracts;
using TheGreatestApiInTheWorldTribute.Entities.Models;

namespace TheGreatestApiInTheWorldTribute.Repository
{
    internal sealed class BandRepository : RepositoryBase<Band>, IBandRepository
    {
        public BandRepository(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Band> GetAllBands(bool trackChanges)
        {
            return FindAll(trackChanges)
                .OrderBy(x => x.Name)
                .ToList();
        }
    }
}
