using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using System;
using System.Linq;
using UnityEngine.UI;

public class MonsterListManager : MonoBehaviour
{
    public List<Enemy> enemies;

    public GameObject EnemyTemplate;

    // Start is called before the first frame update
    void Start()
    {
        enemies = enemies.OrderBy(o => o.level).ToList(); ;
        CreateListOfEnemies();
    }

    public void CreateListOfEnemies()
    {
        foreach(Enemy e in enemies)
        {
            this.transform.GetChild(0).GetComponent<RectTransform>().sizeDelta = new Vector2(this.transform.GetChild(0).GetComponent<RectTransform>().sizeDelta.x, this.transform.GetChild(0).GetComponent<RectTransform>().sizeDelta.y + 32);
            GameObject newEnemyLabel = Instantiate(EnemyTemplate, this.transform.GetChild(0));
            newEnemyLabel.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = e.name;
            newEnemyLabel.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = e.level.ToString();
            newEnemyLabel.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = e.hp.ToString();
            newEnemyLabel.transform.GetChild(5).GetComponent<TextMeshProUGUI>().text = e.dmg.ToString();
            newEnemyLabel.transform.GetChild(7).GetComponent<TextMeshProUGUI>().text = e.def.ToString();
            newEnemyLabel.GetComponent<EnemyManager>().enemy = e;
        }
    }
}
