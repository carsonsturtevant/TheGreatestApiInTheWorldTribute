using TheGreatestApiInTheWorldTribute.Entities.Models;

namespace TheGreatestApiInTheWorldTribute.Contracts
{
    public interface IBandRepository
    {
        IEnumerable<Band> GetAllBands(bool trackChanges);
    }
}
