﻿using Upgrade;

namespace Ship
{
    namespace SecondEdition.ARC170Starfighter
    {
        public class SharaBey : ARC170Starfighter
        {
            public SharaBey() : base()
            {
                PilotInfo = new PilotCardInfo(
                    "Shara Bey",
                    4,
                    53,
                    isLimited: true,
                    abilityType: typeof(Abilities.FirstEdition.SharaBeyAbility),
                    extraUpgradeIcon: UpgradeType.Talent,
                    seImageNumber: 67
                );
            }
        }
    }
}