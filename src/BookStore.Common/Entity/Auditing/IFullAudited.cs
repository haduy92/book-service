namespace BookStore.Common.Entities.Auditing
{
    public interface IFullAudited : IAudited, IDeletionAudited
    {}
}