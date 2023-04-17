namespace TheGreatestApiInTheWorldTribute.Service.Contracts
{
    public interface IServiceManager
    {
        IBandService BandService { get; }
        IMemberService MemberService { get; }
    }
}
