using UnityEngine;
using System.Collections.Generic;
using TMPro; 

public class EnemyTracker : MonoBehaviour
{
    private List<string> activeEnemies = new List<string>();
    public TextMeshProUGUI enemyText;

    void Start()
    {
        //CREATE
        activeEnemies.Add("Goblin");
        activeEnemies.Add("Orc");
        activeEnemies.Add("Troll");
        activeEnemies.Add("Dragon");
    }

    public void SpawnEnemy(string enemyName)
    {
        activeEnemies.Add(enemyName);
    }

    void Update()
    {
        enemyText.text = "Active Enemies:\n" + string.Join("\n", activeEnemies);
    }

    public void DefeatEnemy(string enemyName)
    {
        //REMOVE
        if (activeEnemies.Remove(enemyName))
        {
            Debug.Log($"{enemyName} has been defeated.");
        }
        else
        {
            Debug.Log($"There are no more {enemyName}s on the field.");
        }
        UpdateUI();
    }

    public void ClearActiveEnemies()
    {
        if(activeEnemies.Count > 0)
        {
            activeEnemies.Clear();
            Debug.Log("All active enemies have been cleared.");
        }
        else
        {
            Debug.Log("No active enemies to clear.");
        }
        UpdateUI();
    }

    private void UpdateUI()
    {
        //UPDATE
        enemyText.text = "Active Enemies: \n";
        for (int i = 0; i < activeEnemies.Count; i++)
        {
            enemyText.text += $"{activeEnemies[i]}\n";
        }
    }
}
