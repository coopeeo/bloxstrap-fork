namespace Bloxstrap.Extensions
{
    static class DiscordJoinTypeEx
    {
        public static IReadOnlyCollection<DiscordJoinType> Selections => new DiscordJoinType[]
        {
            DiscordJoinType.Anyone,
            DiscordJoinType.Invites
        };
    }
}
