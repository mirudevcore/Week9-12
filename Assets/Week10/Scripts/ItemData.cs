using UnityEngine;

[CreateAssetMenu(fileName = "New Item",
    menuName = "Game Data/Item")]

public class ItemData : ScriptableObject
{
    [Header("Basic Info")]
    public int itemID;
    public string itemName;
    public Sprite itemIcon;
}
