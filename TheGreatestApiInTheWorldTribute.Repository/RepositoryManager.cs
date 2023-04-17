using TheGreatestApiInTheWorldTribute.Contracts;

namespace TheGreatestApiInTheWorldTribute.Repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context; 
        private readonly Lazy<IBandRepository> _bandRepository;
        private readonly Lazy<IMemberRepository> _memberRepository;

        public RepositoryManager(RepositoryContext context)
        {
            _context = context;
            _bandRepository = new Lazy<IBandRepository>(() => new BandRepository(context));
            _memberRepository = new Lazy<IMemberRepository>(() => new MemberRepository(context));
        }

        public IBandRepository BandRepository => _bandRepository.Value;

        public IMemberRepository MemberRepository => _memberRepository.Value;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
