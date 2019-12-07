﻿using RimWorld;
using Verse;

namespace RimShips.Defs
{
    [DefOf]
    public static class EffectsDefOf_Ships
    {
        static EffectsDefOf_Ships()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(EffectsDefOf_Ships));
        }

        public static ThingDef Gas_Smoke_CannonSmall;
    }
}
