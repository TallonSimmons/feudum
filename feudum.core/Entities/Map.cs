using feudum.core.ValueObjects;
using System.Collections.Generic;
using System.Linq;

namespace feudum.core.Entities
{
    public class Map
    {
        private int RuledLocations => Players.Sum(x => x.RuledLocations.Count);
        private bool NoLocationsAvailable => RuledLocations == 22;

        public List<Player> Players { get; }

        public void AddRulerToMap(Location location, Player player)
        {
            if (NoLocationsAvailable)
            {
                return;
            }

            GetTargetPlayer(player.Id)?.AddRuler(location);
        }

        public void RemoveRulerFromMap(Location location, Player player)
        {
            GetTargetPlayer(player.Id)?.RemoveRuler(location);
        }

        public void AddPawnToMap(Pawn pawn, Player player)
        {
            GetTargetPlayer(player.Id)?.AddPawn(pawn);
        }

        public void RemovePawnFromMap(Pawn pawn, Player player)
        {
            GetTargetPlayer(player.Id)?.RemovePawn(pawn);
        }

        private Player GetTargetPlayer(int id)
        {
            return Players.FirstOrDefault(p => p.Id == id);
        }
    }
}
