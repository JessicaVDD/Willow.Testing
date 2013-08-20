namespace Willow.Testing.Core
{
    public class NegatingMatcher<ItemToMatch> : IMatchAnItem<ItemToMatch>
    {
        public IMatchAnItem<ItemToMatch> to_negate;

        public NegatingMatcher(IMatchAnItem<ItemToMatch> to_negate)
        {
            this.to_negate = to_negate;
        }

        public bool matches(ItemToMatch item)
        {
            return ! this.to_negate.matches(item);
        }
    }
}