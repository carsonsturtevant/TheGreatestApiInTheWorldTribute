using TheGreatestApiInTheWorldTribute.Contracts;
using TheGreatestApiInTheWorldTribute.Entities.Models;
using TheGreatestApiInTheWorldTribute.Service.Contracts;

namespace TheGreatestApiInTheWorldTribute.Service
{
    internal sealed class BandService : IBandService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;

        public BandService(IRepositoryManager repositoryManager, ILoggerManager logger)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
        }

        public IEnumerable<Band> GetAllBands(bool trackChanges)
        {
            return _repositoryManager.BandRepository.GetAllBands(trackChanges);
        }
    }
}
