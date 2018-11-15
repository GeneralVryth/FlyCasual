﻿using System.Collections.Generic;
using Upgrade;

namespace Ship
{
    namespace SecondEdition.TIEAdvancedV1
    {
        public class Inquisitor : TIEAdvancedV1
        {
            public Inquisitor() : base()
            {
                PilotInfo = new PilotCardInfo(
                    "Inquisitor",
                    3,
                    40,
                    force: 1
                );

                ShipInfo.UpgradeIcons.Upgrades.Add(UpgradeType.Force);

                SEImageNumber = 102;
            }
        }
    }
}