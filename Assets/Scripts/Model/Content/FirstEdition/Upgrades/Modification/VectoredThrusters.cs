﻿using Upgrade;
using Ship;
using Abilities;
using ActionsList;

namespace UpgradesList.FirstEdition
{
    public class VectoredThrusters : GenericUpgrade
    {
        public VectoredThrusters() : base()
        {
            UpgradeInfo = new UpgradeCardInfo(
                "Vectored Thrusters",
                UpgradeType.Modification,
                cost: 2,
                restriction: new BaseSizeRestriction(BaseSize.Small)
            );

            UpgradeAbilities.Add(new GenericActionBarAbility<BarrelRollAction>());
        }
    }
}