using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{

    public static InventoryManager Instance;
    public List<Item> ItemsList;
    public List<Equipment> EquipmentList;

    public Transform ItemContent;
    public GameObject ItemContentPrefab;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void AddItem(Item item)
    {
        ItemsList.Add(item);
    }

    public void RemoveItem(Item item)
    {
        ItemsList.Remove(item);
    }

    public bool HasItem(Item item)
    {
        foreach (Item i in ItemsList)
        {
            if (i == item) return true;
        }
        return false;
    }

    public void ListItems()
    {
        foreach (Transform item in ItemContent)
        {
            Destroy(item.gameObject);
        }

        foreach (var item in ItemsList)
        {
            GameObject obj = Instantiate(ItemContentPrefab, ItemContent);
            Image itemIcon = obj.transform.Find("Image").GetComponent<Image>();
            itemIcon.sprite = item.image;
        }
    }

}
