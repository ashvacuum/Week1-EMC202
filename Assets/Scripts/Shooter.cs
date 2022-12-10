using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    private void Update()
    {
        if (!Input.GetMouseButtonDown(0)) return;
        if (PoolManager.Instance == null) return;
        var projectile = PoolManager.Instance.GetPooledObject();
        if (projectile == null) return;
        projectile.transform.position = this.transform.position;
        projectile.SetActive(true);
    }

    
    
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Weapon
    {
        Empty = 0,
        AssaultRifle = 1,
        Shotgun = 2,
        Pistol = 3,
        Sniper = 4
    }
}


