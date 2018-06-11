﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGun : Ability, IReloadable
{
    public int maxAmmo;
    public float reloadTime;

    int ammo;
    
    public bool reloading;

    private void Start()
    {
        Reload();
    }

    private void Reload()
    {
        ammo = maxAmmo;
        //print("Reloaded");
    }

    public override void ActivateAbility()
    {
        if(CanShoot())
        {
            base.ActivateAbility();
            ammo--;
            //print("MiniGun Ammo: " + ammo);

            if(ammo <= 0)
            {
                reloading = true;
                StartCoroutine(Reloading());
            }
            TriggerCooldown();
        }
    }

    public bool IsReloading()
    {
        return reloading;
    }

    IEnumerator Reloading()
    {
        yield return new WaitForSeconds(reloadTime);
        Reload();
        reloading = false;
    }
}