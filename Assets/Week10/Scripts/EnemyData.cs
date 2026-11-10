using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", 
    menuName = "Game Data/Enemy")]
public class EnemyData : ScriptableObject
{
    [Header("Basic Info")]
    public int enemyID;
    public string enemyName;
    public Sprite enemyIcon;


    [Header("Combat Stats")]
    public int baseDamage;
    public int baseHealth;
    public int baseSpeed;

    [Header("Audio Clip")]
    public AudioClip enemySound;
    
}
