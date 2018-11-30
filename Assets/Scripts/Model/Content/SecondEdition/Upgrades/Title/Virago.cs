﻿using ActionsList;
using Ship;
using System;
using System.Collections.Generic;
using System.Linq;
using Upgrade;

namespace UpgradesList.SecondEdition
{
    public class Virago : GenericUpgrade
    {
        public Virago() : base()
        {
            UpgradeInfo = new UpgradeCardInfo(
                "Virago",
                UpgradeType.Title,
                cost: 10,
                isLimited: true,
                restriction: new ShipRestriction(typeof(Ship.FirstEdition.StarViper.StarViper)),
                addSlot: new UpgradeSlot(UpgradeType.Modification),
                charges: 2,
                abilityType: typeof(Abilities.SecondEdition.ViragoAbility),
                seImageNumber: 155
            );
        }

        public override void PreAttachToShip(GenericShip host)
        {
            base.PreAttachToShip(host);

            Host.ShipInfo.Shields++;
        }

        public override void PreDettachFromShip()
        {
            base.PreDettachFromShip();

            Host.ShipInfo.Shields--;
        }
    }
}

namespace Abilities.SecondEdition
{
    public class ViragoAbility : GenericAbility
    {
        public override void ActivateAbility()
        {
            Phases.Events.OnEndPhaseStart_Triggers += CheckAbility;
        }

        public override void DeactivateAbility()
        {
            Phases.Events.OnEndPhaseStart_Triggers -= CheckAbility;
        }

        private void CheckAbility()
        {
            if (HostUpgrade.Charges > 0 && !HostShip.IsStressed)
            {
                RegisterAbilityTrigger(TriggerTypes.OnEndPhaseStart, AskUseAbility);
            }
        }

        private void AskUseAbility(object sender, EventArgs e)
        {
            Messages.ShowInfo("Virago: You may spend 1 charge to perform a red boost action. There are " + HostUpgrade.Charges + " charges remaining.");
            HostShip.BeforeFreeActionIsPerformed += RegisterSpendChargeTrigger;
            Selection.ChangeActiveShip(HostShip);
            HostShip.AskPerformFreeAction(new BoostAction() { IsRed = true, CanBePerformedWhileStressed = false }, CleanUp);
        }

        private void RegisterSpendChargeTrigger(GenericAction action)
        {
            HostShip.BeforeFreeActionIsPerformed -= RegisterSpendChargeTrigger;
            RegisterAbilityTrigger(
                TriggerTypes.OnFreeAction,
                delegate {
                    HostUpgrade.SpendCharge();
                    Triggers.FinishTrigger();
                }
            );
        }

        private void CleanUp()
        {
            HostShip.BeforeFreeActionIsPerformed -= RegisterSpendChargeTrigger;
            Triggers.FinishTrigger();
        }
    }
}