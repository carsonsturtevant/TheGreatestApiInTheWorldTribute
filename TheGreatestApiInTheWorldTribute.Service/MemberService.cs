using TheGreatestApiInTheWorldTribute.Contracts;
using TheGreatestApiInTheWorldTribute.Service.Contracts;

namespace TheGreatestApiInTheWorldTribute.Service
{
    internal sealed class MemberService : IMemberService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public MemberService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }
    }
}
