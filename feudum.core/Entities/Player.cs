using feudum.core.Enums;
using feudum.core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace feudum.core.Entities
{
    public class Player
    {
        public int Id { get; }
        public PlayerType Type { get; }
        public List<Pawn> Pawns { get; }
        public List<Location> RuledLocations { get; }

        public void AddPawn(Pawn pawn)
        {
            if (Pawns.Count == 3)
            {
                return;
            }

            Pawns.Add(pawn);
        }
        public void RemovePawn(Pawn pawn)
        {
            Pawns.Remove(Pawns.FirstOrDefault(x => x.PlayerId == Id && x.Type == pawn.Type));
        }

        public void AddRuler(Location location)
        {
            RuledLocations.Add(location);
        }

        public void RemoveRuler(Location location)
        {
            RuledLocations.Remove(RuledLocations.FirstOrDefault(l => l.Type == location.Type));
        }

        public void RemoveRuler(Feudum feudum)
        {

        }
    }
}
