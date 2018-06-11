using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : MonoBehaviour
{
    public string abilityName;
    public float cooldown;

    protected bool onCooldown;

    public virtual void ActivateAbility()
    {
        //print("Ability Active");
    }

    protected virtual void TriggerCooldown()
    {
        onCooldown = true;
        StartCoroutine(Cooldown());
    }

    public virtual bool CanShoot()
    {
        return !onCooldown;
    }

    protected virtual IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(cooldown);
        onCooldown = false;
    }
}
