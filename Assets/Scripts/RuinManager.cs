using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RuinManager : MonoBehaviour
{

    public PlayerStats playerStats;

    public List<Item> items;
    public InventoryManager inv;
    public GameObject PopUpPanel;

    public List<string> ruinsResponses;

    public void SubstractEnergy()
    {
        if (playerStats.CurrentEnergy >= 150)
        {
            playerStats.CurrentEnergy -= 150;
            dropItem();
        }
    }

    public void dropItem()
    {
        float randomRate = Random.Range(0, 1);
        foreach (Item item in items)
        {
            if (item.dropRate >= randomRate)
            {
                double randomGold = Random.Range(0, 100);
                ShowPopUp(item, randomGold);
                if (inv.ItemsList.Count < 39)
                {
                    print(item);
                    inv.ItemsList.Add(item);
                }
                break;
            }
        }
    }

    public void ShowPopUp(Item item, double gold)
    {
        PopUpPanel.SetActive(true);
        int randomIndex = Random.Range(0, ruinsResponses.Count - 1);
        PopUpPanel.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = ruinsResponses[randomIndex] + " You have been rewarded with " + gold.ToString() + " gold. You stole " + item.name + " and it is +" + item.level + "! Amazing!";
        playerStats.CurrentGold += gold;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
