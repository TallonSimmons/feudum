using feudum.core.Enums;

namespace feudum.core.ValueObjects
{
    public class Feudum : Location
    {
        public Feudum(GuildType guildType) : base(LocationType.Feudum)
        {
            GuildType = guildType;
        }

        public GuildType GuildType { get; }
    }
}
