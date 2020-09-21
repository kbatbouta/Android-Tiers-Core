﻿using System;
using RimWorld;
using Verse;

namespace AndroidTiers
{
    public class ThoughtWorker_AssistedByMinds : ThoughtWorker
    {
     
        public override ThoughtState CurrentStateInternal(Pawn p)
        {
            if (!p.RaceProps.Humanlike)
            {   
                return false;
            }
            if (!p.IsAndroidTier() && !p.VXChipPresent())
            {
                return false;
            }
            if (!Utils.GCATPP.isConnectedToSkyMind(p))
            {
                return false;
            }

            int num = Utils.GCATPP.getNbAssistingMinds();
            if (num > 0)
            {
                return ThoughtState.ActiveAtStage(0);
            }
            return false;
        }
    }
}
