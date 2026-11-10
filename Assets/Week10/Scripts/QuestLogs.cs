using UnityEngine;
using System.Collections.Generic;

public enum QuestStatus
{ 
    NotStarted,
    InProgress,
    Completed
}

public class QuestLogs : MonoBehaviour

    //Dictionary<Key,Value>
    //Dictrionary<Quest name("String"), Quest Status (Enum)
    //Key= we want to look up/we want to find
    //Value = definition
    //ex. we are sorting high scores
    //Dictionary <string(Players Name), int(Players Score)>
    //How many potions do we have
    //Dictionary<string>(Item name), int(Item Quantity)
{
    private Dictionary<string,QuestStatus> activeQuests = new Dictionary<string,QuestStatus>();
   
    void Start()
    {
        activeQuests.Add("Kill 5 Goblins.", QuestStatus.InProgress);
        activeQuests.Add("Find the treasure.", QuestStatus.Completed);
    }


    public void CheckQuest(string questName)
    {
        if (activeQuests.ContainsKey(questName))
        {
            QuestStatus status = activeQuests[questName];
            Debug.Log($"Quest '{questName}' is currently : {status}");
        } else
        {
            Debug.Log($"You do not have the quest '{questName}'");
        }
    }

    public void UpdateQuest(string questName, QuestStatus newStatus)
    {
        if (activeQuests.ContainsKey(questName))
        {
            activeQuests[questName] = newStatus;
        }
    }
    void Update()
    {
        
    }
}
