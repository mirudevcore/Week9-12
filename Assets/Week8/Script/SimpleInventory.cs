using UnityEngine;
using System.Collections.Generic; // Allows to use arrays/lists etc.
using TMPro; //access to TMPRO
public class SimpleInventory : MonoBehaviour
{
    //1. Generic List Declaration
    private List<string> playerItems = new List<string>();
    public TextMeshProUGUI inventoryText; //variable for ui
    void Start()
    {
        //CREATE(Adding Items)
        playerItems.Add("Fire Sword");
        playerItems.Add("Health Potion");
        playerItems.Add("Mana Potion");

    }

    public void AddItem(string itemName) //Adding Items
    { 
        playerItems.Add((itemName));
        UpdateUI();
    }

    public void RemoveItem(string itemName) //Removing Items
    {
        //REMOVE
        if (playerItems.Remove((itemName)))
        {
            Debug.Log($"Remove {itemName} from inventory.");
        }
        else 
        {
            Debug.Log("Could not find item.");
        }
        UpdateUI();
    }

    public void RemoveItemDrop() //Item gets dropped/removed in inventory
    {
        for (int i = playerItems.Count -1 ; i >= 0; i--)  //For loop backwards since number starts at 9 to 0
        {                                                 // i is equal to 200, if 200 is greater and equal to 0, it will decrease and it loops until it reaches 0
                                                           // MAKE SURE TO PUT -1 because all starts to 0
            if (playerItems[i].Contains("Potion")) //removes items that contains the word "potion"
            {
                playerItems.RemoveAt(i); //RemoveAt meanings removing everything that is in "i" = playerItems.Count
            }
        }
        UpdateUI() ;
    }

    private void UpdateUI()
    {

        // UPDATE 
        inventoryText.text = "Inventory Contents: \n";
        for (int i = 0; i < playerItems.Count; i++) 
        {                                           
            inventoryText.text += $"{playerItems[i]}\n";
        }
    }
}
