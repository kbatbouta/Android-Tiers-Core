﻿using System;
using Verse;
using RimWorld;

namespace AndroidTiers
{
    public class CompProperties_ReloadStation : CompProperties
    {
        public CompProperties_ReloadStation()
        {
            this.compClass = typeof(CompReloadStation);
        }
    }
}