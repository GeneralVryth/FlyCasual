﻿namespace RulesList
{
    public class FiringArcRule
    {

        public FiringArcRule()
        {
            SubscribeEvents();
        }

        private void SubscribeEvents()
        {
            RulesList.TargetIsLegalForShotRule.OnCheckTargetIsLegal += CanPerformAttack;
        }

        public void CanPerformAttack(ref bool result, Ship.GenericShip attacker, Ship.GenericShip defender)
        {
            if (Combat.SecondaryWeapon == null || !Combat.SecondaryWeapon.IsTurret)
            {
                Board.ShipShotDistanceInformation shotInfo = new Board.ShipShotDistanceInformation(attacker, defender);
                if (!shotInfo.InArc)
                {
                    if (attacker.Owner.Type == Players.PlayerType.Human) Messages.ShowErrorToHuman("Ship is outside your firing arc");
                    result = false;
                }
            }
            else
            {
                // Turret doesn't require in-arc check
            }
        }

    }
}
