namespace TheGreatestApiInTheWorldTribute.Contracts
{
    public interface IRepositoryManager
    {
        IBandRepository BandRepository { get; }
        IMemberRepository MemberRepository { get; }
        void Save();
    }
}
