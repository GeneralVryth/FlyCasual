﻿using System.Collections;
using System.Collections.Generic;
using Movement;
using ActionsList;
using Upgrade;
using Actions;

namespace Ship
{
    namespace SecondEdition.XWing
    {
        public class XWing : FirstEdition.XWing.XWing, IMovableWings
        {
            public XWing() : base()
            {
                ShipInfo.ShipName = "T-65 X-wing";
                ShipInfo.Hull = 4;
                ShipInfo.UpgradeIcons.Upgrades.Add(UpgradeType.Configuration);
                ShipInfo.ActionIcons.Actions.Add(new ActionInfo(typeof(BarrelRollAction)));

                DialInfo.ChangeManeuverComplexity(new DialManeuverInfo(ManeuverSpeed.Speed2, ManeuverDirection.Left, ManeuverBearing.Bank, MovementComplexity.Easy));
                DialInfo.ChangeManeuverComplexity(new DialManeuverInfo(ManeuverSpeed.Speed2, ManeuverDirection.Right, ManeuverBearing.Bank, MovementComplexity.Easy));
                DialInfo.AddManeuver(new DialManeuverInfo(ManeuverSpeed.Speed3, ManeuverDirection.Left, ManeuverBearing.TallonRoll, MovementComplexity.Complex));
                DialInfo.AddManeuver(new DialManeuverInfo(ManeuverSpeed.Speed3, ManeuverDirection.Right, ManeuverBearing.TallonRoll, MovementComplexity.Complex));

                IconicPilots[Faction.Rebel] = typeof(WedgeAntilles);

                //TODO: ManeuversImageUrl
            }
        }
    }
}
