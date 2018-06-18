using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileAbility : Ability
{
    public override void ActivateAbility()
    {
        if (CanShoot())
        {
            base.ActivateAbility();
            print("Firing " + abilityName);
            TriggerCooldown();
        }
    }
}
