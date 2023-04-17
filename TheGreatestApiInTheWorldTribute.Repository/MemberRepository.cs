using TheGreatestApiInTheWorldTribute.Contracts;
using TheGreatestApiInTheWorldTribute.Entities.Models;

namespace TheGreatestApiInTheWorldTribute.Repository
{
    public class MemberRepository : RepositoryBase<Member>, IMemberRepository
    {
        public MemberRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
