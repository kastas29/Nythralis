using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldManager : MonoBehaviour
{

    public PlayerStats playerStats;

    void Update()
    {
        transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = playerStats.CurrentGold.ToString();
    }
}
