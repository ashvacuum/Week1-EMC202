using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float Health;
    public int Experience;
    public Shooter.Weapon Equipment;

    public PlayerData(float health, int experience, Shooter.Weapon equipment)
    {
        this.Health = health;
        this.Experience = experience;
        this.Equipment = equipment;
    }

    public PlayerData()
    {
        Health = 100;
        Experience = 0;
        Equipment = Shooter.Weapon.Empty;
    }
}
