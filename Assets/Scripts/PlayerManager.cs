using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public PlayerStats playerStats;

    public GameObject InventoryPanel;
    public InventoryManager inventory;

    private void Start()
    {
        StartCoroutine("FillEnergy");
    }

    IEnumerator FillEnergy()
    {
        while (true)
        {
            if (playerStats.CurrentEnergy < 500)
            {
                playerStats.CurrentEnergy++;
            }
            yield return new WaitForSeconds(1);
        }
    }

    public void fightEnemy(Enemy e)
    {
        bool enemyAlive = true;
        if (playerStats.CurrentEnergy >= 4)
        {

            while (!enemyAlive)
            {
                doDamage(e);
                //receiveDamage(e);
            }
        }
    }

    private void doDamage(Enemy e)
    {
        double totalDamage = 0;
        totalDamage += (playerStats.CurrentDamage / e.def) * e.level;
        e.hp -= totalDamage;

        //calculate xp to player
        if (e.hp <= 0)
        {

        }
    }

}
