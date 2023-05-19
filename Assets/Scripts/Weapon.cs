using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Weapon : Item
{
    // Weapons to deal damage

    /*
    WEAPON TYPES EXPLAINED
     - Sword: will do Physical damage at a kind of low attack speed.
     - Dagger: will do Physical damage at a kind of fast attack speed.
     - Bow: will do Physical damage at a kind of medium attack speed.
     - Staff: will do Magical damage at a kind of medium attack speed.
     - Gloves: will do magical damage at a kind of fast attack speed.
    */
    public enum WEAPON_TYPE { SWORD, DAGGER, BOW, STAFF, GLOVES }

    [Tooltip("Base damage that this weapon will deal, without any modifiers.")]
    public int BaseWeaponDamage;
    public WEAPON_TYPE WeaponType;
    [Tooltip("Percentage of critical hits that will be generated")]
    public float CriticalHitRate;
    [Tooltip("The number the damage will be multiplied by")]
    public float CriticalHitModifier;
    [Tooltip("The time in seconds the damage will be generated")]
    public float AttackSpeed;
    public int LevelRequiredToEquip;
}
