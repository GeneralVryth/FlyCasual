﻿using Upgrade;

namespace Ship
{
    namespace SecondEdition.JumpMaster5000
    {
        public class Manaroo : JumpMaster5000
        {
            public Manaroo() : base()
            {
                PilotInfo = new PilotCardInfo(
                    "Manaroo",
                    3,
                    56,
                    isLimited: true,
                    abilityType: typeof(Abilities.FirstEdition.ManarooAbility),
                    charges: 1,
                    extraUpgradeIcon: UpgradeType.Talent,
                    seImageNumber: 215
                );
            }
        }
    }
}