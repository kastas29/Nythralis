using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : ScriptableObject
{

    public Sprite image;
    public string itemName;
    public int level;
    public int buyPrice;
    public int sellPrice;
    public float dropRate;

}
