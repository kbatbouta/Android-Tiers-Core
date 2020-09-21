﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using Verse;
using RimWorld;

namespace AndroidTiers
{
    public class CompAndroidSpawner4T : ThingComp
    {

        public override void CompTick()
        {
            this.CheckShouldSpawn();
        }

        private void CheckShouldSpawn()
        {
            if (true)
            {
                this.SpawnDude();
                this.parent.Destroy();
            }
        }

        public void SpawnDude()
        {
            PawnKindDef pawnKindDef = new List<PawnKindDef>
            {
                PawnKindDefOf.AndroidT4Colonist
            }.RandomElement<PawnKindDef>();
            PawnGenerationRequest request = new PawnGenerationRequest(pawnKindDef, Faction.OfPlayer, PawnGenerationContext.NonPlayer);
            Pawn pawn = PawnGenerator.GeneratePawn(request);

            GenSpawn.Spawn(pawn, parent.Position, parent.Map);
        }
    }
}