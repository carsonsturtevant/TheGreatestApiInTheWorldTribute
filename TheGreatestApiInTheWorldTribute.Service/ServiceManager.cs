using TheGreatestApiInTheWorldTribute.Contracts;
using TheGreatestApiInTheWorldTribute.Service.Contracts;

namespace TheGreatestApiInTheWorldTribute.Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IBandService> _bandService;
        private readonly Lazy<IMemberService> _memberService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger)
        {
            _bandService = new Lazy<IBandService>(() =>
            new BandService(repositoryManager, logger));
            _memberService = new Lazy<IMemberService>(() =>
                new MemberService(repositoryManager, logger));
        }

        public IBandService BandService => _bandService.Value;

        public IMemberService MemberService => _memberService.Value;
    }
}
