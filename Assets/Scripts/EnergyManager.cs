using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnergyManager : MonoBehaviour
{

    public PlayerStats playerStats;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.GetChild(1).GetComponent<Slider>().value = playerStats.CurrentEnergy;
        transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = playerStats.CurrentEnergy + "/500" ;
    }
}
