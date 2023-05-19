using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Equipment : Item
{
    // This are the items that can be equiped as armor

    public enum EQUIPMENT_TYPE { HELMET, CHESTPLATE, LEGGINS, BOOTS, SHIELD };

    public int PhysicalDefensePoints;
    public int MagicalDefensePoints;
    public EQUIPMENT_TYPE EquipmentType;
    public int HealthPointsAdded;
    public int LevelRequiredToEquip;

    public void Equip()
    {
        
    }

}
