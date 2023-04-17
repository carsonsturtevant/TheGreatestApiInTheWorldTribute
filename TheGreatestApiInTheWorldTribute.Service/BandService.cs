using TheGreatestApiInTheWorldTribute.Contracts;
using TheGreatestApiInTheWorldTribute.Service.Contracts;

namespace TheGreatestApiInTheWorldTribute.Service
{
    internal sealed class BandService : IBandService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public BandService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }
    }
}
