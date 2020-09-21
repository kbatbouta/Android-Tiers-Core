﻿using System;
using Verse;

namespace AndroidTiers
{
    public class CompProperties_GSTXSpawner : CompProperties
    {
        public CompProperties_GSTXSpawner()
        {
            this.compClass = typeof(CompGSTXSpawner);
        }
        
        public PawnKindDef Pawnkind;
        public string GSThing;
        public int surrogate = 0;
    }
}
