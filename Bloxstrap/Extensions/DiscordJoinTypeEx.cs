namespace Bloxstrap.Extensions
{
    static class DiscordJoinTypeEx
    {
        public static IReadOnlyCollection<DiscordJoinType> Selections => new DiscordJoinType[]
        {
            DiscordJoinType.Off,
            DiscordJoinType.Anyone,
            DiscordJoinType.Invites
        };
    }
}
