using TheGreatestApiInTheWorldTribute.Service.Contracts;

namespace TheGreatestApiInTheWorldTribute.Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IBandService> _bandService;
        private readonly Lazy<IMemberService> _memberService;

        public ServiceManager(Lazy<IBandService> bandService, Lazy<IMemberService> memberService)
        {
            _bandService = bandService;
            _memberService = memberService;
        }

        public IBandService BandService => _bandService.Value;

        public IMemberService MemberService => _memberService.Value;
    }
}
