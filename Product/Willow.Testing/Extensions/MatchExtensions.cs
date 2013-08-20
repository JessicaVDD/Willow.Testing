using Willow.Testing.Core;

namespace Willow.Testing.Extensions
{
    public static class MatchExtensions
    {
        public static IMatchAnItem<ItemToMatch> not<ItemToMatch>(this IMatchAnItem<ItemToMatch> item)
        {
            return new NegatingMatcher<ItemToMatch>(item);
        }
    }
}