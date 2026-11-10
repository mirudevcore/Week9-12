using UnityEngine;
using System.Collections.Generic;

public class EnemySpawn : MonoBehaviour
{
    //1. assign prefabs
    public EnemyData slimePrefab; //level 1
    public EnemyData goblinPrefab,banditPrefab; //level 2
    public EnemyData dragonPrefab; //level 3
   
    //2. Create Dictionaries
    public Dictionary<int, EnemyData> levelEnemies = new Dictionary<int, EnemyData>();
    void Start()
    {
        //3. Link of the level numbers (Keys) to prefabs (values)
        levelEnemies.Add(1, slimePrefab);
        levelEnemies.Add(2, goblinPrefab);
        levelEnemies.Add(2, banditPrefab);
        levelEnemies.Add(3, dragonPrefab);

        SpawnEnemyForLevel(2, levelEnemies); //spawn level 2 enemies (spawns goblin)
    }

    // this method takes the level and the dictionary parameter to span the object
    public void SpawnEnemyForLevel(int levelNumber, Dictionary<int, EnemyData> enemyLookUpTable)
    {
        //checks if the level exists in dictionary
        if (enemyLookUpTable.ContainsKey(levelNumber))
        {
            EnemyData prefabsToSpawn = enemyLookUpTable[levelNumber];
            Instantiate(prefabsToSpawn);
        }
        else
        {
            Debug.Log("No number level is set up in the dictionary.");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
