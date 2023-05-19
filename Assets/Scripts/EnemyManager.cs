using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public PlayerStats playerStats;
    public Enemy enemy = null;

    public void tryToFight()
    {
        double dmgDealt = 0;

        TextMeshProUGUI RivalText,LogText,dmgNumberText,dmgText,goldText,goldNumber;

        // PlayerManager.fightEnemy(enemy);
        // We could just like, delete the hp of the enemy, and the player as well i guess
        print("Enemy: " + enemy.name + " Health: " + enemy.hp);
        /*
        while(enemy.hp > 0)
        {
            playerStats.CurrentHP -= enemy.dmg - enemy.dmg/playerStats.CurrentDefense;
            enemy.hp -= playerStats.CurrentDamage;
            dmgDealt += playerStats.CurrentDamage;
        }
        */
        RivalText = GameObject.Find("RivalText").GetComponent<TextMeshProUGUI>();
        RivalText.text = enemy.name;
        dmgNumberText = GameObject.Find("dmgNumberText").GetComponent<TextMeshProUGUI>();
        dmgNumberText.text = dmgDealt.ToString();
        goldNumber = GameObject.Find("goldNumber").GetComponent<TextMeshProUGUI>();
        // Calculate random ammount of gold and give it to playerStats
        double randomGold = Random.Range(0, 100);
        playerStats.CurrentGold += randomGold;
    }

}
