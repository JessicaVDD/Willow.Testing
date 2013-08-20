namespace Willow.Testing.Core
{
    public interface IMatchAnItem<ItemToMatch>
    {
        bool matches(ItemToMatch item);
    }
}