using TheGreatestApiInTheWorldTribute.Entities.Models;

namespace TheGreatestApiInTheWorldTribute.Service.Contracts
{
    public interface IBandService
    {
        IEnumerable<Band> GetAllBands(bool trackChanges);
    }
}
