using feudum.core.Enums;

namespace feudum.core.ValueObjects
{
    public class Location
    {
        public Location(LocationType type)
        {
            Type = type;
        }

        public virtual LocationType Type { get; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            };

            return ((Location)obj).Type == Type;
        }
    }
}
