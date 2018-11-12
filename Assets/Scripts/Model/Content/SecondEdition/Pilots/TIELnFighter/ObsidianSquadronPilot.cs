﻿using RuleSets;

namespace Ship
{
    namespace SecondEdition.TIELnFighter
    {
        public class ObsidianSquadronPilot : TIELnFighter
        {
            public ObsidianSquadronPilot() : base()
            {
                PilotInfo = new PilotCardInfo(
                    "Obsidian Squadron Pilot",
                    2,
                    24
                );

                SEImageNumber = 91;
            }
        }
    }
}
